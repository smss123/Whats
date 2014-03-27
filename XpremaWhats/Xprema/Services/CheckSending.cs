using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Xprema.Services
{
  public   class CheckSending:IXpremaService 
    {
      private string phn;
      private string pw;

      public List<PhoneNomberChecker> FailedNumber { get; set; }
      private void config( string  phone, string pwd)
      {
          this.phn = phone;
          this.pw = pwd;
          WappSocket.Create(phone, pwd,"xprema",false);
          WappSocket.Instance.OnConnectSuccess += Instance_OnConnectSuccess;
          WappSocket.Instance.OnConnectFailed += Instance_OnConnectFailed;
          WappSocket.Instance.OnLoginSuccess += Instance_OnLoginSuccess;
          WappSocket.Instance.OnLoginFailed += Instance_OnLoginFailed;
      }


      public Thread ThrdChecker;
      int Counter;
      public void chkforNumbers() {

          List<Data.Xdb.SenderNumberRow> AllPhones = new List<Data.Xdb.SenderNumberRow>();
          Commands.SenderNumberCommand cmd = new Commands.SenderNumberCommand();
          AllPhones = cmd.GetAll();
           foreach (var item in AllPhones  )
              {
                  config(item.SenderNumber, item.Password);
                  Counter++;
              }
      }

      void Instance_OnLoginFailed(string data)
      {
          PhoneNomberChecker num = new PhoneNomberChecker() { Number =phn , Password = pw , Status = data };
          FailedNumber.Add(num);

      }

      void Instance_OnLoginSuccess(byte[] data)
      {
          WappSocket.Instance.Disconnect();
      }

      void Instance_OnConnectFailed(Exception ex)
      {
        
      }

      void Instance_OnConnectSuccess()
      {
          WappSocket.Instance.Login();
      }
        public void StartService()
        {
            Control.CheckForIllegalCrossThreadCalls = true;
            ThrdChecker = new Thread(new ThreadStart(chkforNumbers));
            ThrdChecker.IsBackground = true;
            ThrdChecker.Start();
        }

        public void StopService()
        {
            ThrdChecker.Abort();
            Status = false;
        }

        public bool Status
        {
            get
            {
                return Status;
            }
            set
            {
                Status = value;
            }
     
        }

        public double CurrntStep
        {
            get
            {
                return CurrntStep;
            }
        }


    }
  public class PhoneNomberChecker
  {
      public string  Number { get; set; }
      public string  Password { get; set; }
      public string   Status { get; set; }
  
  }
}

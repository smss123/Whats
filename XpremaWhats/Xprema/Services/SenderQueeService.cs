using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.Commands;
using Xprema.xWatsApp;
using System.Threading;
namespace Xprema.Services
{
   public  class SenderQueeService   :IXpremaService
    {
       public Thread LoopThrd ;
       private SenderNumberCommand Snd = new SenderNumberCommand();
       private WhatsAppNumberCommand wt = new WhatsAppNumberCommand();
       private ServiceWappSocket WhatsAppCommand = new ServiceWappSocket();
       private SenderQueeCommand cmd = new SenderQueeCommand();
       int Counter = 0;

       void StartConfig() {
           LoopThrd = new Thread(new ThreadStart(Configer));
           LoopThrd.IsBackground = true;
           LoopThrd.Start();
       }
       private void Configer()
       {
           var SenderList = Snd.GetAll();
           var WhatsAppNumbers = wt.GetAllWhatsAppNumbers();
           
           foreach (var item in cmd.GetAll())
           {
               if (Counter == SenderList.Count )
               {
                   Counter = 0;
               }
               else
               {
                   Counter++;
               }

               var SenderNumber = SenderList[Counter];
               WhatsAppCommand.Create(SenderNumber.SenderNumber, SenderNumber.Password, "Xprema", false);
               WhatsAppCommand.Instance.OnConnectSuccess += Instance_OnConnectSuccess;


               WhatsAppCommand.Instance.OnConnectFailed += Instance_OnConnectFailed;

           }
       }
       Alerts.Alerts Alrt = new Alerts.Alerts();
       void Instance_OnConnectFailed(Exception ex)
       {
           Alrt.Show_Error_MSG(this, "Connect Failed");
           Status = false;
       }

       void Instance_OnConnectSuccess()
       {
           WhatsAppCommand.Instance.Login();
           Alrt.Show_Info_MSG(this, "   Wellcome ");
           Status = true;
       }

        public void StartService()
        {
         
            while (true) {
                Configer();
            }
          
        }

        public void StopService()
        {
            Status = false;
        }

        public bool Status
        {
            get { return Status; }

            set { Status = value; }
         
        }

        public double CurrntStep
        {
            get { return CurrntStep; }
           
            set { CurrntStep = Counter; }
        }
    }
}

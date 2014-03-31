using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Xprema.xWatsApp
{
   public class ServiceSend
    {
        public string  PhoneNumber { get; set; }
        public string  Password { get; set; }
        public string  Message { get; set; }
        public string  jid { get; set; }

        public List<string> FaildNumbers { get; set; }

        private ServiceWappSocket SendManager = new ServiceWappSocket();
        public ServiceSend()
        {
            this.FaildNumbers = new List<string>();
            this.PhoneNumber = null;
            this.Password = null;
        }

        public void Initlizations()
        {
            SendManager = new ServiceWappSocket();
            SendManager.Create(this.PhoneNumber, this.Password, "Xprema", false);
            SendManager.Instance.OnConnectSuccess += Instance_OnConnectSuccess;
            SendManager.Instance.OnConnectFailed += Instance_OnConnectFailed;
            SendManager.Instance.OnLoginSuccess += Instance_OnLoginSuccess;
            SendManager.Instance.OnLoginFailed += Instance_OnLoginFailed;
            SendManager.Instance.OnGetMessageReceivedServer += Instance_OnGetMessageReceivedServer;
            SendManager.Instance.PollMessages();
        }

        void Instance_OnGetMessageReceivedServer(string from, string id)
        {
            string path = Application.StartupPath +"\\ReMessages";
            if (File.Exists(path))
            {
                File.AppendAllText(path, from + "MsgID=" + id + "\n");
            }
            else
            {
                File.Create(path);
                Application.DoEvents();
                File.AppendAllText(path, from + "MsgID=" + id + "\n");
            }
        }

        void Instance_OnLoginFailed(string data)
        {
            this.FaildNumbers.Add(this.PhoneNumber + "[" + data + "]");
        }

        void Instance_OnLoginSuccess(byte[] data)
        {
            SendManager.Instance.Message(this.jid, this.Message); 
        }

        void Instance_OnConnectFailed(Exception ex)
        {
            throw ex;
        }

        void Instance_OnConnectSuccess()
        {
            SendManager.Instance.Login();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WhatsAppApi;

namespace Xprema.xWatsApp
{
   public class ServiceWappSocket :IDisposable
    {
        protected  WhatsApp _instance;

        public  void Create(string phoneNum, string imei, string nick, bool debug)
        {
            _instance = new WhatsApp(phoneNum, imei, nick, debug);

        }

        public  WhatsApp Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                else
                    //throw new Exception("Instance not set");
                    return null;
            }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            base.MemberwiseClone();
        }
    }
}

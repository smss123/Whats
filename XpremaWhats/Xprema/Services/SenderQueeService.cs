using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.Commands;
using Xprema.xWatsApp;

namespace Xprema.Services
{
   public  class SenderQueeService   :IXpremaService
    {
       private SenderNumberCommand Snd = new SenderNumberCommand();
       private WhatsAppNumberCommand wt = new WhatsAppNumberCommand();
       private ServiceWappSocket WhatsAppCommand = new ServiceWappSocket();
       private SenderQueeCommand cmd = new SenderQueeCommand();

       private void Configer()
       {
           var SenderList = Snd.GetAll();
           var WhatsAppNumbers = wt.GetAllWhatsAppNumbers();
           int Counter=0;
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

           }
       }

       void Instance_OnConnectSuccess()
       {
           WhatsAppCommand.Instance.Login();
       }

        public void StartService()
        {
            throw new NotImplementedException();
        }

        public void StopService()
        {
            throw new NotImplementedException();
        }

        public bool Status
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public double CurrntStep
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}

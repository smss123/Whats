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
       private SenderNumberCommand snd = new SenderNumberCommand();
       private WhatsAppNumberCommand wt = new WhatsAppNumberCommand();
       private SenderQueeCommand cmd = new SenderQueeCommand();
       private ServiceSend Sv = new ServiceSend();

       private int Counter = 0;
       private int Pos=0;
       private void Configer()
       {

           var SenderList = snd.GetAll();
           Sv = new ServiceSend();
           foreach (var item in wt.GetAllWhatsAppNumbers())
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
               Sv.PhoneNumber = SenderNumber.SenderNumber;
               Sv.Password = SenderNumber.Password;
               Sv.Message = "";

           }


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

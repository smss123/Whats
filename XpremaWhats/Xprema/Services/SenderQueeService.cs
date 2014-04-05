using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.Commands;
using Xprema.xWatsApp;
using System .Threading ;
using System.Windows.Forms;
namespace Xprema.Services
{
   public  class SenderQueeService   :IXpremaService
    {
       private SenderQueeCommand cmd = new SenderQueeCommand();
       public  List<string> FaildNumbers = new List<string>();
       public  List<string> NotSendNumber = new List<string>();
       private void Configer()
       {
           var Adver  = cmd.GetAll();
            
           SenderSubService sv = new SenderSubService(0);
           sv.Init();
           foreach (var item in Adver )
           {
               sv.CountOfNumber = item.AdvertismentsRow.NumberGroupsRow.CountOfNumbr;
               sv.GetWhatsAppNumber();
               sv.BeginSend();
               FaildNumbers = sv.FailNumbers;
               NotSendNumber = sv.NotSendNumber;
           }
       }             
                                   
      
       public Thread Thrd;
        public void StartService()
        {
            Control.CheckForIllegalCrossThreadCalls = true;
            Thrd = new Thread(new ThreadStart(Configer));
            Thrd.IsBackground = true;
            Thrd.Start();
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.Commands ;
using Xprema.xWatsApp;

namespace Xprema.Services
{
   public  class SenderSubService
   {
       public Int64  CountOfNumber { get; set; }
       public string  MessageText { get; set; }
       private List<string> ListOfWhatsAppNumber = new List<string>();
      private  SenderNumberCommand SenderCmd = new SenderNumberCommand();
       private ServiceSend  SVsnd = new ServiceSend();
       WhatsAppNumberCommand WhatsCmd = new WhatsAppNumberCommand();
       public SenderSubService(Int64 counter)
       {
           this.CountOfNumber = counter;
           Init();
       }

       public  void Init()
       {
           this.NotSendNumber = new List<string>();
           this.FailNumbers = new List<string>();
           this.MemberwiseClone();
       }

       ===========================================================
       private static readonly Random GetRandom = new Random();
       private static readonly object syncLock = new object();
       public static int GetRandomNumber(int  max)
       {
           lock (syncLock)
           {
               return GetRandom.Next( max);

           }
       }
       //============================================================
       public void GetWhatsAppNumber()
       {
          
           WhatsCmd = new WhatsAppNumberCommand ();
           List<string> xNumbers = new List<string>();
           var WhatsNumbers = (from w in WhatsCmd.GetAllWhatsAppNumbers()
                                orderby w.PhoneNumber ascending 
                                select w.PhoneNumber).ToList();
          

           for (int i = 0; i < CountOfNumber  ; i++)
           {
               xNumbers.Add(WhatsCmd.GetNumberByID(GetRandom.Next(0, WhatsNumbers.Count)).PhoneNumber  ); 
           }
       }
       public List<string> NotSendNumber { get; set; }
        public List<string> FailNumbers { get; set; }

        public void BeginSend()
        {
            SenderCmd = new SenderNumberCommand();
            var SenderList = SenderCmd.GetAll();
            int SenderIndex = 0;
            foreach (var item in ListOfWhatsAppNumber)
            {
                if (SenderIndex == SenderList.Count)
                {
                    SenderIndex = 0;
                }
                var Snd = SenderList[SenderIndex];
                if (Snd.Counter == Snd.NumberOfMessageInDay)
                {

                    NotSendNumber.Add(item);
                }
                else if (Snd.Status == true)
                {
                    SVsnd.jid = item + "@s.whatsapp.net";
                    SVsnd.Message = this.MessageText;
                    SVsnd.PhoneNumber = Snd.SenderNumber;
                    SVsnd.Password = Snd.Password;
                    SVsnd.Initlizations();
                    this.FailNumbers = SVsnd.FaildNumbers;
                    SenderCmd.EditSender(new XdataType.PhoneNumber("", "", Snd.SenderNumber), Snd.Password,
                       int.Parse(Snd.NumberOfMessageInDay.ToString()), Snd.Status, Snd.ID, int.Parse((Snd.Counter - 1).ToString()));

                }
                else
                {
                    NotSendNumber.Add(item);
                }
                SenderIndex++;
            }


        }
    }
}

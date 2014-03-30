using System;
using System.Collections.Generic;
using System.Linq;
using Xprema.Services;
using System.Text;
using WhatsAppApi;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using WhatsAppApi.Helper;
using Xprema.XdataType;
using System.Threading;
using System.Windows.Forms;
namespace Xprema.Services
{
    public class CheckNumbers: IXpremaService 
    {      
        GeneratNumbers GenerateNumbersCmd = new GeneratNumbers();
        WhatsAppNumberCommand WCmd = new WhatsAppNumberCommand();

        public  void  FilteringNumber( ) {
            Commands.SenderNumberCommand c = new Commands.SenderNumberCommand();       
            ContactStore.SyncWaContacts(c.GetAll()[0].SenderNumber ,c.GetAll()[0].Password );       
        }
  
     
       public void StartSaveAllWhatsNoAtXMLFile() {
           Control.CheckForIllegalCrossThreadCalls = true;
           Thread ThrdFilter = new Thread(new ThreadStart(SaveAllWhatsAppNoAtXMLFile));
           ThrdFilter.IsBackground = true;
           ThrdFilter.Start();
       }
       int Counter = 0;
       public void SaveAllWhatsAppNoAtXMLFile()
        {         
            FilteringNumber();
            var Contcts = ContactStore.GetAllContacts();
            foreach (var CntCat in Contcts)
            {
                // ^^  First : Check If Existed Or Not : 
                WCmd = new WhatsAppNumberCommand();
             
                // If Not Existed ,, Start Save It 
                if (!ContactStore.numberExists(CntCat.jid)) {
                    WCmd.AddPhone(new PhoneNumber("", "", CntCat.jid.Split('@').First()),
                        DateTime.Now, new Name("", "", ""), true, "");
                }
                
                 
                Counter ++;
            }
        }


       // ^^^ Thread Check Services
       Thread ThrdCheckServices;

       public void StartService()
       {
           while (Status) { 
           
           if (true ){
           }
           StartSaveAllWhatsNoAtXMLFile();
           }
       }


       public void StopService()
       {
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
               return CurrntStep  ;
           }
           set { CurrntStep = Counter; }
       }


    }
}

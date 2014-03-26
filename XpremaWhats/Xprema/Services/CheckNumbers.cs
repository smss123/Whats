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
namespace Xprema.Commands
{
    public class CheckNumbers

    {
       

        GeneratNumbers GenerateNumbersCmd = new GeneratNumbers();
        WhatsAppNumberCommand WCmd = new WhatsAppNumberCommand();
        public  void  FilteringNumber( ) {
            Commands.SenderNumberCommand c = new Commands.SenderNumberCommand();       
            ContactStore.SyncWaContacts(c.GetAll()[0].SenderNumber ,c.GetAll()[0].Password );
        
        }

       public void SaveAllWhatsAppNoAtXMLFile()
        {
            FilteringNumber();
            var Contcts = ContactStore.GetAllContacts();
            foreach (var CntCat in Contcts)
            {

                WCmd = new WhatsAppNumberCommand();
                WCmd.AddPhone(new PhoneNumber ( "", "", CntCat.jid.Split('@').First()),
                    DateTime.Now, new Name("", "", ""), true, "");
                
            }
        }
    }
}

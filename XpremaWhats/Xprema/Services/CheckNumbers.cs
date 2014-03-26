using System;
using System.Collections.Generic;
using System.Linq;
using Xprema.Services;
using System.Text;
using WhatsAppApi;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;
using Google.GData.Client;
using Google.GData.Contacts;
using Google.GData.Extensions;
using WhatsAppApi.Helper;
namespace Xprema.Services
{
    public class CheckNumbers

    {
       

        GeneratNumbers GenerateNumbersCmd = new GeneratNumbers();
    //--------------------------

        public  void  FilteringNumber( ) {


            Commands.SenderNumberCommand c = new Commands.SenderNumberCommand();
           
            ContactStore.SyncWaContacts(c.GetAll()[0].SenderNumber ,c.GetAll()[0].Password );
            var q = ContactStore.GetAllContacts();

     
        }
     

    }
}

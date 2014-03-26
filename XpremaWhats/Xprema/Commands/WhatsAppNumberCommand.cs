using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XdataType;
using Xprema.Data;
using Xprema.Services;

namespace Xprema.Commands
{
  public   class WhatsAppNumberCommand
      
    {
      public WhatsAppNumberCommand()
      {

      }



      XpremaFileManager cmd = new XpremaFileManager();
      CheckNumbers CheckNumbersCmd = new CheckNumbers();


      public bool AddPhone(PhoneNumber Phone, DateTime Date, Name name, bool status, string Contry)
      {
          try
          {




              return true;
          }
          catch (Exception)
          {
              
              throw;
          }
  
     
      }

      public bool EditPhone(PhoneNumber Phone, DateTime Date, Name name, bool status, string Contry, int ID)
      {
          throw new NotImplementedException();
      }

      public bool DeletePhone(int ID)
      {
          throw new NotImplementedException();
      }

      public List<Data.Xdb.WhatsUpNumberRow> GetAll()
      {
          throw new NotImplementedException();
      }

      public Data.Xdb.WhatsUpNumberRow GetNumberByID(int ID)
      {
          throw new NotImplementedException();
      }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XdataType;
using Xprema.Data;
namespace Xprema.Commands
{
  public   class WhatsAppNumberCommand
    {
      public WhatsAppNumberCommand()
      {

      }

      public bool AddPhone(PhoneNumber Phone, DateTime Date, Name name, bool status, string Contry)
      {

          throw new NotImplementedException();
     
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

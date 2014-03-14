using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XdataType;

namespace Xprema.Commands
{
  public   class UsersCommand
    {

      public bool NewUser(Name UserName, string Password)
      {
          throw new NotImplementedException();
      }
      public bool EditUser(Name UserName, string Password, int ID)
      {
          throw new NotImplementedException();
      }

      public bool DeleteUser(int ID)
      {
          throw new NotImplementedException();
      }

      public bool Login(Name UserName, string Password)
      {
          throw new NotImplementedException();
      }


      public List<Data.Xdb.UsersRow> GetAll()
      {
          throw new NotImplementedException();
      }


    }
}

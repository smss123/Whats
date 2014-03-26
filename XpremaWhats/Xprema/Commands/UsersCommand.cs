using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XdataType;
using Xprema.Data;
using System.Windows.Forms;

namespace Xprema.Commands
{
  public  class UsersCommand
    {
      // {Abu Ehab}

#region"  Add New User "
      public bool NewUser(Name UserName, string Password)
      {
          try
          {
              XpremaFileManager UsersCmd = new XpremaFileManager();
              Xdb.UsersRow Rw = UsersCmd.DB.Users.NewUsersRow();
              Rw.UserName = UserName.FullName;
              Rw.Password = Password;
              UsersCmd.DB.Users.AddUsersRow(Rw);
              UsersCmd.CommitData();
              UsersCmd.Dispose();
              return true;
          }
          catch (Exception)
          {
              
              throw;
          }
      }
#endregion

#region" Edit User "
      public bool EditUser(Name UserName, string Password, int ID)
      {
          try
          {
              XpremaFileManager UsersCmd = new XpremaFileManager();

              foreach (Data.Xdb.UsersRow Rw in UsersCmd.DB.Users.Rows)
              {
                  if (Rw.ID == ID) {

                      Rw.UserName = UserName.FullName;
                      Rw.Password = Password;
                      UsersCmd.CommitData();

                      Application.DoEvents();
                      UsersCmd.Dispose();
                  }
  
              }

              return true;
          }
          catch (Exception)
          {
              
              throw;
          }
      }
#endregion

#region"  Delete User "
      public bool DeleteUser(int ID)
      {
          try
          {
              XpremaFileManager UsersCmd = new XpremaFileManager();

              foreach (Data.Xdb.UsersRow Rw in UsersCmd.DB.Users.Rows)
               {
                   if (Rw.ID == ID)
                   {

                       UsersCmd.CommitData();
                       Application.DoEvents();
                       UsersCmd.Dispose();
                   }
               }
                 return true ;
          }
          catch (Exception)
          {
              
              throw;
          }
      }
#endregion

#region "Start User  Login      [Un Completed]" 

      public bool Login(Name UserName, string Password)
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

#endregion

 #region " List Off All Users "
      public List<Data.Xdb.UsersRow> GetAllUsers()

      {
                XpremaFileManager UserCmd = new XpremaFileManager();
                var AllUsers = (from Usr 
                           in UserCmd.DB.Users.AsQueryable ()
                           orderby Usr .ID 
                           ascending 
                           select Usr).ToList ();
                UserCmd.Dispose();
                return AllUsers;
      }


  #endregion

  #region" Get Single User "
      public Data.Xdb.UsersRow GetSingleUserByID(int xID) {
          XpremaFileManager UserCmd = new XpremaFileManager();
          var Usr = (from ur in UserCmd.DB.Users
                     where ur.ID == xID 
                     select ur).Single();
          UserCmd.Dispose();
          return Usr;
               
      }
   #endregion


    }

}

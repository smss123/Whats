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
      // { Abu Ehab }
      XpremaFileManager WhatsCmd = new XpremaFileManager();

      #region " Add New WhatsApp Number          "

      public bool AddPhone(PhoneNumber Phone, DateTime Date, Name name, bool status, string Contry)
      {
          try
          {
              WhatsCmd = new XpremaFileManager();

              Data.Xdb.WhatsUpNumberRow Rw = WhatsCmd.DB.WhatsUpNumber.NewWhatsUpNumberRow();

              Rw.PhoneNumber = Phone.FullPhoneNumber;
              Rw.CreatedDate = DateTime.Now;
              Rw.Name = name.FullName;
              Rw.Status = true;
              Rw.Contry = Contry;

              WhatsCmd.DB.WhatsUpNumber.AddWhatsUpNumberRow(Rw);
              WhatsCmd.CommitData();
              WhatsCmd.Dispose();
              return true;
          }
          catch (Exception)
          {

              throw;
          }


      }

      #endregion 

      #region "    Edit WhatsApp PhoneData        "


      public bool EditPhone(PhoneNumber Phone, DateTime Date, Name name, bool status, string Contry, int ID)
      {
          try
          {
              WhatsCmd = new XpremaFileManager();
              foreach (Xdb.WhatsUpNumberRow Rw in WhatsCmd.DB.WhatsUpNumber.Rows)
              {
                  if (Rw.ID == ID)
                  {
                      Rw.PhoneNumber = Phone.FullPhoneNumber;
                      Rw.CreatedDate = DateTime.Now;
                      Rw.Name = name.FullName;
                      Rw.Status = true;
                      Rw.Contry = Contry;

                      WhatsCmd.CommitData();
                      WhatsCmd.Dispose();
                      return true;

                  }
              }

              return false;
          }

          catch (Exception)
          {

              throw;
          }
      }

      #endregion

      #region "  Delete WhatsApp Phone        "

      public bool DeletePhone(int ID)
      {
          try
          {
              WhatsCmd = new XpremaFileManager();
              foreach (Xdb.WhatsUpNumberRow Rw in WhatsCmd.DB.WhatsUpNumber.Rows)
              {
                  if (Rw.ID == ID)
                  {
                      Rw.Delete();
                      WhatsCmd.CommitData();
                      WhatsCmd.Dispose();
                      return true;

                  }
              }
              return false;
          }
          catch (Exception)
          {

              throw;
          }
      }

      #endregion

      #region "   Get All  WhatsApp Numbers     "
      public List<Data.Xdb.WhatsUpNumberRow> GetAllWhatsAppNumbers()
      {
          try
          {
              WhatsCmd = new XpremaFileManager();
              var Whts = (from w
                          in WhatsCmd.DB.WhatsUpNumber.AsQueryable()
                          orderby w.CreatedDate
                          ascending
                          select w).ToList();
              return Whts;

          }
          catch (Exception)
          {

              throw;
          }
      }


      #endregion "         "

      #region "   Get Single WhatsApp Given By ID      "
      public Data.Xdb.WhatsUpNumberRow GetNumberByID(int ID)
      {
          try
          {
              WhatsCmd = new XpremaFileManager();
              var Whts = (from w
                          in WhatsCmd.DB.WhatsUpNumber
                          where w.ID == ID
                          select w).SingleOrDefault ();
              return Whts;
          }
          catch (Exception)
          {

              throw;
          }
      }

      #endregion

 
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xprema.XdataType;
using Xprema.Data;
namespace Xprema.Commands
{
  public   class AdvertisemetCommand
    {

      public bool AddAdvertisement(string message, int CustomerID)
      {
          XpremaFileManager Cmd = new XpremaFileManager();
          Xdb.AdvertismentsRow row = Cmd.DB.Advertisments.NewAdvertismentsRow();
          row.CreatedDate = DateTime.Now;
          row.CustomerID = CustomerID;
          row.MessageText = message;
          Cmd.DB.Advertisments.AddAdvertismentsRow(row);
          Cmd.CommitData();
          Cmd.Dispose();
          return true;
          
      }

      public bool EditAdvertismet(string message, int CustomerID, int ID)
      {
          XpremaFileManager cmd = new XpremaFileManager();

          foreach (Xdb.AdvertismentsRow  item in cmd.DB.Advertisments.Rows )
          {
              if (item.ID==ID)
              {
                  item.MessageText = message;
                  item.CustomerID = CustomerID;
                  cmd.CommitData();
                  cmd.Dispose();
                  return true;
              }
          }
          return true;
      }

      public bool DeleteAdvertisment(int ID)
      {
          XpremaFileManager cmd = new XpremaFileManager();
         
          foreach (var item in cmd.DB.Advertisments )
          {
              if (item.ID==ID)
              {
                  item.Delete();
                  cmd.CommitData();
                  return true;
              }
          }
          return false;
      }

      public List<Data.Xdb.AdvertismentsRow> GetAll()
      {
          XpremaFileManager cmd = new XpremaFileManager();
          var q = (from i in cmd.DB.Advertisments.AsQueryable() select i).ToList();
          cmd.Dispose();
          return q;

      }
      public Data.Xdb.AdvertismentsRow GetByID(int ID)
      {
          XpremaFileManager cmd = new XpremaFileManager();
          var q = (from i in cmd.DB.Advertisments.AsQueryable() where i.ID == ID select i).Take(1).SingleOrDefault();
          cmd.Dispose();
          return q;
         
      }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.Commands
{
  public   class AdvertisemetCommand
    {

      public bool AddAdvertisement(string message, int CustomerID)
      {
          throw new NotImplementedException();
      }

      public bool EditAdvertismet(string message, int CustomerID, int ID)
      {
          throw new NotImplementedException();
      }

      public bool DeleteAdvertisment(int ID)
      {
          throw new NotImplementedException();
      }

      public List<Data.Xdb.AdvertismentsRow> GetAll()
      {
          throw new NotImplementedException();
      }
      public Data.Xdb.AdvertismentsRow GetByID(int ID)
      {
          throw new NotImplementedException();
      }

    }
}

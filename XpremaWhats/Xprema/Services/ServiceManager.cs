using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.Services
{
  public   class ServiceManager
    {
      public static CheckSending checksender = new CheckSending();
      public static GeneratNumbers generatNumber = new GeneratNumbers();
      public static CheckNumbers checknumber = new CheckNumbers();

    }
}

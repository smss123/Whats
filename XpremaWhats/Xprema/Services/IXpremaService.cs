using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.Services
{
  public   interface IXpremaService
    {
      void StartService();
      void StopService();
       bool  Status { get; set; }

        double  CurrntStep { get; set; }
    }
}

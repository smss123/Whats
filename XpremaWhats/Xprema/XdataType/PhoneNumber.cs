using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.XdataType
{
  public   class PhoneNumber
    {
        public string  ContryCode { get; set; }
        public string  CityCode { get; set; }
        public string  Phone { get; set; }
        public string FullPhoneNumber { get { return ContryCode +CityCode + Phone; } }

      public PhoneNumber(string contryCode, string cityCode, string phone){
          this.ContryCode  = contryCode;
          this.CityCode = cityCode;
          this.Phone= phone;
      }

    }
}

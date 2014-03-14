using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.XdataType
{
public     class Name
    {
        public string  FirstName { get; set; }
        public string  MidName { get; set; }
        public string  LastName { get; set; }
        public string  FullName { get {return FirstName +" "+ MidName  +" " + LastName}}
    public Name(string Fname, string MName, string LName){
        this.FirstName = Fname;
        this.MidName= MName;
        this.LastName= LName;
    }
    }
}

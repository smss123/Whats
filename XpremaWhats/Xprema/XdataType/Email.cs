﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xprema.XdataType
{
public     class Email
    {


        public string  EmailName { get; set; }
        public string  EmailHost { get; set; }
        private string fullEmail;

        public string FullEmail
        {
            get { return EmailName + "@"+EmailHost; }
            set { checkEmail( value); }
        }

        private void checkEmail(string value)
        {
            throw new NotImplementedException();
        }


    }
}

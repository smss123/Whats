﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WhatsAppApi;

namespace Xprema.Services
{
    class WappSocket
    {
        protected static WhatsApp _instance;

        public static void Create(string phoneNum, string imei, string nick, bool debug)
        {
            _instance = new WhatsApp(phoneNum, imei, nick, debug);
            
        }

        public static WhatsApp Instance
        {
            get
            {
                if (_instance != null)
                    return _instance;
                else
                    //throw new Exception("Instance not set");
                    return null;
            }
        }
    }
}

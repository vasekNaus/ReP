﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altairis.FutLabIS.Web {
    public class AppSettings {

        public SecurityConfig Security { get; set; } = new SecurityConfig();

        public class SecurityConfig {
            public int MinimumPasswordLength { get; set; } = 12;
            public int DefaultPasswordLength { get; set; } = 14;
            public int LoginCookieExpirationDays { get; set; } = 30;
        }

        public MailingConfig Mailing { get; set; } = new MailingConfig();

        public class MailingConfig {
            public bool UseSendGrid { get; set; }
            public string PickupFolder { get; set; } = @"C:\InetPub\MailRoot\pickup";
            public string SendGridApiKey { get; set; }
            public string SenderName { get; set; }
            public string SenderAddress { get; set; }
        }

    }
}
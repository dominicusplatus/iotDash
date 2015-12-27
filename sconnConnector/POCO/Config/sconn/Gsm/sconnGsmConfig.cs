﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sconnConnector.POCO.Config.Abstract;
using sconnConnector.POCO.Config.sconn;

namespace sconnConnector.POCO.Config
{
    public class sconnGsmConfig
    {
        public int RcptNo { get; set; }
        public List<sconnGsmRcpt> Rcpts { get; set; }

        public sconnGsmConfig()
        {
                
        }

        public sconnGsmConfig(ipcSiteConfig cfg) :this()
        {
            Rcpts = new List<sconnGsmRcpt>();
        }
    }

}

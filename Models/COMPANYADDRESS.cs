﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OraCoreIdentity3.Models
{
    public class COMPANYADDRESS
    {
        public int COMPANYID { get; set; }
        public int MAINADDRESSESID { get; set; }
        public string STREETADDRESS { get; set; }
        public string COUNTRYCODE { get; set; }
        public string LAT { get; set; }
        public string LNG { get; set; }
    }
}

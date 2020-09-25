﻿using System;
using System.Collections.Generic;
using System.Text;

namespace dal.entities
{
    public class Route
    {
        public string ID { get; set; }
        public string PARENT_REGION_ID { get; set; }
        public string VALUE_SUM { get; set; }
        public string VALUE_WOMEN_KID { get; set; }
        public string VALUE_WOMEN_ADULT { get; set; }
        public string VALUE_WOMEN_SENIOR { get; set; }
        public string VALUE_MEN_KID { get; set; }
        public string VALUE_MEN_ADULT { get; set; }
        public string VALUE_MEN_SENIOR { get; set; }
        public string REGION_NAME { get; set; }
        public string CITY_FROM_ID { get; set; }
        public string CITY_TO_ID { get; set; }
        public string CITY_FROM { get; set; }
        public string CITY_TO { get; set; }
    }
}

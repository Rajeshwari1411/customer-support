namespace customersupports.Models
{
    using System;
    using System.Collections.Generic;

    public partial class custinfo
    {
        public int logid { get; set; }
        public string customer_email { get; set; }
        public string customer_name { get; set; }
        public string log_status { get; set; }
        public string descriptions { get; set; }
    }
}

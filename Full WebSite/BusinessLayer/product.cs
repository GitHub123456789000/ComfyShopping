using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FullWebSite.BusinessLayer
    {
    public class product
        {

        public int pro_id { get; set; }
        public string pro_name { get; set; }
        public string pro_date { get; set; }
        public decimal pro_price { get; set; }
       

        public string pro_img { get; set; }

        public int pro_adminid_fk { get; set; }

        public int pro_subcatid_fk { get; set; }

    }
}
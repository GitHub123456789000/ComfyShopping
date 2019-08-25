using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FullWebSite.BusinessLayer
    {
    public class admin
        {
        public int id { get; set; }
        public string email { get; set; }
        public string password { get; set; }
       
        }
    }
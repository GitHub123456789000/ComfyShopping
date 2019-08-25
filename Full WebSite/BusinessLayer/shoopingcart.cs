using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullWebSite.BusinessLayer
{
    public class shoopingcart
    {
        public int cart_id { get; set; }
        public string cart_name { get; set; }
        public string cart_price { get; set; }
        public string cart_img { get; set; }
        public int cart_subcat { get; set; }
       
    }
}
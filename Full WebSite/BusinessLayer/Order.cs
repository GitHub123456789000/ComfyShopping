using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FullWebSite.BusinessLayer
{
    public class Order
    {
           public int order_id { get; set; }
            public decimal order_price { get; set; }
            public string placed_date { get; set; }
            public int customer_id { get; set; }


        }
    }

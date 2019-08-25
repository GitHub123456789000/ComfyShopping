using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FullWebSite.BusinessLayer;

namespace FullWebSite
    {
    public partial class Home_Main : System.Web.UI.Page
        {
        protected void Page_Load(object sender, EventArgs e)
            {

            if (Session["F_Qua"] != null && Session["F_total"] != null)
            {
                ((Site1)Master).cart_Quantity.Text = (Session["F_Qua"].ToString());
                ((Site1)Master).cart_Price.Text = (Session["F_total"].ToString());
                
            }

        }
    }
    }
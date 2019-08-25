using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullWebSite.Checkout
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)

        {
            //if (Session["OrderNumber"] != null)
            //{
                Label1.Text = "Thank You For Shopping your Order Number Is " + Session["OrderNumber"];
                //Session.RemoveAll();
                //Session.Abandon();
            //}
            //else
            //{
            //    Response.Redirect("~/CartStatus/EmptyCart.aspx");
            //}
        }
    }
}
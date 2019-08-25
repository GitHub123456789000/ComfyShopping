using FullWebSite.BusinessLayer;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.UI.WebControls;

namespace FullWebSite
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
         {

            if (Session["customer_mail"] != null)
            {

                Label2.Text = Session["customer_mail"].ToString();
            }
            else
            {
                Label2.Text = "Welome Guest ";
            }








        }

        public Label cart_Quantity
        {
            get
            {
                return Label3;
            }
        }

        public Label cart_Price
        {
            get
            {
                return Label1;
            }
        }

      

        //public LinkButton searchButton
        //{
        //    get
        //    {
        //        return this.LinkButton1;
        //    }
        //}
       


        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("~/Home_Main.aspx");
        }
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Session["TextSearch"] = TextBox1.Text;
        Response.Redirect("~/Search Page/Product Search.aspx");
        }

    }
}
    
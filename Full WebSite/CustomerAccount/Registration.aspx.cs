using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using FullWebSite.BusinessLayer;

namespace FullWebSite.CustomerAccount
{
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["F_Qua"] != null && Session["F_total"] != null)
            {
                ((Site1)Master).cart_Quantity.Text = (Session["F_Qua"].ToString());
                ((Site1)Master).cart_Price.Text = (Session["F_total"].ToString());
            }
        }

        protected void Csignin_Click(object sender, EventArgs e)
            
        {
            
            if (Page.IsValid)
            {
                selectdata sd = new selectdata();
                string s = sd.returnscalar("select count(cu_id) from tbl_custom  where cu_email='" + email.Text + "'");
                if (s == "0")
                {
                    customer c = new customer();
                    c.email = email.Text;
                    c.password = password.Text;
                    c.phone = phone.Text;

                    insert i = new insert();
                    Session["customer_id"] = i.signup_customer(c);
                    if (Session["customer_id"] == null) 
                    {
                        Label1.Text = "some exception ";
                    }
                    else
                    {
                       
                        Session["customer_mail"] = sd.returnscalar("select cu_email from tbl_custom where cu_id=" + Session["customer_id"]);
                       
                    
                        Response.Redirect("~/Home_Main.aspx");

                    }

                }
                else
                {

                    Label1.Text = "Email already exist";

                }
               





            }
        }
    }
}
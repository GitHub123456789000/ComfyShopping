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
    public partial class CLogIn : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
              if (Request.Cookies["email.Text"] != null && Request.Cookies["password.Text"] != null)
                {
                    email.Text = Request.Cookies["email.Text"].Value;
                    password.Text = Request.Cookies["password.Text"].Value;
                }
                //HttpCookie cookie = Request.Cookies["customerInfo"];
                //if (cookie != null)
                //{
                //    email.Text = cookie["email.Text"];
                //    password.Text = cookie["email.password"];
                //}
            }
            if (Session["F_Qua"] != null && Session["F_total"] != null)
            {
                ((Site1)Master).cart_Quantity.Text = (Session["F_Qua"].ToString());
                ((Site1)Master).cart_Price.Text = (Session["F_total"].ToString());
            }
        }



        protected void Csignin_Click(object sender, EventArgs e)
        {
            
            
                selectdata sd = new selectdata();
                string user = sd.returnscalar("select count(cu_id) from tbl_custom  where cu_email='"+ email.Text+"'");
            if (user == "1")
            {

                string pass = sd.returnscalar("select cu_password from tbl_custom where cu_email= '" + email.Text + "'");
                if (pass != password.Text)
                {
                    Label7.Text = "Password is wrong";
                }
                else
                {

                    Session["customer_mail"] = email.Text;
                  
                
                    Session["customer_id"] = sd.cust_id("select cu_id from tbl_custom where cu_email = '" +  Session["customer_mail"] + "'");
                    
                    if (CheckBox1.Checked)
                    {
                        //HttpCookie cookie = new HttpCookie("customerInfo");
                        //cookie["email.Text"] = email.Text;
                        //cookie["password.Text"] = email.Text;
                        //Response.Cookies.Add(cookie);
                        //cookie.Expires = DateTime.Now.AddDays(20);

                        Response.Cookies["email.Text"].Value = email.Text;
                        Response.Cookies["password.Text"].Value = password.Text;
                        Response.Cookies["email.Text"].Expires = DateTime.Now.AddDays(20);
                        Response.Cookies["password.Text"].Expires = DateTime.Now.AddDays(20);
                    }
                    else
                    {
                        Response.Cookies["email.Text"].Expires = DateTime.Now.AddMinutes(-1);
                        Response.Cookies["password.Text"].Expires = DateTime.Now.AddMinutes(-1);
                    }
                    Response.Redirect("~/Home_Main.aspx");
                }
            }
            else
            {
                Label1.Text = "Email is wrong";
            }
            }

        protected void Csignup_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/CustomerAccount/Registration.aspx");
        }

            } } 

            
    
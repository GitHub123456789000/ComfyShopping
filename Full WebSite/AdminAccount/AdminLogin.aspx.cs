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


namespace FullWebSite
{
    public partial class Account : System.Web.UI.Page
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
               
            }
        }
        


        protected void Asignin_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                selectdata sd = new selectdata();
                string user = sd.returnscalar("select count(ad_id) from tbl_admin  where ad_email='" + email.Text + "'");
                if (user == "1")
                {

                    string pass = sd.returnscalar("select ad_password from tbl_admin where ad_email= '" + email.Text + "'");
                    if (pass != password.Text)
                    {
                        Label7.Text = "Password is wrong";

                    }
                    else
                    {
                        string id = sd.returnscalar("select ad_id from tbl_admin where ad_email= '" + email.Text + "'");
                        Session["admin_id"] = "1";
                        Session["admin_mail"] = email.Text;
                          if (CheckBox1.Checked)
                        {

                            Response.Cookies["Aemail.Text"].Value = email.Text;
                            Response.Cookies["Apassword.Text"].Value = password.Text;
                            Response.Cookies["Aemail.Text"].Expires = DateTime.Now.AddDays(20);
                            Response.Cookies["Apassword.Text"].Expires = DateTime.Now.AddDays(20);
                        }
                        else
                        {
                            Response.Cookies["Aemail.Text"].Expires = DateTime.Now.AddMinutes(-1);
                            Response.Cookies["Apassword.Text"].Expires = DateTime.Now.AddMinutes(-1);
                        }
                        Response.Redirect("~/AdminAccount/AdminPannel.aspx");
                    }
                    }
                else
                {
                    Label1.Text = "Email is wrong";
                }
            }
                    
                        
                   
                
               
            }

        }



    }

        
            





           
           
           

            
            


        
    
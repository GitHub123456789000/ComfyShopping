using FullWebSite.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FullWebSite
{
    public partial class Admin_In_Boot : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            TextBox2.Text = DateTime.Now.ToString();
            if (!IsPostBack)
            {
                HyperLink1.Visible = false;



                  MultiView1.ActiveViewIndex = 0;



                Session["admin_mail"] = 1;
                if (Session["admin_mail"] != null)
                {

                    //     Label1.Text = Session["admin_mail"].ToString();
                    //Testing purpose session variable got hard coded value




                }
                else
                {
                    Response.Redirect("~/AdminAccount/AdLogin.aspx");
                }

               




                selectdata sd1 = new selectdata();
                DropDownList1.DataSource = sd1.GetData("sp_main_categories", null);
                DropDownList1.DataBind();
                ListItem li_main = new ListItem("Select Categories", "-1");
                DropDownList1.Items.Insert(0, li_main);

                ListItem li_sub_main = new ListItem("Select Sub Categories", "-1");
                DropDownList2.Items.Insert(0, li_sub_main);
                DropDownList2.Enabled = false;
               

            }
            TextBox2.Text = DateTime.Now.ToString();
            selectdata sd = new selectdata();
            DataSet ds = sd.SortOrder();
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }












        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("~/Home_Main.aspx");
        }

        protected void AddPost_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }

        protected void ViewAdd_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {


        }
        public string img_upload(FileUpload FileUpload1, string id)
        {
            string s = " ";
            if (FileUpload1.HasFile)
            {
                // Get the file extension
                string fileExtension = System.IO.Path.GetExtension(FileUpload1.FileName);

                if (fileExtension.ToLower() != ".png" && fileExtension.ToLower() != ".jpg" && fileExtension.ToLower() != ".jpeg")
                {
                    Label2.ForeColor = System.Drawing.Color.Red;
                    Label2.Text = "Only files with .png  .jpg and jpeg extension are allowed";
                }
                else
                {
                    // Get the file size
                    int fileSize = FileUpload1.PostedFile.ContentLength;
                    // If file size is greater than 2 MB
                    if (fileSize > 2097152)
                    {
                        Label2.ForeColor = System.Drawing.Color.Red;
                        Label2.Text = "File size cannot be greater than 2 MB";
                    }
                    else
                    {
                        Random r = new Random();
                        int x = r.Next(0, 100000);
                        s = "~/img/" + id.ToString() + x.ToString() + FileUpload1.FileName;
                        // Upload the file
                        FileUpload1.SaveAs(Server.MapPath(s));
                        Label2.ForeColor = System.Drawing.Color.Green;
                        Label2.Text = "File uploaded successfully";



                    }
                }
            }
            else
            {
                Label2.ForeColor = System.Drawing.Color.Red;
                Label2.Text = "Please select a file";
            }

            return s;

        }


        private void drop2Changed()
        {
            ListItem li_sub_main = new ListItem("Select Sub Categories", "-1");
            DropDownList2.Items.Insert(0, li_sub_main);
            
        }
        protected void Button2_Click(object sender, EventArgs e)
        {

        }



        protected void Button3_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {



                Session["admin_id"] = "1";

                product p = new product();
                p.pro_name = TextBox1.Text;
                p.pro_date = TextBox2.Text;
                p.pro_price = Convert.ToDecimal(TextBox3.Text);
                p.pro_img = img_upload(FileUpload3, Session["admin_id"].ToString());
                p.pro_adminid_fk = Convert.ToInt32(Session["admin_id"].ToString());
                p.pro_subcatid_fk = Convert.ToInt32(DropDownList2.SelectedValue.ToString());

                insert i = new insert();
                string k = i.insert_tblproduct(p);
                if (k == "-1")
                {
                    Label2.Text = "TRY AGAIN ....";
                }
                else
                {


                    if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 1)
                    {

                        HyperLink1.NavigateUrl = "~/Womens/WomensShoes.aspx";
                    }
                    else if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 2)
                    {
                        HyperLink1.NavigateUrl = "~/Womens/WomensCoats.aspx";

                    }
                    else if (DropDownList1.SelectedIndex == 1 && DropDownList2.SelectedIndex == 3)
                    {
                        HyperLink1.NavigateUrl = "~/Womens/WomensTop.aspx";

                    }

                    else if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 1)
                    {
                        HyperLink1.NavigateUrl = "~/Mens/MensJeans.aspx";

                    }
                    else if (DropDownList1.SelectedIndex == 2 && DropDownList2.SelectedIndex == 2)
                    {
                        HyperLink1.NavigateUrl = "~/Mens/MensJackets.aspx";

                    }
                    else
                    {
                        Label2.Text = "Add not available for view";
                    }

                    Label2.Text = "Ad successfully posted!";

                    HyperLink1.Visible = true;
                    HyperLink1.Text = " View Add Online";
                   
                    TextBox1.Text = "";
                  
                    TextBox3.Text = "";
                    DropDownList1.SelectedIndex = 0;
                    drop2Changed();
                    DropDownList2.Enabled = false;
                    DropDownList2.SelectedIndex = 0;
                    
                       
                       
                    
                    
                    //Response.Redirect("~/AdminAccount/AdminPannel.aspx");



                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedIndex == 0)
            {
                drop2Changed();
                DropDownList2.Enabled = false;
                DropDownList2.SelectedIndex = 0;
                HyperLink1.Visible = false;
                Label2.Text = "";




            }


            else
            {
                DropDownList2.Enabled = true;
                SqlParameter para = new SqlParameter("@cat_id", DropDownList1.SelectedValue);
                selectdata sd = new selectdata();
                DataSet DS = sd.GetData("sp_sub_categories", para);
                DropDownList2.DataSource = DS;
                DropDownList2.DataBind();
                drop2Changed();
                HyperLink1.Visible = false;
                Label2.Text = "";

            }
           

        }

       

       
    }
}
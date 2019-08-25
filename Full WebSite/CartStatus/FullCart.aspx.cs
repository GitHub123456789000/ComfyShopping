using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using FullWebSite.BusinessLayer;

namespace FullWebSite
{
    public partial class ShoopigCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text = Request.QueryString["id"];


            DataTable dt;
            dt = (DataTable)Session["buyitems"];

            if (Session["buyitems"] != null)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                Session["buyitems"] = dt;
                GridView1.FooterRow.Cells[6].Text = "Grand Amount";
                GridView1.FooterRow.Cells[7].Text = grandtotal().ToString();
                Session["F_total"] = GridView1.FooterRow.Cells[7].Text;
                ((Site1)Master).cart_Price.Text = Session["F_total"].ToString();
                ((Site1)Master).cart_Quantity.Text = Session["F_Qua"].ToString();


            }
            else
            {
                Response.Redirect("~/CartStatus/EmptyCart.aspx");


            }
        }



        public int grandtotal()
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            int nrow = dt.Rows.Count;
            int i = 0;
            int gtotal = 0;
            while (i < nrow)
            {
                gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["TotalPrice"].ToString());


                i = i + 1;
            }
            return gtotal;
        }




        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = (DataTable)Session["buyitems"];
            for (int i = 0; i <= dt.Rows.Count - 1; i++)
            {
                int sr;
                int sr1;
                string qdata;
                string dtdata;
                string qd;

                sr = Convert.ToInt32(dt.Rows[i]["sno"].ToString());
                //TableCell cell = GridView1.Rows[e.RowIndex].Cells[0];
                GridViewRow row = GridView1.Rows[e.RowIndex];
                //For Serial # Final
                String Id = row.Cells[0].Text;
                //For  Quantity Final
                qd = row.Cells[4].Text;

                qdata = Id;
                dtdata = sr.ToString();
                sr1 = Convert.ToInt32(qdata);

                if (sr == sr1)
                {
                    dt.Rows[i].Delete();
                    dt.AcceptChanges();
                    int new_value = Convert.ToInt32(qd);
                    int previous_value = Convert.ToInt32(((Site1)Master).cart_Quantity.Text);
                    previous_value -= new_value;
                    ((Site1)Master).cart_Quantity.Text = previous_value.ToString();
                    Session["F_Qua"] = ((Site1)Master).cart_Quantity.Text;
                    Session["F_total"] = ((Site1)Master).cart_Price.Text;
                    break;

                }
            }

            for (int i = 1; i <= dt.Rows.Count; i++)
            {
                dt.Rows[i - 1]["sno"] = i;
                dt.AcceptChanges();
            }

            Session["buyitems"] = dt;
            if (dt.Rows.Count != 0)
            {
                Response.Redirect("~/CartStatus/FullCart.aspx");
            }
            else
            {
                Response.Redirect("~/CartStatus/EmptyCart.aspx");
            }

        }
        protected void Checkout_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.order_price = Convert.ToDecimal(Session["F_total"]);
            o.placed_date = DateTime.Now.ToString();
            if (Session["customer_mail"] != null)
            {
                o.customer_id = Convert.ToInt32(Session["customer_id"]);

                insert i = new insert();
             Session["OrderNumber"]  = i.insert_order(o);
                Response.Redirect("~/Checkout/Order.aspx");
            }
            else
            {
                Response.Redirect("~/CustomerAccount/CLogin.aspx");
            }

        }
    }
}
    


//public int cart_id { get; set; }
//public string cart_name { get; set; }
//public string cart_price { get; set; }
//public string cart_image { get; set; }
//public int cart_subcat { get; set; }


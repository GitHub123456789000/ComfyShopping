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

namespace FullWebSite.Womens
    {
    public partial class WomensJackets : System.Web.UI.Page
        {

        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["F_Qua"] != null && Session["F_total"] != null)
            {
                ((Site1)Master).cart_Quantity.Text = (Session["F_Qua"].ToString());
                ((Site1)Master).cart_Price.Text = (Session["F_total"].ToString());
            }



            //DataSet ds = GetData();
            //Repeater1.DataSource = ds;
            //Repeater1.DataBind();
        }
        //private DataSet GetData()
        //{

        //    string CS = ConfigurationManager.ConnectionStrings["comfy_string"].ConnectionString;
        //    using (SqlConnection con = new SqlConnection(CS))
        //    {
        //        SqlDataAdapter da = new SqlDataAdapter("select * from tbl_product_items where pro_fk_subcat = 5 ", con);
        //        DataSet ds = new DataSet();
        //        da.Fill(ds);

        //        return ds;
        //    }
        //}

        protected void Repeater1_ItemCommand(object source, RepeaterCommandEventArgs e)
        {

            ImageButton btn = (ImageButton)(e.Item.FindControl("ImageButton1"));
            string productId = btn.CommandArgument;
            DropDownList dl = (DropDownList)(e.Item.FindControl("DropDownList1"));
            int Quantity = Convert.ToInt32(dl.SelectedValue);


            //Session["addproduct"] = "true";
            // Response.Redirect("AddtoCart.aspx?id=" + e.CommandArgument.ToString());
            //if (Session["addproduct"].ToString() == "true")
            //{
            //    Session["addproduct"] = "false";
            DataTable dt = new DataTable();
            DataRow dr;

            dt.Columns.Add("sno");
            dt.Columns.Add("pro_id");
            dt.Columns.Add("pro_name");
            dt.Columns.Add("pro_price");
            dt.Columns.Add("Quantity");
            dt.Columns.Add("pro_image");
            dt.Columns.Add("TotalPrice");
            if (productId != null)
            {
                if (Session["Buyitems"] == null)
                {

                    dr = dt.NewRow();
                    String myquery = "select * from tbl_product_items where pro_id=" + productId;
                    selectdata sd = new selectdata();
                    DataSet ds = sd.GetCart(myquery);
                    dr["sno"] = 1;
                    dr["pro_id"] = ds.Tables[0].Rows[0]["pro_id"].ToString();
                    dr["pro_name"] = ds.Tables[0].Rows[0]["pro_name"].ToString();
                    dr["pro_price"] = ds.Tables[0].Rows[0]["pro_price"].ToString();
                    dr["Quantity"] = Quantity;
                    dr["pro_image"] = ds.Tables[0].Rows[0]["pro_image"].ToString();
                    int price = Convert.ToInt32(ds.Tables[0].Rows[0]["pro_price"].ToString());
                    dr["TotalPrice"] = price * Quantity;
                    ((Site1)Master).cart_Quantity.Text = Quantity.ToString();
                    Session["F_Qua"] = ((Site1)Master).cart_Quantity.Text;
                    dt.Rows.Add(dr);
                    Session["buyitems"] = dt;
                    ((Site1)Master).cart_Price.Text = grandtotal().ToString();
                    //ImageButton img = (ImageButton)(e.Item.FindControl("ImageButton1"));
                    //img.ImageUrl = "images/addedtocart.png";
                }
                else
                {

                    dt = (DataTable)Session["buyitems"];
                    int sr;
                    sr = dt.Rows.Count;

                    dr = dt.NewRow();
                    String myquery = "select * from tbl_product_items where pro_id=" + productId;
                    selectdata sd = new selectdata();
                    DataSet ds = sd.GetCart(myquery);
                    dr["sno"] = sr + 1;
                    dr["pro_id"] = ds.Tables[0].Rows[0]["pro_id"].ToString();
                    dr["pro_name"] = ds.Tables[0].Rows[0]["pro_name"].ToString();
                    dr["pro_price"] = ds.Tables[0].Rows[0]["pro_price"].ToString();
                    dr["Quantity"] = Quantity;
                    dr["pro_image"] = ds.Tables[0].Rows[0]["pro_image"].ToString();
                    int price = Convert.ToInt32(ds.Tables[0].Rows[0]["pro_price"].ToString());
                    dr["TotalPrice"] = price * Quantity;
                    int Q = Convert.ToInt32(((Site1)Master).cart_Quantity.Text);
                    Quantity = Quantity + Q;
                    ((Site1)Master).cart_Quantity.Text = Quantity.ToString();
                    Session["F_Qua"] = ((Site1)Master).cart_Quantity.Text;
                    dt.Rows.Add(dr);
                    ((Site1)Master).cart_Price.Text = grandtotal().ToString();
                    Session["F_total"] = ((Site1)Master).cart_Price.Text;
                    Session["buyitems"] = dt;

                    //ImageButton img = (ImageButton)(e.Item.FindControl("ImageButton1"));
                    //img.ImageUrl = "images/addedtocart.png";
                    //Response.Redirect("~/ShoopingCart.aspx?id=" + name);

                }
            }

            else
            {

                dt = (DataTable)Session["buyitems"];

            }
            //  insert i = new insert();

            //  //i.insert_tbl_cart();
            //  shoopingcart cart = new shoopingcart();

            //  selectdata sd = new selectdata();
            //  SqlParameter para = new SqlParameter("pro_id", productId);

            //DataSet cartdata =  sd.Get_product("sp_retrieve_cart", para);
            //  cart.cart_id = Convert.ToInt32(cartdata.Tables[0].Rows[0][0]);
            //  cart.cart_name = cartdata.Tables[0].Rows[0][1].ToString();
            //  cart.cart_price = cartdata.Tables[0].Rows[0][2].ToString();
            //  cart.cart_img = cartdata.Tables[0].Rows[0][3].ToString();
            //  cart.cart_subcat = Convert.ToInt32(cartdata.Tables[0].Rows[0][4]);
            //  i.insert_tblcart(cart);
            //  ((Site1)Master).cart_Quantity.Text = "1";



            //Response.Redirect("~/CartStatus.FullCart.aspx?id=" + name);
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
                gtotal = gtotal + Convert.ToInt32(dt.Rows[i]["totalprice"].ToString());

                i = i + 1;
            }
            return gtotal;
        }




    }
}
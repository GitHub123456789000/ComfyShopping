using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FullWebSite.BusinessLayer
    {
    public class insert
        {
        private string cs = ConfigurationManager.ConnectionStrings["comfy_string"].ConnectionString;
        public string signup_admin(admin a)
            {
            string k;
            SqlConnection con = new SqlConnection(cs);

            try
                {
                SqlCommand cmd = new SqlCommand("spinsert_cust", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@ad_email", SqlDbType.NVarChar, 50).Value = a.email;
                cmd.Parameters.Add("@ad_password", SqlDbType.NVarChar, 50).Value = a.password;
             

                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Int;
                para.Direction = ParameterDirection.Output;
                para.ParameterName = "@id";
                cmd.Parameters.Add(para);

                con.Open();
                cmd.ExecuteNonQuery();
                k = para.Value.ToString();

                }
            catch (Exception)
                {

                k = "-1";
                }
            finally
                {
                con.Close();

                }
            return k;
            }

        public string signup_customer(customer c)
            {
           string k;
            SqlConnection con = new SqlConnection(cs);

            try
                {
                SqlCommand cmd = new SqlCommand("sp_insert_cust", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@cu_email", SqlDbType.NVarChar, 50).Value = c.email;
                cmd.Parameters.Add("@cu_password", SqlDbType.NVarChar, 50).Value = c.password;
                cmd.Parameters.Add("@cu_phone", SqlDbType.NVarChar, 50).Value = c.phone;

                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Int;
                para.Direction = ParameterDirection.Output;
                para.ParameterName = "@cu_id";
                cmd.Parameters.Add(para);

                con.Open();
                cmd.ExecuteNonQuery();
                k = para.Value.ToString();

            }
            //catch (Exception)
            //{

            //    k = "-1";
            //}
            finally
            {
                con.Close();

                }
          
            return k;
            }

       


        public string insert_tblproduct(product p)
        {

            string pp = "1";
            SqlConnection con = new SqlConnection(cs);

            try
            {
                SqlCommand cmd = new SqlCommand("sp_insert_subproduct", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@pro_name", SqlDbType.NVarChar, 50).Value = p.pro_name;
                cmd.Parameters.Add("@pro_posted_date", SqlDbType.Date).Value = p.pro_date;
                cmd.Parameters.Add("@pro_price", SqlDbType.Float).Value = p.pro_price;
                cmd.Parameters.Add("@pro_image", SqlDbType.NVarChar).Value = p.pro_img;
                cmd.Parameters.Add("@pro_fk_ad", SqlDbType.Int).Value = p.pro_adminid_fk;
                cmd.Parameters.Add("@pro_fk_subcat", SqlDbType.Int).Value = p.pro_subcatid_fk;





                con.Open();
                cmd.ExecuteNonQuery();


        }
            //catch (Exception)
            //{

            //    pp = "-1";
            //}
            finally
            {
                con.Close();

            }
            return pp;


        }

        public string insert_order(Order order)
        {
            int o;
            SqlConnection con = new SqlConnection(cs);

            try
            {
                SqlCommand cmd = new SqlCommand("sp_insert_order", con);
                cmd.CommandType = CommandType.StoredProcedure;

               
                cmd.Parameters.Add("@order_price ", SqlDbType.Decimal).Value = order.order_price;
                cmd.Parameters.Add("@placed_date", SqlDbType.DateTime).Value = order.placed_date;
                cmd.Parameters.Add("@customer_id", SqlDbType.Int).Value = order.customer_id;

                SqlParameter para = new SqlParameter();
                para.SqlDbType = SqlDbType.Int;
                para.Direction = ParameterDirection.Output;
                para.ParameterName = "@order_id";
                cmd.Parameters.Add(para);

                con.Open();
                cmd.ExecuteNonQuery();
                o = Convert.ToInt32(para.Value);

            }
            //catch (Exception)
            //{

            //    c = "-1";
            //}
            finally
            {
                con.Close();

            }


            return o.ToString(); ;
        }







        //public string insert_tbl_cart()
        //{

        //    string pp = "1";
        //    SqlConnection con = new SqlConnection(cs);

        //    try
        //    {
        //        SqlCommand cmd = new SqlCommand("sp_insert_cart", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.Add("@pro_name", SqlDbType.NVarChar, 50).Value = p.pro_name;
        //        cmd.Parameters.Add("@pro_posted_date", SqlDbType.Date).Value = p.pro_date;
        //        cmd.Parameters.Add("@pro_price", SqlDbType.Float).Value = p.pro_price;
        //        cmd.Parameters.Add("@pro_image", SqlDbType.NVarChar).Value = p.pro_img;
        //        cmd.Parameters.Add("@pro_fk_ad", SqlDbType.Int).Value = p.pro_adminid_fk;
        //        cmd.Parameters.Add("@pro_fk_subcat", SqlDbType.Int).Value = p.pro_subcatid_fk;





        //        con.Open();
        //        cmd.ExecuteNonQuery();


        //    }
            //catch (Exception)
            //{

            //    pp = "-1";
            ////}
            //finally
            //{
            //    con.Close();

            //}
            //return pp;


        }






    }

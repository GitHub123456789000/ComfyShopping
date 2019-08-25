using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace FullWebSite.BusinessLayer
{
    public class selectdata
    {
        private string cs = ConfigurationManager.ConnectionStrings["comfy_string"].ConnectionString;
        string s;
        //string p;


        //public string returnpassword(string pass)
        //    {
        //    SqlConnection con = new SqlConnection(cs);
        //    SqlCommand cmd = new SqlCommand(pass, con);

        //    con.Open();
        //    try
        //    {

        //        SqlDataReader dr = cmd.ExecuteReader();
        //        while (dr.Read())
        //        {


        //            return  p = dr["password"].ToString();
        //        }

        //    }
        //    catch (Exception)
        //    {

        //        p = "-1";
        //    }

        //    finally
        //    {
        //        con.Close();
        //    }
        //    return p;


        //}

        public string returnscalar(string q)
        {

            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(q, con);
            con.Open();
            try
            {
                s = cmd.ExecuteScalar().ToString();

            }
            catch (Exception)
            {

                s = "-1";
            }
            finally
            {
                con.Close();
            }

            return s;

        }

        public DataSet GetData(string SPname, SqlParameter SPparameter)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter(SPname, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            if (SPparameter != null)
            {
                da.SelectCommand.Parameters.Add(SPparameter);
            }
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public DataSet GetCart(string cFinal)
        {
            SqlConnection con = new SqlConnection(cs);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(cFinal, con);
            da.SelectCommand.CommandType = CommandType.Text;
            DataSet ds = new DataSet();
            da.Fill(ds);
            con.Close();


            return ds;

        }




        public DataSet Get_product(string cartdata, SqlParameter para1)
        {
            SqlConnection con = new SqlConnection(cs);

            SqlDataAdapter da = new SqlDataAdapter(cartdata, con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            da.SelectCommand.Parameters.Add(para1);

            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataSet SearchData(string search)
        {
            
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("sp_searchbox", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                SqlParameter searchpara = new SqlParameter("@search", search );
                da.SelectCommand.Parameters.Add(searchpara);
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }



        }

        public DataSet SortOrder()
        {

            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("sort_order", con);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                con.Open();
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;

            }



        }
        public int cust_id(string q)
        {
            int s;
            SqlConnection con = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand(q, con);
            con.Open();
            try
            {
                s = Convert.ToInt32(cmd.ExecuteScalar());

            }
            //catch (Exception)
            //{

            //    s = -1;
            //}
            finally
            {
                con.Close();
            }

            return s;

        }
    }
}


    
    
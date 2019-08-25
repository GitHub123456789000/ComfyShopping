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

namespace FullWebSite.Search_Page
{
    public partial class Product_Search : System.Web.UI.Page
    {

        //protected void Page_Init(object sender, EventArgs e)
        //{
        //    ((Site1)Master).searchButton.Click += new EventHandler(searchButton_Click);
        //}

        protected void Page_Load(object sender, EventArgs e)
        {
            selectdata sd = new selectdata();
            DataSet ds = sd.SearchData(((Site1)Master).Session["TextSearch"].ToString());
            Repeater1.DataSource = ds;
            Repeater1.DataBind();
        }

       



        



    }
}


        




    

    
    

    

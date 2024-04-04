using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace DBTWOLAYER
{
    public partial class ProfileView : System.Web.UI.Page
    {
        ConClass objcls = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string st = "select Name,Age,Adddress,Photo from TwoLayer where ID=" + Session["uid"] + "";
                SqlDataReader dr = objcls.fn_Datareader(st);
                while (dr.Read())
                {
                    txtNa.Text = dr["Name"].ToString();
                    txtAg.Text = dr["Age"].ToString();
                    txtAd.Text = dr["Adddress"].ToString();
                    Image1.ImageUrl = dr["Photo"].ToString();
                }
            }
        }

        //        DataSet ds = new DataSet(st);
        //        GridView1.DataSource = ds;
        //        GridView1.DataBind();
        //    }
        //}
        
        // protected void Button1_Click(object sender, EventArgs e)
        //{
        //    string su = "update TwoLayer set Age=" + txtAg.Text + ",Adddress='" + txtAd.Text + "' where ID=" + Session["uid"] + "";
        //    int i = objcls.fn_Nonquery(su);
        //    if(i==1)
        //    {
        //        Label1.Text = "updated";
        //    }
            
        //}
    }
}
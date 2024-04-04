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
    public partial class ConLogin : System.Web.UI.Page
    {
        ConClass objcls = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
         string str="select count(ID) from TwoLayer where UserName='"+txtUserName.Text+"' and Password='"+txtPassword.Text+"'";
            string cid = objcls.fn_Scaler(str);
            if(cid=="1")
            {
                string stid = "select ID from TwoLayer where UserName='" + txtUserName.Text + "'and Password='" + txtPassword.Text + "'";
                string strid = objcls.fn_Scaler(stid);
                Session["uid"] = strid;
                Response.Redirect("ProfileView.aspx");
                //int id1 = 0;
                //string strg = "select ID from TwoLayer where UserName='" + txtUserName.Text + "'and Password='" + txtPassword.Text + "'";
                //SqlDataReader dr = objcls.fn_Datareader(strg);
                //while (dr.Read())
                //{
                //    id1 = Convert.ToInt32(dr["ID"].ToString());
                //}
                //Session["uid"] = id1;
                //Response.Redirect("ProfileView.aspx");
            }
            else
            {
                Label3.Text = "Invalid Username or password";
            }
        }
    }
}
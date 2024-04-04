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
    public partial class condrop : System.Web.UI.Page
    {
        ConClass objcls = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string s = "select ID,Name from TwoLayer";
                DataSet ds = objcls.fn_Dataset(s);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "Name";
                DropDownList1.DataValueField = "ID";
                DropDownList1.DataBind();

            }

        }
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Label1.Text = DropDownList1.SelectedItem.Text;
            Label2.Text = DropDownList1.SelectedItem.Value;

            string s = "select * from TwoLayer where ID=" + DropDownList1.SelectedItem.Value + "";
            DataSet ds = objcls.fn_Dataset(s);
            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}


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
    public partial class DataList : System.Web.UI.Page
    {
        ConClass objcls = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = "select *from TwoLayer";
            DataSet ds = objcls.fn_Dataset(s);
            DataList1.DataSource = ds;
            DataList1.DataBind();

        }
    }
}
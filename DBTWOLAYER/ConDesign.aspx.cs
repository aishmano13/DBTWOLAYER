using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DBTWOLAYER
{
    public partial class ConDesign : System.Web.UI.Page
    {
        ConClass objcls = new ConClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string p = "~/Photo/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(p));
            
            string st = "insert into TwoLayer values('" + txtName.Text + "'," + txtAge.Text + ",'" + txtAddress.Text + "','" + p + "','" + txtUser.Text + "','" + txtPass.Text + "')";
            int i = objcls.fn_Nonquery(st);
            if (i == 1)
            {
                Label1.Text = "Inserted";
            }

        }
    }
}
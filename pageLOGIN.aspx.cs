using QUANLYBANHANG02.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG02
{
    public partial class pageLOGIN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlParameter[] pr = new SqlParameter[2];
            XULYDULIEU xuly = new XULYDULIEU();
            if (txtUserName.Text != null && txtUserName.Text.Length!=0)
            {
                pr[0] = new SqlParameter("@USERNAME", txtUserName.Text);
                pr[1] = new SqlParameter("@PASSWORD", txtPassWord.Text);
                DataTable tbLOGIN = xuly.getTable("psGetTableLOGIN", pr);
                {
                    Session.Timeout = 2;
                    Session["LOGIN"] = tbLOGIN;
                    Response.Redirect("giohang.aspx");
                }
            }
        }
    }
}
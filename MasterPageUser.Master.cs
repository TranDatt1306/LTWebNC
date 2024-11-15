using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG02
{
    public partial class MasterPageUser : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            App_Code.XULYDULIEU xuly = new App_Code.XULYDULIEU();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MADANHMUC", DBNull.Value);
            this.Repeater2.DataSource = xuly.getTable("psGetTableDANHMUC", sqlParameters);
            this.Repeater2.DataBind();
        }
    }
}
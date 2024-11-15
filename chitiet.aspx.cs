using QUANLYBANHANG02.App_Code;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG02
{
    public partial class chitiet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            XULYDULIEU xuly = new XULYDULIEU();
            String maSanPham = Request.QueryString.Get("MASANPHAM");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MASANPHAM", maSanPham);
            this.Repeater1.DataSource = xuly.getTable("psGetTableSanPham", sqlParameters);
            this.Repeater1.DataBind();
        }
    }
}
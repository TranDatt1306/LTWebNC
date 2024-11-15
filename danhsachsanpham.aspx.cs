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
    public partial class danhsachsanpham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            App_Code.XULYDULIEU xuLy = new XULYDULIEU();
            String maDanhMuc = null;
            try
            {
                maDanhMuc = Request.QueryString.Get("MADANHMUC");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            if (maDanhMuc != null)
            {
                String sql = "select * from tbSANPHAM WHERE MADANHMUC=" + maDanhMuc;
                this.DataList1.DataSource = xuLy.getTable(sql);
            }
            else
            {
                SqlParameter[] pr = new SqlParameter[1];
                pr[0] = new SqlParameter("@MASANPHAM", DBNull.Value);
                this.DataList1.DataSource = xuLy.getTable("psGetTableSanPham", pr);
            }
            this.DataList1.RepeatColumns = 3;

            this.DataList1.DataBind();

        }

       


    }
}
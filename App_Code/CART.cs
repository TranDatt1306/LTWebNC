using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QUANLYBANHANG02.App_Code
{
    public class CART
    {
        Dictionary<string, ITEM> listcarts;
        public Dictionary<string, ITEM> LISTCARTS
        {
            get { return this.listcarts; }
        }
        public CART()
        {
            listcarts = new Dictionary<string, ITEM>();
        }
        public void AddCart(String masanpham)
        {
            XULYDULIEU xuly = new XULYDULIEU();
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@MASANPHAM", masanpham);
            DataTable table = xuly.getTable("psGetTableSanPham", sqlParameters);

            if (table.Rows.Count > 0)
            {
                // Retrieve necessary information from the DataTable
                string hinhanh = table.Rows[0]["HINHANH"].ToString();
                int soluong = Convert.ToInt32(table.Rows[0]["SOLUONG"]);
                double dongia = Convert.ToDouble(table.Rows[0]["DONGIA"]);
                String tenSanPham = table.Rows[0]["TENSANPHAM"].ToString();

                // Create an ITEM object
                ITEM item = new ITEM(masanpham, tenSanPham, hinhanh,1, dongia);

                if (listcarts.ContainsKey(item.MASANPHAM))
                {
                    listcarts[item.MASANPHAM].SOLUONG += item.SOLUONG;
                }
                else
                {
                    listcarts.Add(item.MASANPHAM, item);
                }
            }
        }
        public void RemoveCart(String masanpham)
        {
            listcarts.Remove(masanpham);
        }
        public double TotalBill()
        {
            double total = 0;
            foreach (ITEM item in listcarts.Values)
                total += item.THANHTIEN;
            return total;
        }
    }
}
using QUANLYBANHANG02.App_Code;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QUANLYBANHANG02
{
    public partial class giohang : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String maSanPham = Request.QueryString.Get("MASANPHAM");
            DataTable tbLOGIN = (DataTable) Session["LOGIN"];
            if (tbLOGIN != null)
            {
                if (maSanPham != null)
                    cart(maSanPham);
                if (!IsPostBack)
                    LoadCart();
            }
            else Response.Redirect("danhsachsanpham.aspx");
        }

        private void LoadCart()
        {
            App_Code.CART cart = Session["CART"] as App_Code.CART;

            if (cart != null)
            {
                this.grvCART.DataSource = cart.LISTCARTS.Values.ToList();
                this.grvCART.DataBind();
                this.grvCART.FooterRow.Cells[0].Text = "Tong tien";
                this.grvCART.FooterRow.Cells[4].Text = cart.TotalBill().ToString();
                this.total.Text = cart.TotalBill().ToString();
            }
            else
            {
                cart = new App_Code.CART();

                Session["CART"] = cart;

            }

        }
        public void cart(String productID)
        {
           

            // Add the product to the cart
            App_Code.CART cart = Session["CART"] as App_Code.CART;
            XULYDULIEU xuly = new XULYDULIEU();

            if (cart != null)
            {

                // Assuming you have a method to add products to the cart in your CART class
                cart.AddCart(productID);
                //String masanpham, string tensanpham, string hinhanh, int soluong, double dongia

                // Save the updated cart back to the session
                Session["CART"] = cart;

                // Optionally, you can redirect the user to a cart page
                Response.Redirect("giohang.aspx");
            }
            else
            {
                cart = new App_Code.CART();

                // Add the product to the new cart
                cart.AddCart(productID);

                // Save the new cart to the session
                Session["CART"] = cart;

                // Optionally, redirect the user to a cart page
                Response.Redirect("giohang.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (Session["CART"] != null)
            {
                CART cart = (CART)Session["CART"];

                // Iterate over the rows in the GridView control.
                foreach (GridViewRow row in grvCART.Rows)
                {
                    // Get the checkbox in the first column.
                    CheckBox ckb = (CheckBox)row.FindControl("cbxREMOVEITEM");

                    // If the checkbox is checked, remove the product from the shopping cart.
                    if (ckb.Checked)
                    {
                        string masanpham = row.Cells[0].Text;
                        cart.RemoveCart(masanpham);
                    }

                    // Save the shopping cart back to the Session object.
                    Session["CART"] = cart;
                }
            }
            LoadCart();
        }
    }
}
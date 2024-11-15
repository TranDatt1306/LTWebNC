<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUser.Master" AutoEventWireup="true" CodeBehind="danhsachsanpham.aspx.cs" Inherits="QUANLYBANHANG02.danhsachsanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <form id="form1" runat="server">
        <asp:DataList ID="DataList1" runat="server">
            <ItemTemplate>
                <div class="prod_box">
                    <div class="top_prod_box"></div>
                    <div class="center_prod_box">
                        <div class="product_title"><a href=""><%# Eval("TENSANPHAM") %></a></div>
                        <div class="product_img">
                            <a href="">
                                <img src="images/<%# Eval("HINHANH") %>" alt="" border="0"
                                    width="100px" height="100px" /></a>
                        </div>
                        <div class="prod_price">
                            <span class="reduce"><%# Eval("DONGIA") %></span> <span
                                class="price">270$</span>
                        </div>
                    </div>
                    <div class="bottom_prod_box"></div>
                    <div class="prod_details_tab">
                        <a href='<%# "giohang.aspx?MASANPHAM=" + Eval("MASANPHAM") %>' title="header=[Add to cart] body=[&nbsp;]
 fade=[on]">
                            <img src="images/cart.gif" alt="" border="0" class="left_bt" />
                        </a>
                        <a href="#" title="header=[Specials] body=[&nbsp;] fade=[on]">
                            <img src="images/favs.gif" alt="" border="0" class="left_bt" /></a> <a href="#"
                                title="header=[Gifts] body=[&nbsp;] fade=[on]">
                                <img src="images/favorites.gif" alt="" border="0"
                                    class="left_bt" /></a> 

                        <a href='<%# "chitiet.aspx?MASANPHAM=" + Eval("MASANPHAM") %>' class="prod_details">Details</a>
                    </div>
                </div>
            </ItemTemplate>
        </asp:DataList>
    </form>

</asp:Content>

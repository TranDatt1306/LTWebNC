<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUser.Master" AutoEventWireup="true" CodeBehind="giohang.aspx.cs" Inherits="QUANLYBANHANG02.giohang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
       
        #grvCART {
            width: 582px; /* Set the desired width */
            border: 1px solid #ccc; /* Add a border */
            border-collapse: collapse; /* Collapse the border spacing */
        }

        /* Style for the header row of the GridView */
        #grvCART th {
            background-color: #333; /* Set the background color for header cells */
            color: #fff; /* Set the text color for header cells */
        }

        /* Style for the even rows in the GridView (alternating row color) */
        #grvCART tr:nth-child(even) {
            background-color: #f2f2f2; /* Set the background color for even rows */
        }

        /* Style for the odd rows in the GridView (alternating row color) */
        #grvCART tr:nth-child(odd) {
            background-color: #fff; /* Set the background color for odd rows */
        }

        /* Style for the Button */
        #Button1 {
            background-color: #007bff; /* Set the background color for the button */
            color: #fff; /* Set the text color for the button */
            width: 109px; /* Set the desired width */
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Total : "></asp:Label>
        <asp:Label ID="total" runat="server" Text="0"></asp:Label>
        <asp:GridView ID="grvCART" runat="server" AutoGenerateColumns="False" Height="258px" Width="582px">
            <Columns>
                <asp:BoundField DataField="MASANPHAM" HeaderText="Ma San Pham" />
                <asp:BoundField DataField="TENSANPHAM" HeaderText="Ten San Pham" />
                <asp:BoundField DataField="SOLUONG" HeaderText="So Luong" />
                <asp:BoundField DataField="DONGIA" HeaderText="Don Gia" />
                <asp:BoundField DataField="THANHTIEN" HeaderText="Thanh Tien" />
                <asp:ImageField DataAlternateTextField="HINHANH" DataImageUrlField="HINHANH" DataImageUrlFormatString="IMAGES/{0}" HeaderText="Anh">
                    <ItemStyle CssClass="image-field" />
                </asp:ImageField>
                <asp:TemplateField HeaderText="Tra Hang">
                    <ItemTemplate>
                        <asp:CheckBox ID="cbxREMOVEITEM" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Tra hang" Width="109px" />
    </form>
</asp:Content>

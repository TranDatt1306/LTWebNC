<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPageUser.Master" AutoEventWireup="true" CodeBehind="pageLOGIN.aspx.cs" Inherits="QUANLYBANHANG02.pageLOGIN" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .center_content {
            text-align: center; /* Center align the content within the div */
            margin: 0 auto; /* Horizontally center the div itself */
            /* Style for the center_title_bar within the center_content */
            .center_title_bar

        {
            font-size: 24px; /* Example font size */
            font-weight: bold; /* Example font weight */
            color: #333; /* Example text color */
            margin-bottom: 20px; /* Example margin */
        }

        /* Style for the table within the center_content */
        table {
            width: 100%; /* Make the table width 100% of its container */
            border-collapse: collapse; /* Remove space between table cells */
        }

        /* Style for the table cells with class auto-style1 */
        .auto-style1 {
            font-weight: bold; /* Example font weight */
        }

        /* Style for the table cells with class auto-style2 */
        .auto-style2 {
            font-weight: normal; /* Example font weight */
        }

        /* Style for the text boxes within the table */
        input[type="text"],
        input[type="password"] {
            width: 100%; /* Make the text boxes fill the table cell */
            padding: 5px; /* Example padding */
            border: 1px solid #ccc; /* Example border */
            border-radius: 5px; /* Example border radius */
        }

        /* Style for the button within the table cell with colspan */
        .auto-style1 input[type="button"] {
            background-color: #007bff; /* Example background color */
            color: #fff; /* Example text color */
            padding: 10px 20px; /* Example padding */
            border: none; /* Remove the button border */
            cursor: pointer;
        }

        }
        .auto-style1 {
            height: 29px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1" colspan="2">&#272;&#258;NG NH&#7852;P&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style1">Tên ng&#432;&#7901;i dùng</td>
                <td class="auto-style1">
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">M&#7853;t kh&#7849;u</td>
                <td>
                    <asp:TextBox ID="txtPassWord" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1" colspan="2">
                    <asp:Button ID="Button1" runat="server" Text="Dang nhap" OnClick="Button1_Click" />
                </td>
            </tr>
        </table>

    </form>

</asp:Content>

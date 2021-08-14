<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SE1421_Validation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                        <asp:ValidationSummary ID="ValidationSummary1" ShowSummary="false" ShowMessageBox="true" runat="server" />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td>
            <asp:Label ID="Label1" runat="server" Text="Nhap 1-100"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="txtBox1" runat="server"></asp:TextBox>
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtBox1" ErrorMessage="Phai nhap tu 1 den 100" MaximumValue="100" MinimumValue="0" Type="Integer"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="Label2" runat="server" Text="Enter email"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="txtBox2" runat="server"></asp:TextBox>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email wrong format" ControlToValidate="txtBox2" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator> 
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="Label3" runat="server" Text="Enter Name"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="txtBox3" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtBox3" ErrorMessage="Name is empty" runat="server"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label4" runat="server" Text="Enter Phone"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtBox4" runat="server"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" ControlToValidate="txtBox4" runat="server" ErrorMessage="Phone number must 10 number" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style2"></td>
                </tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
    </form>
</body>
</html>

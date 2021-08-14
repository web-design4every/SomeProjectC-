<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SE1421_Department.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Department: "></asp:Label>
            <asp:DropDownList ID="cbxDepartment" AutoPostBack="true" OnSelectedIndexChanged="cbxDepartment_SelectedIndexChanged" runat="server"></asp:DropDownList>
            <asp:GridView ID="gridView" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWebApp.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính Định Thức Ma Trận</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Tính định thức ma trận</h2>
            Nhập kích thước n:
            <asp:TextBox ID="txtSize" runat="server"></asp:TextBox>
            <br /><br />
            Nhập ma trận (cách nhau bằng dấu cách, xuống dòng để sang hàng mới):<br />
            <asp:TextBox ID="txtMatrix" runat="server" TextMode="MultiLine" Rows="5" Columns="40"></asp:TextBox>
            <br /><br />
            <asp:Button ID="btnCalc" runat="server" Text="Tính định thức" OnClick="btnCalc_Click" />
            <br /><br />
            Kết quả:
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>

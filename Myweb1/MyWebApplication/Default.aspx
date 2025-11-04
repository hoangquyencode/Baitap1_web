<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MyWebAppllication.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tính định thức ma trận</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Chương trình tính định thức ma trận</h2>

            <asp:Label ID="Label1" runat="server" Text="Nhập kích thước n: "></asp:Label>
            <asp:TextBox ID="txtSize" runat="server"></asp:TextBox>
            <br /><br />

            <asp:Label ID="Label2" runat="server" Text="Nhập ma trận (các phần tử cách nhau bằng khoảng trắng, mỗi dòng là 1 hàng):"></asp:Label>
            <br />
            <asp:TextBox ID="txtMatrix" runat="server" TextMode="MultiLine" Rows="6" Columns="50"></asp:TextBox>
            <br /><br />

            <asp:Button ID="btnCalc" runat="server" Text="Tính định thức" OnClick="btnCalc_Click" />
            <br /><br />

            <asp:Label ID="lblResult" runat="server" Text="Kết quả sẽ hiển thị ở đây."></asp:Label>
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PlayerDetail.aspx.cs" Inherits="WebControlAssign.PlayerDetail" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select your Favorite Game<br />
            <br />
        </div>
        <asp:RadioButton ID="RadioButton1" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton1_CheckedChanged" Text="Cricket Player" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:RadioButton ID="RadioButton2" runat="server" AutoPostBack="True" GroupName="a" OnCheckedChanged="RadioButton2_CheckedChanged" Text="Tennis Player" />
        <br />
        <br />
        <asp:Panel ID="Panel1" runat="server" Height="140px" Width="262px">
            <asp:HyperLink ID="HpSachin" runat="server" NavigateUrl="~/Sachin.html">Sachin Tendulkar</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HpVirat" runat="server" NavigateUrl="~/ViratDetails.html">Virat Kohli</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HpDhoni" runat="server" NavigateUrl="~/DhoniDetails.html">M S Dhoni</asp:HyperLink>
            <br />
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel2" runat="server" Height="202px" Width="251px">
            <asp:HyperLink ID="HpRoger" runat="server" NavigateUrl="~/FedererDetails.html">Roger Federer</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HpNadal" runat="server" NavigateUrl="~/NadalDetails.html">Nadal</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HpSerena" runat="server" NavigateUrl="~/WilliamDetails.html">Serena Williams</asp:HyperLink>
        </asp:Panel>
        <br />
    </form>
</body>
</html>

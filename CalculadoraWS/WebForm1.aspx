<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculadoraWS.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        #form1 {
            height: 371px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" enableviewstate="True" visible="False">
        <div>
            Calculadora</div>
        Sumar&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Start" />
        <br />
        Restar&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:Button ID="Button2" runat="server" Text="Start" />
        <br />
        Dividir&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox5_TextChanged"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:Button ID="Button3" runat="server" Text="Start" />
        <br />
        Multiplica&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
        <asp:Button ID="Button4" runat="server" Text="Start" />
        <br />
        AreaCirculo&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
        <asp:Button ID="Button5" runat="server" Text="Start" />
        <br />
        AreaTriangulo
        <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>
        <asp:Button ID="Button6" runat="server" Text="Start" />
        <br />
        AreaCuadrado<asp:TextBox ID="TextBox13" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox14" runat="server"></asp:TextBox>
        <asp:Button ID="Button7" runat="server" Text="Start" />
        <br />
        El Resultado es&nbsp; &gt;<asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>

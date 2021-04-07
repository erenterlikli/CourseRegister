<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Dersler.aspx.cs" Inherits="WebApplication1.Dersler" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form runat="server">
        <div>  
            <div style="text-align:center">
            <asp:Label  runat="server" Text="Ders Kayıt Talebi" Font-Bold="True" Font-Size="18pt" Font-Italic="False" ></asp:Label>
                </div>
            <br />
            <strong>
            <asp:Label ID="Label1" runat="server" Text="Ders Seçin" style="font-size: medium"></asp:Label>
            </strong><asp:DropDownList ID="DropDownList1" runat="server" CssClass="form-control"></asp:DropDownList>
        </div>
        <br />

        <div>
            <strong>
            <asp:Label ID="Label2" runat="server" Text="Öğrenci ID" style="font-size: medium"></asp:Label>
            :</strong><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Onayla" CssClass="btn btn-success" OnClick="Button1_Click"/>

    </form>





















</asp:Content>

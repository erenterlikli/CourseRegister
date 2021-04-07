<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="WebApplication1.OgrenciGuncelle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">



 <form id="Form1" runat="server">

        <div class="form-group">

            <div style="text-align:center">
            <asp:Label  runat="server" Text="Öğrenci Güncelleme" Font-Bold="True" Font-Size="18pt" Font-Italic="False" ></asp:Label>
                </div>

            <div>
                <br />
                <asp:Label for="TxtId" runat="server" Text="Öğrenci Id:" Font-Bold="True" Font-Size="12pt" ></asp:Label>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            

            <div>
                <br />
                <asp:Label for="TxtOgrNo" runat="server" Text="Öğrenci Numarası:" Font-Bold="True" Font-Size="12pt" ></asp:Label>
                <asp:TextBox ID="TxtOgrNo" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

             <div>
                <asp:Label for="TxtOgrAd" runat="server" Text="Öğrenci Adı:" Font-Bold="True" Font-Size="12pt" ></asp:Label>
                <asp:TextBox ID="TxtOgrAd" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

             <div>
                <asp:Label for="TxtOgrSoyad" runat="server" Text="Öğrenci Soyadı:" Font-Bold="True" Font-Size="12pt" ></asp:Label>
                <asp:TextBox ID="TxtOgrSoyad" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

            
             <div>
                <asp:Label for="TxtOgrMail" runat="server" Text="Öğrenci Maili:" Font-Bold="True" Font-Size="12pt" ></asp:Label>
                <asp:TextBox ID="TxtOgrMail" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

             <div>
                <asp:Label for="TxtSifre" runat="server" Text="Şifre:" Font-Bold="True" Font-Size="12pt" ></asp:Label>
                <asp:TextBox ID="TxtSifre" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />

        </div>

        <asp:Button ID="Button1" runat="server" Text="Güncelle"  CssClass="btn btn-success" Height="40px" Width="150px" OnClick="Button1_Click1" />
    </form>
</asp:Content>

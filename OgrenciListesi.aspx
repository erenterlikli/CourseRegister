<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="OgrenciListesi.aspx.cs" Inherits="WebApplication1.OgrenciListesi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <br />
    <table class="table table-bordered table-hover">
        <tr>
            <th>Öğrenci Id</th>
            <th>Öğrenci No</th>
            <th>Öğrenci Adı</th>
            <th>Öğrenci Soyadı</th>
            <th>Öğrenci Mail</th>
            <th>Şifre</th>
            <th>Bakiye</th>
            <th>Silme</th>
            <th>Güncelleme</th>
        </tr>

        <tbody>
            <asp:Repeater ID="Repeater1" runat="server"> 
                <ItemTemplate>

            <tr>
                <td><%#Eval("OgrId1") %></td>
                <td><%#Eval("OgrNo1") %></td>
                <td><%#Eval("OgrAd1") %></td>
                <td><%#Eval("OgrSoyad1") %></td>
                <td><%#Eval("OgrMail1") %></td>
                <td><%#Eval("OgrSifre1") %></td>
                <td><%#Eval("OgrBakiye1") %></td>
                <td>
                    <asp:HyperLink ID="HyperLink1"  NavigateUrl= '<%# "~/OgrenciSil.aspx?OgrId1="+Eval("OgrId1") %>'  CssClass="btn btn-danger" runat="server">Sil</asp:HyperLink>

                </td>

                <td>
                    <asp:HyperLink ID="HyperLink2"   NavigateUrl='<%# "~/OgrenciGuncelle.aspx?OgrId1="+Eval("OgrId1") %>'  CssClass="btn btn-warning" runat="server">Güncelle</asp:HyperLink>

                </td>
            </tr>

                    </ItemTemplate>
            </asp:Repeater>
        </tbody>


    </table>
</asp:Content>

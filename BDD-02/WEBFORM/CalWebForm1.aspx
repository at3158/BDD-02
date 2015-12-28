<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CalWebForm1.aspx.cs" Inherits="BDD_02.WEBFORM.CalWebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Text="ADD"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    &nbsp;+
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    &nbsp; = 
    <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="addButton1" runat="server" Text="add" OnClick="addButton1_Click" />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="MIN"></asp:Label>
    <br />
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    &nbsp;+
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    &nbsp; = 
    <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
    <br />
    <asp:Button ID="minButton1" runat="server" Text="min" OnClick="minButton1_Click" />
    <br />
</asp:Content>

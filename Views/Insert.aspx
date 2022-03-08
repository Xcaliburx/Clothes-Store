<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="_2301854403_Benny_Kharisma.Views.Insert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />

    <div>
        <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
        <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="Label2" runat="server" Text="Type: "></asp:Label>
        <asp:TextBox ID="TxtType" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="Label4" runat="server" Text="Description: "></asp:Label>
        <asp:TextBox ID="TxtDesc" runat="server"></asp:TextBox>
    </div>

    <div>
        <asp:Label ID="Label6" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="TxtPrice" TextMode="Number" runat="server"></asp:TextBox>
    </div>

    <asp:Label ID="Lblmsg" runat="server" Text=""></asp:Label>
    <asp:Button ID="BtnSubmit" OnClick="BtnSubmit_Click" runat="server" Text="Submit" />

    <br />
    <br />

    </asp:Content>

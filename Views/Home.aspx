<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Master.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="_2301854403_Benny_Kharisma.Views.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Repeater ID="Repeater" runat="server">

        <ItemTemplate>

            <br />

            <div>
                <asp:Label ID="Label1" runat="server" Text="Name: "></asp:Label>
                <asp:Label ID="LblName" runat="server" Text='<%# Eval("Name") %>'></asp:Label>
            </div>

            <div>
                <asp:Label ID="Label2" runat="server" Text="Type: "></asp:Label>
                <asp:Label ID="LblType" runat="server" Text='<%# Eval("Type") %>'></asp:Label>
            </div>

            <div>
                <asp:Label ID="Label4" runat="server" Text="Description: "></asp:Label>
                <asp:Label ID="LblDesc" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
            </div>

            <div>
                <asp:Label ID="Label6" runat="server" Text="Price: "></asp:Label>
                <asp:Label ID="LblPrice" runat="server" Text='<%# Eval("Price") %>'></asp:Label>
            </div>

            <div>
                <asp:Button ID="BtnUpdate" UseSubmitBehavior="false" CommandArgument='<%# Eval("ClothId") %>' OnClick="BtnUpdate_Click" runat="server" Text="Update" />
                <asp:Button ID="BtnDelete" UseSubmitBehavior="false" CommandArgument='<%# Eval("ClothId") %>' OnClick="BtnDelete_Click" runat="server" Text="Delete" />
            </div>

            <br />

        </ItemTemplate>

    </asp:Repeater>

</asp:Content>

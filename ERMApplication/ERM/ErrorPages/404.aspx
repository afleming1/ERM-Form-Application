<%@ Page Title="" Language="C#" MasterPageFile="~/ERM/Site.Master" AutoEventWireup="true" CodeBehind="404.aspx.cs" Inherits="ERMApplication.ERM.ErrorPages._404" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h2>404 Error</h2>

    <p>The requested page cannot be found</p>

    <asp:Button ID="buttonReturn" runat="server" CssClass="btn btn-primary" Text="Go Back" OnClick="buttonReturn_Click" />
</asp:Content>

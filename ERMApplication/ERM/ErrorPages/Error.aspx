﻿<%@ Page Title="" Language="C#" MasterPageFile="~/ERM/Site.Master" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="ERMApplication.ERM.ErrorPages.Error" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h2>Error</h2>

    <p>Something bad happened. We are attempting to fix it...</p>

    <asp:Button ID="buttonReturn" runat="server" CssClass="btn btn-primary" Text="Go Back" OnClick="buttonReturn_Click" />
</asp:Content>

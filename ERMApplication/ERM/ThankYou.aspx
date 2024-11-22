<%@ Page Title="" Language="C#" MasterPageFile="~/ERM/Site.Master" AutoEventWireup="true" CodeBehind="ThankYou.aspx.cs" Inherits="ERMApplication.ERM.ThankYou" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h2>Thank You</h2>

    <p>Thank you for placing your online registration to the ERM Symposium.</p>

    <br />

    <p align="center">
        <asp:Button ID="buttonDashboard" CssClass="btn btn-primary" runat="server" text="Go to Dashboard" OnClick="buttonDashboard_Click" />
    </p>
</asp:Content>
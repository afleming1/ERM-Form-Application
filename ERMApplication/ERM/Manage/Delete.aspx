<%@ Page Title="" Language="C#" MasterPageFile="~/ERM/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="ERMApplication.ERM.Manage.Delete" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:Panel ID="ErrorPanel" Visible="false" runat="server">
        <div class="alert alert-danger" role="alert">
            <b>Error: <asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label></b>
        </div>
    </asp:Panel>

    <h2>DeleteSymposium Registration</h2>
    <br />

    <!-- Delete Message -->

    <div class="container">
        <div class="row">
            <div class="col">
                <table width="100%">
                    <tr>
                        <td>Are you <b>sure</b> you want to <b>delete</b> this registration from the database?</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="checkConfirm" Text="&nbsp;Yes, I am sure I want to remove this registration" runat="server" />
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <br />

    <p>
        <asp:Button ID="buttonDelete" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="buttonDelete_Click" />
        <asp:Button ID="buttonCancel" CssClass="btn btn-secondary" runat="server" Text="Cancel" OnClick="buttonCancel_Click" />
    </p>
</asp:Content>

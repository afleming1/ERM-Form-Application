<%@ Page Title="" Language="C#" MasterPageFile="~/ERM/Site.Master" AutoEventWireup="true" CodeBehind="View.aspx.cs" Inherits="ERMApplication.ERM.Manage.View" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h2>Symposium Registration</h2>
    <br />

    <!-- Name -->

    <div class="container">
        <div class="row">
            <div class="col-6">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelFirstName" runat="server"></asp:Label> <asp:Label ID="labelLastName" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-6">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelEmail" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <br />

    <!-- Address -->

    <div class="container">
        <div class="row">
            <div class="col-3">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="lblAddress" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col">&nbsp;</div>
            <div class="col-3">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelCity" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col">&nbsp;</div>
            <div class="col-3">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelState" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <br />

    <!-- Rates -->

    <h2>Symposium Rates</h2>
    <br />

    <div class="container">
        <div class="row">
            <div class="col">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelRates" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <br />

    <!-- Lunch Options -->

    <h2>Lunch Options</h2>
    <br />

    <div class="container">
        <div class="row">
            <div class="col">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelLunch" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <br />

    <!-- Accessibility Options -->

    <h2>Accessibility Options</h2>
    <br />

    <div class="container">
        <div class="row">
            <div class="col">
                <table>
                    <tr>
                        <td>
                            <p>
                                <asp:Label ID="labelAudio" runat="server"></asp:Label>
                                <asp:Label ID="labelVisual" runat="server"></asp:Label>
                                <asp:Label ID="labelMobile" runat="server"></asp:Label>
                            </p>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <br />

    <p>
        <asp:Button ID="buttonEdit" CssClass="btn btn-primary" runat="server" Text="Edit" OnClick="buttonEdit_Click" />
        <asp:Button ID="buttonDelete" CssClass="btn btn-danger" runat="server" Text="Delete" OnClick="buttonDelete_Click" />
        <asp:Button ID="buttonCancel" CssClass="btn btn-secondary" runat="server" Text="Cancel" OnClick="buttonCancel_Click" />
    </p>
</asp:Content>

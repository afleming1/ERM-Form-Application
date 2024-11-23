<%@ Page Title="" Language="C#" MasterPageFile="~/ERM/Site.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="ERMApplication.ERM.Registration" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <asp:Panel ID="ErrorPanel" Visible="false" runat="server">
        <div class="alert alert-danger" role="alert">
            <b>Error: <asp:Label ID="ErrorMessage" runat="server" Text=""></asp:Label></b>
        </div>
    </asp:Panel>
    
    <h2>Symposium Registration</h2>
    <br />

    <!-- Name -->

    <div class="container">
        <div class="row">
            <div class="col-6">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelFirstName" CssClass="field-label" runat="server" Text="First Name"></asp:Label> <span class="red">*</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="textFirstName" Width="425px" MaxLength="50" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-6">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelLastName" CssClass="field-label" runat="server" Text="Last Name"></asp:Label> <span class="red">*</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="textLastName" Width="425px" MaxLength="50" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <br />

    <!-- Email -->

    <div class="container">
        <div class="row">
            <div class="col-6">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelEmail" CssClass="field-label" runat="server" Text="Email Address"></asp:Label> <span class="red">*</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="textEmail" Width="425px" MaxLength="100" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-6">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelConfirmEmail" CssClass="field-label" runat="server" Text="Confirm Email"></asp:Label> <span class="red">*</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="textConfirmEmail" Width="425px" MaxLength="100" runat="server"></asp:TextBox>
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
                            <asp:Label ID="lblAddress" CssClass="field-label" runat="server" Text="Address"></asp:Label> <span class="red">*</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="textAddress" Width="350px" MaxLength="100" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col">&nbsp;</div>
            <div class="col-3">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelCity" CssClass="field-label" runat="server" Text="City"></asp:Label> <span class="red">*</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="textCity" Width="350px" MaxLength="100" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col">&nbsp;</div>
            <div class="col-3">
                <table>
                    <tr>
                        <td>
                            <asp:Label ID="labelState" CssClass="field-label" runat="server" Text="State"></asp:Label> <span class="red">*</span>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:TextBox ID="textState" Width="150px" MaxLength="2" runat="server"></asp:TextBox>
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
                        <td>Please select your symposium rate:</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:DropDownList ID="listRates" Width="425px" runat="server">
                                <asp:ListItem Text="[Select a Rate]" Value="NULL" Selected="True"></asp:ListItem>
                                <asp:ListItem Text="CAS, CIA, SOA Member" Value="Member"></asp:ListItem>
                                <asp:ListItem Text="Non-Member" Value="Non-Member"></asp:ListItem>
                                <asp:ListItem Text="Dues Waiver" Value="Waiver"></asp:ListItem>
                            </asp:DropDownList>
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
                        <td>I request the following lunch option:</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:RadioButtonList ID="optionLunches" RepeatDirection="Horizontal" runat="server">
                                <asp:ListItem Text="&nbsp;Regular&nbsp;&nbsp;" Value="Regular"></asp:ListItem>
                                <asp:ListItem Text="&nbsp;Kosher&nbsp;&nbsp;" Value="Kosher"></asp:ListItem>
                                <asp:ListItem Text="&nbsp;Vegetarian&nbsp;&nbsp;" Value="Vegetarian"></asp:ListItem>
                                <asp:ListItem Text="&nbsp;Vegan&nbsp;&nbsp;" Value="Vegan"></asp:ListItem>
                                <asp:ListItem Text="&nbsp;Fruit Plate&nbsp;&nbsp;" Value="Fruit"></asp:ListItem>
                                <asp:ListItem Text="&nbsp;Gluten Free&nbsp;&nbsp;" Value="Gluten"></asp:ListItem>
                                <asp:ListItem Text="&nbsp;Lactose Free&nbsp;&nbsp;" Value="Lactose"></asp:ListItem>
                            </asp:RadioButtonList>
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
                        <td>I require the following services:</td>
                    </tr>
                    <tr>
                        <td>
                            <asp:CheckBox ID="checkAudio" Text="&nbsp;Audio Assistance" runat="server" />&nbsp;&nbsp;
                            <asp:CheckBox ID="checkVisual" Text="&nbsp;Visual Assistance" runat="server" />&nbsp;&nbsp;
                            <asp:CheckBox ID="checkMobile" Text="&nbsp;Mobile Assistance" runat="server" />&nbsp;&nbsp;
                        </td>
                    </tr>
                </table>
            </div>
        </div>
    </div>

    <br />

    <p>
        <asp:Button ID="buttonSubmit" CssClass="btn btn-primary" runat="server" Text="Submit" OnClick="buttonSubmit_Click" />
        <asp:Button ID="buttonCancel" CssClass="btn btn-secondary" runat="server" Text="Cancel" OnClick="buttonCancel_Click" />
    </p>    
</asp:Content>

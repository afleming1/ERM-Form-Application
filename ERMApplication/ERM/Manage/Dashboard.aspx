<%@ Page Title="" Language="C#" MasterPageFile="~/ERM/Site.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="ERMApplication.ERM.Manage.Dashboard" %>

<asp:Content ID="Content" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <table width="772px" cellspacing="0" cellpadding="0" align="center">
        <tr>
            <td>Manage Registration Dashboard</td>
        </tr>
        <tr align="center">
            <td>
                <br />

                <asp:GridView ID="RegistrationGrid" AutoGenerateColumns="false" AllowPaging="true" PageSize="3" PagerStyle-HorizontalAlign="Center" GridLines="Both" Width="772px" CellSpacing="5" CellPadding="5" DataKeyNames="RegID" runat="server" OnPageIndexChanging="RegistrationGrid_PageIndexChanging">
                    <Columns>
                        <asp:HyperLinkField DataNavigateUrlFields="RegID" DataNavigateUrlFormatString="View.aspx?id={0}" DataTextField="Name" HeaderText="Registration Name" ItemStyle-Width="291px" />
                        <asp:BoundField DataField="EmailAddress" HeaderText="Registration Email" HeaderStyle-HorizontalAlign="Center" ItemStyle-Width="291px" />
                        <asp:BoundField DataField="DateTimeCreated" HeaderText="Registration Date" HeaderStyle-HorizontalAlign="Center" ItemStyle-HorizontalAlign="Center" ItemStyle-Width="190px" />
                    </Columns>
                </asp:GridView>

                <p>
                    <asp:Label ID="labelNoRecords" Visible="false" runat="server" Text="There are no results to show in this view"></asp:Label>
                </p>
            </td>
        </tr>
    </table>
</asp:Content>

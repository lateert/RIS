<%@ Page Title="Departments" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Departments.aspx.cs" Inherits="ContosoUniversity.DepartmentsPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Departments</h2>
    <asp:GridView ID="departmentsGrid" runat="server" CssClass="grid" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Name" HeaderText="Name" />
            <asp:BoundField DataField="Budget" HeaderText="Budget" DataFormatString="{0:N0}" />
            <asp:BoundField DataField="StartDate" HeaderText="Start date" DataFormatString="{0:d}" />
            <asp:BoundField DataField="Administrator" HeaderText="Administrator" />
        </Columns>
    </asp:GridView>
</asp:Content>

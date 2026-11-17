<%@ Page Title="Office Assignments" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="OfficeAssignments.aspx.cs" Inherits="ContosoUniversity.OfficeAssignmentsPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Office Assignments</h2>
    <asp:GridView ID="officesGrid" runat="server" CssClass="grid" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="LastName" HeaderText="Instructor" />
            <asp:BoundField DataField="FirstMidName" HeaderText="First and middle name" />
            <asp:BoundField DataField="Location" HeaderText="Office" />
        </Columns>
    </asp:GridView>
</asp:Content>

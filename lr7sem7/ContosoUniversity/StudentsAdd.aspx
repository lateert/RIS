<%@ Page Title="Add Students" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="StudentsAdd.aspx.cs" Inherits="ContosoUniversity.StudentsAddPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Add New Students</h2>
    <asp:EntityDataSource ID="StudentsEntityDataSource" runat="server"
        ContextTypeName="ContosoUniversity.SchoolEntities"
        EnableFlattening="False"
        EntitySetName="People"
        EnableInsert="True">
    </asp:EntityDataSource>
    <asp:DetailsView ID="StudentsDetailsView" runat="server"
        DataSourceID="StudentsEntityDataSource"
        AutoGenerateRows="False"
        DefaultMode="Insert"
        CssClass="grid">
        <Fields>
            <asp:BoundField DataField="FirstMidName" HeaderText="First Name" SortExpression="FirstMidName" />
            <asp:BoundField DataField="LastName" HeaderText="Last Name" SortExpression="LastName" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment Date" SortExpression="EnrollmentDate" />
            <asp:CommandField ShowInsertButton="True" />
        </Fields>
    </asp:DetailsView>
</asp:Content>

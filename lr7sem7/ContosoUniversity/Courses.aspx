<%@ Page Title="Courses" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Courses.aspx.cs" Inherits="ContosoUniversity.CoursesPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Courses by Department</h2>
    <asp:EntityDataSource ID="DepartmentsEntityDataSource" runat="server"
        ContextTypeName="ContosoUniversity.SchoolEntities"
        EnableFlattening="False"
        EntitySetName="Departments"
        Select="it.DepartmentID, it.Name"
        OrderBy="it.Name">
    </asp:EntityDataSource>
    Select a department:
    <asp:DropDownList ID="DepartmentsDropDownList" runat="server"
        DataSourceID="DepartmentsEntityDataSource"
        DataTextField="Name"
        DataValueField="DepartmentID"
        AutoPostBack="True">
    </asp:DropDownList>
</asp:Content>

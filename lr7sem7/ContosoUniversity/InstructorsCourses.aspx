<%@ Page Title="Course Assignments" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="InstructorsCourses.aspx.cs" Inherits="ContosoUniversity.InstructorsCoursesPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Course Assignments</h2>
    <asp:GridView ID="assignmentsGrid" runat="server" CssClass="grid" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="LastName" HeaderText="Instructor" />
            <asp:BoundField DataField="FirstMidName" HeaderText="First and middle name" />
            <asp:BoundField DataField="Title" HeaderText="Course" />
        </Columns>
    </asp:GridView>
</asp:Content>

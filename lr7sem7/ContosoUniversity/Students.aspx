<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Students.aspx.cs" Inherits="ContosoUniversity.StudentsPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Student List</h2>
    <asp:EntityDataSource ID="StudentsEntityDataSource" runat="server"
        ContextTypeName="ContosoUniversity.SchoolEntities"
        EnableFlattening="False"
        EntitySetName="People"
        EnableDelete="True"
        EnableUpdate="True"
        Include="StudentGrades">
    </asp:EntityDataSource>
    <asp:GridView ID="StudentsGridView" runat="server"
        AllowPaging="True"
        PageSize="4"
        AllowSorting="True"
        AutoGenerateColumns="False"
        DataKeyNames="PersonID"
        DataSourceID="StudentsEntityDataSource"
        CssClass="grid">
        <Columns>
            <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
            <asp:TemplateField HeaderText="Name" SortExpression="LastName">
                <EditItemTemplate>
                    <asp:TextBox ID="LastNameTextBox" runat="server" Text='<%# Bind("LastName") %>'></asp:TextBox>
                    <asp:TextBox ID="FirstNameTextBox" runat="server" Text='<%# Bind("FirstMidName") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="LastNameLabel" runat="server" Text='<%# Eval("LastName") %>'></asp:Label>,
                    <asp:Label ID="FirstNameLabel" runat="server" Text='<%# Eval("FirstMidName") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Enrollment Date" SortExpression="EnrollmentDate">
                <EditItemTemplate>
                    <asp:TextBox ID="EnrollmentDateTextBox" runat="server" Text='<%# Bind("EnrollmentDate", "{0:d}") %>'></asp:TextBox>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="EnrollmentDateLabel" runat="server" Text='<%# Eval("EnrollmentDate", "{0:d}") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Number of Courses">
                <ItemTemplate>
                    <asp:Label ID="CoursesCountLabel" runat="server" Text='<%# Eval("StudentGrades.Count") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

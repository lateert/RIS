<%@ Page Title="Students" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Students.aspx.cs" Inherits="ContosoUniversity.StudentsPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Students</h2>
    <asp:GridView ID="peopleGrid" runat="server" CssClass="grid" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="PersonID" HeaderText="ID" />
            <asp:BoundField DataField="LastName" HeaderText="Last name" />
            <asp:BoundField DataField="FirstMidName" HeaderText="First and middle name" />
            <asp:BoundField DataField="EnrollmentDate" HeaderText="Enrollment date" DataFormatString="{0:d}" />
        </Columns>
    </asp:GridView>
</asp:Content>

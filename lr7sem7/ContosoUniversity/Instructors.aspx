<%@ Page Title="Instructors" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Instructors.aspx.cs" Inherits="ContosoUniversity.InstructorsPage" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Instructors</h2>
    <asp:GridView ID="instructorsGrid" runat="server" CssClass="grid" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="LastName" HeaderText="Last name" />
            <asp:BoundField DataField="FirstMidName" HeaderText="First and middle name" />
            <asp:BoundField DataField="HireDate" HeaderText="Hire date" DataFormatString="{0:d}" />
        </Columns>
    </asp:GridView>
</asp:Content>

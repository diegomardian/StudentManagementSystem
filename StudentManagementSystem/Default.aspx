<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentManagementSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-4">
            <asp:GridView ID="StudentGridView" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name"/>
                    <asp:BoundField DataField="Location" HeaderText="Location"/>
                    <asp:BoundField DataField="Subject" HeaderText="Subject"/>
                    <asp:BoundField DataField="Grade" HeaderText="Grade"/>
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>

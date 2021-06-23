<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StudentManagementSystem._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
            <div class="row"><asp:Label ID="GreetingLabel" runat="server" Text=""></asp:Label></div>
            <div class="row">
                <div><h3 style="text-align: center;margin-bottom: 30px;">Student Management System</h3></div>
                <div class="col-8">
                    <asp:GridView ForeColor="#333333" CssClass="table table-striped table-bordered table-condensed"  ID="StudentGridView" DataKeyNames="id" runat="server" AutoGenerateColumns="False" OnPageIndexChanging="StudentGridView_PageIndexChanging" OnRowCancelingEdit="StudentGridView_RowCancelingEdit"  AllowPaging="true" PageSize="5" OnRowDeleting="StudentGridView_RowDeleting" OnRowEditing="StudentGridView_RowEditing" OnRowUpdating="StudentGridView_RowUpdating">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns> 
                            <asp:BoundField DataField="Name" ItemStyle-Width="150px"
                                            HeaderText="Name"/>
                            <asp:BoundField DataField="Location" HeaderText="Location"/>
                            <asp:BoundField DataField="Subject" HeaderText="Subject"/>
                            <asp:BoundField DataField="Grade" HeaderText="Grade"/>
                            <asp:CommandField ShowEditButton="true" />  

                            <asp:CommandField ShowDeleteButton="true" />
                        </Columns>
                        <EditRowStyle BackColor="#4f8ad6" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <SortedAscendingCellStyle BackColor="#F5F7FB" />
                        <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                        <SortedDescendingCellStyle BackColor="#E9EBEF" />
                        <SortedDescendingHeaderStyle BackColor="#4870BE" /> 
                    </asp:GridView>
                </div>
               <%-- <div>
                    <asp:Button runat="server" Text="Add Student" ID="AddStudent" OnClick="AddStudent_Click"/>
                </div>--%>
            </div>
</asp:Content>

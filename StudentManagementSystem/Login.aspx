<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="StudentManagementSystem.Login" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <link rel="stylesheet" href="Content/login.css"/>
    <div id="loginDiv" style="display: inline-flex;width: 100%;justify-content: center;">
        <div>
            <div>
                <h1>Login</h1>

                <fieldset>
                    <p><asp:TextBox ID="Username" value="Username" onBlur="if(this.value=='')this.value='Username'" runat="server" onFocus="if(this.value=='Username')this.value='' "></asp:TextBox></p>
                    <p><asp:TextBox ID="Password" TextMode="Password" value="Password" onBlur="if(this.value=='')this.value='Password'" onFocus="if(this.value=='Password')this.value='' " runat="server"></asp:TextBox></p>
                    <p><asp:Label ID="LoginErrorLabel" runat="server" Text="" ForeColor="red"></asp:Label></p>
                    <p><asp:Button value="Login" ID="LoginButton" runat="server" Text="Login" OnClick="Login_OnClick"/></p>
                    </fieldset>
            </div>
        </div>
        
        <p><span class="btn-round" style="margin-top: 35%;">or</span></p>
        <div>
            <div action="#">
            <h1>Sign Up</h1>

            <fieldset>
                <p><asp:TextBox ID="SignUpUsername" value="Username" onBlur="if(this.value=='')this.value='Username'" runat="server" onFocus="if(this.value=='Username')this.value='' "></asp:TextBox></p>
                <p><asp:TextBox ID="SignUpPassword" value="Password" onBlur="if(this.value=='')this.value='Password'" onFocus="if(this.value=='Password')this.value='' " runat="server"></asp:TextBox></p>
                <p><asp:DropDownList ID="TypeDropDown" runat="server">
                    <asp:ListItem Enabled="true" Text="Reader" Value="0"></asp:ListItem>
                    <asp:ListItem Text="Admin" Value="1"></asp:ListItem>
                </asp:DropDownList></p>
                <p><asp:Label ID="SignUpMessage" ForeColor="green" runat="server" Text=""></asp:Label></p>
                <p><asp:Button  value="Sign Up" ID="SignUpButton"  runat="server" OnClick="SignUpButton_OnClick" Text="Sign Up" /></p>
            </fieldset>
        </div>
        </div>
        
    </div> <!-- end login -->
</asp:Content>


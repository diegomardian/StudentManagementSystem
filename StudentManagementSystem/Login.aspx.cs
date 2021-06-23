using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentManagementSystem
{
    public partial class Login : System.Web.UI.Page
    {
        private string _connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=StudentManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_OnClick(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    conn.Open();
                    string user = Username.Text;
                    string pass = Password.Text;
                    string qry = "select * from users where Username='" + user + "' and Password='" + pass + "'";
                    SqlCommand cmd = new SqlCommand(qry, conn);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        LoginErrorLabel.Text = "";
                        Session["username"] = user;
                        Response.Redirect("Default.aspx");
                    }
                    else
                    {
                        LoginErrorLabel.Text = "Username or password is not correct";

                    }

                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void SignUpButton_OnClick(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                String password = SignUpPassword.Text;
                String username = SignUpUsername.Text;
                String type = TypeDropDown.SelectedValue;
                
                SqlCommand cmd = new SqlCommand("INSERT INTO users (Username, Password, Type) VALUES ('" + username + "','" + password +
                                                "','" + type + "')", conn);
                cmd.ExecuteNonQuery();


                SignUpMessage.Text = "Registration Done. Please login.";
                Username.Focus();

            }
        }
        
    }
}

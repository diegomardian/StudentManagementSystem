using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using StudentManagementSystem.Model;
using Type = System.Type;

namespace StudentManagementSystem
{
    public partial class _Default : Page
    {
        private string _connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(_connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("SELECT Name,Loction,Subject,Grade FROM students", sqlCon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);
                StudentGridView.DataSource = dtbl;
                StudentGridView.DataBind();
            }
           
        }
    }

}
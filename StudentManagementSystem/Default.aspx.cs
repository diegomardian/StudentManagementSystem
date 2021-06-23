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
        private string _connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=StudentManagementSystem;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected void Page_Load(object sender, EventArgs e)
        {
            GreetingLabel.Text = "Welcome " + Session["username"];
            if (!IsPostBack)
            {
                GrivViewBind();
            }
        }
        protected void GrivViewBind()
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM students", conn);
                SqlDataAdapter data = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                data.Fill(ds);
                conn.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    StudentGridView.DataSource = ds;
                    StudentGridView.DataBind();
                }
                else
                {
                    ds.Tables[0].Rows.Add(ds.Tables[0].NewRow());
                    StudentGridView.DataSource = ds;
                    StudentGridView.DataBind();
                    int columncount = StudentGridView.Rows[0].Cells.Count;
                    StudentGridView.Rows[0].Cells.Clear();
                    StudentGridView.Rows[0].Cells.Add(new TableCell());
                    StudentGridView.Rows[0].Cells[0].ColumnSpan = columncount;
                    StudentGridView.Rows[0].Cells[0].Text = "No Records Found";
                }
            }
        }
        protected void StudentGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                GridViewRow row = (GridViewRow)StudentGridView.Rows[e.RowIndex];
                conn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM students WHERE Id=@Id", conn);
                cmd.Parameters.Add(new SqlParameter("Id", Convert.ToInt32(StudentGridView.DataKeys[e.RowIndex].Value.ToString())));
                cmd.ExecuteNonQuery();
                conn.Close();
                GrivViewBind();
            }
        }
        protected void StudentGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            StudentGridView.EditIndex = e.NewEditIndex;
            GrivViewBind();
        }
        protected void StudentGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                int studentId = Convert.ToInt32(StudentGridView.DataKeys[e.RowIndex].Value.ToString());
                GridViewRow row = (GridViewRow) StudentGridView.Rows[e.RowIndex];
                TextBox name = (TextBox) row.Cells[0].Controls[0];
                TextBox location = (TextBox) row.Cells[1].Controls[0];
                TextBox subject = (TextBox) row.Cells[2].Controls[0];
                TextBox grade = (TextBox) row.Cells[3].Controls[0];
                StudentGridView.EditIndex = -1;
                conn.Open();
                SqlCommand cmd =
                    new SqlCommand(
                        "UPDATE students SET Name=@Name,Location=@Location,Subject=@Subject,Grade=@Grade WHERE Id=@Id", conn);
                cmd.Parameters.Add(new SqlParameter("Id", studentId));
                cmd.Parameters.Add(new SqlParameter("Location", location.Text));
                cmd.Parameters.Add(new SqlParameter("Subject", subject.Text));
                cmd.Parameters.Add(new SqlParameter("Name", name.Text));
                cmd.Parameters.Add(new SqlParameter("Grade", grade.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                GrivViewBind();
            }
        }
        protected void StudentGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            StudentGridView.PageIndex = e.NewPageIndex;
            GrivViewBind();
        }
        protected void StudentGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            StudentGridView.EditIndex = -1;
            GrivViewBind();
        }

        protected void AddStudent_Click(object sender, EventArgs e)
        {
            
        }
    }

}
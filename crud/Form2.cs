using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace crud
{
    public partial class Form2 : Form
    {
        string connectionString = "Server=ITSSURAJ;Database=record;Integrated Security=True;TrustServerCertificate=True;";

        public Form2()
        {
            InitializeComponent();
            LoadData();

            this.Shown += (s, e) =>
            {
                dataGridView1.Location = new System.Drawing.Point(370, 10);
                dataGridView1.Size = new System.Drawing.Size(
                    this.ClientSize.Width - 380,
                    this.ClientSize.Height - 20
                );

                // Make columns fill full grid width
                dataGridView1.AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill;
            };
        }

        private void LoadData()
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "INSERT INTO Students VALUES (@id,@name,@email,@phone,@age)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtUserID.Text);
            cmd.Parameters.AddWithValue("@name", txtUserName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Inserted!");
            ClearFields();
            LoadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "UPDATE Students SET UserName=@name,Email=@email,PhoneNumber=@phone,Age=@age WHERE UserID=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtUserID.Text);
            cmd.Parameters.AddWithValue("@name", txtUserName.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Updated!");
            ClearFields();
            LoadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            string query = "DELETE FROM Students WHERE UserID=@id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", txtUserID.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Deleted!");
            ClearFields();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtUserID.Text = row.Cells["UserID"].Value?.ToString();
                txtUserName.Text = row.Cells["UserName"].Value?.ToString();
                txtEmail.Text = row.Cells["Email"].Value?.ToString();
                txtPhone.Text = row.Cells["PhoneNumber"].Value?.ToString();
                txtAge.Text = row.Cells["Age"].Value?.ToString();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Form1 login = new Form1();
                login.Show();
                this.Close();
            }
        }

        private void ClearFields()
        {
            txtUserID.Text = txtUserName.Text = txtEmail.Text
                           = txtPhone.Text = txtAge.Text = "";
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
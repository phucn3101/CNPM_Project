using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace GOODS_INFORMATION_MANAGEMENT_SYSTEM
{
    public partial class Main : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBSDataSetACcount.account' table. You can move, or remove it, as needed.      
            fillGrid();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into account values('" + txtUserName.Text + "','" + txtFullName.Text + "','" + txtPassword.Text + "','" + txtPhoneNum.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("ADD successful");
                sqlConnection.Close();
                fillGrid();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void fillGrid()
        {           
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from account", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                TblView.DataSource = dataTable;
                sqlDataAdapter.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {

            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = TblView.Rows[e.RowIndex];
            txtUserName.Text  = row.Cells[0].Value.ToString();
            txtFullName.Text = row.Cells[1].Value.ToString();
            txtPassword.Text = row.Cells[2].Value.ToString();
            txtPhoneNum.Text = row.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from account where username='" + txtUserName.Text +"'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Delete successful");
                sqlConnection.Close();
                fillGrid();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update from account set FULLNAME='" + txtFullName.Text + "',password='"+txtPassword.Text+"' ,Phone='"+txtPhoneNum+"'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update successful");
                sqlConnection.Close();
                fillGrid();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }
    }
}

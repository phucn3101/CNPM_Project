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
            fillGridCus();
            fillGridCate();
            //fillGridPro();
            fillCate();
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
                MessageBox.Show("There are some error from account dbs " );

            }

        }

        private void fillGridCus()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from customer", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                gridcus.DataSource = dataTable;
                sqlDataAdapter.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are some error from customer dbs ");

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
                SqlCommand sqlCommand = new SqlCommand("update account set FULLNAME='" + txtFullName.Text + "',password='"+txtPassword.Text+"' ,Phone='"+txtPhoneNum.Text+ "' where username='" + txtUserName.Text+"'", sqlConnection);
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

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into customer values('" + txtcusname.Text + "','" + txtcusphone.Text + "','" + txtcuspass.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("ADD successful");
                sqlConnection.Close();
                fillGridCus();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void updatecus_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update customer set FULLNAME='" + txtcusname.Text + "',password='" + txtcuspass.Text + "' ,phonenumber='" + txtcusphone + "'where id="+txtcusid.Text, sqlConnection);
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

        private void gridcus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridcus.Rows[e.RowIndex];
            txtcusid.Text = row.Cells[0].Value.ToString();
            txtcusname.Text = row.Cells[1].Value.ToString();
            txtcusphone.Text = row.Cells[2].Value.ToString();
            txtcuspass.Text = row.Cells[3].Value.ToString();
        }

        private void deletecus_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from customer where id=" + txtcusid.Text , sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Delete successful");
                sqlConnection.Close();
                fillGridCus();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtcusid_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcusname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcusphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcuspass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnaddcate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into category values('" + txtcatename.Text + "','" + txtcatedescription.Text + "')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("ADD successful");
                sqlConnection.Close();
                fillGridCate();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void btnupdatecate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update category set name='" + txtcatename.Text + "',description='" + txtcatedescription.Text + "' where id=" + txtcateid.Text, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update successful");
                sqlConnection.Close();
                fillGridCate();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void btndeletecate_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from category where id=" + txtcateid.Text, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Delete successful");
                sqlConnection.Close();
                fillGridCate();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void fillGridCate()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from category", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                gridcate.DataSource = dataTable;
                sqlDataAdapter.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are some error from category dbs");
            }

        }

        private void gridcate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridcate.Rows[e.RowIndex];
            txtcateid.Text = row.Cells[0].Value.ToString();
            txtcatename.Text = row.Cells[1].Value.ToString();
            txtcatedescription.Text = row.Cells[2].Value.ToString();
        }

        private void girdproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridcate.Rows[e.RowIndex];
            txtcateid.Text = row.Cells[0].Value.ToString();
            txtcatename.Text = row.Cells[1].Value.ToString();
            txtcatedescription.Text = row.Cells[2].Value.ToString();
        }

        private void fillGridPro()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from product", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                TblView.DataSource = dataTable;
                sqlDataAdapter.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are some error from product dbs");
            }

        }

        private void btnaddproduct_Click(object sender, EventArgs e)
        {

        }

        private void fillCate()
        {

            try {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from category", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("name", typeof(string));
                SqlDataReader rd = sqlCommand.ExecuteReader();
                dataTable.Load(rd);
                combocate.ValueMember = "name";
                combocate.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There are some error from category dbs ");

            }


        }
    }
    
}

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
            fillGridPro();
            fillCate();
            fillimport();
            fillItem();
            fillgridcusbill1();
            fillgridcusbill2();
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
            DataGridViewRow row = gridproduct.Rows[e.RowIndex];
            txtproid.Text = row.Cells[0].Value.ToString();
            txtproname.Text = row.Cells[1].Value.ToString();
            txtprodescription.Text = row.Cells[2].Value.ToString();
            txtproprice.Text = row.Cells[3].Value.ToString();
            combocate.SelectedItem = row.Cells[4].Value.ToString();
            txtproquantity.Text = row.Cells[5].Value.ToString();
            txtproimg.Text = row.Cells[6].Value.ToString();
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
                gridproduct.DataSource = dataTable;
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
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into product values('" + txtproname.Text + "','" + txtprodescription.Text + "'," + txtproprice.Text + ","+ combocate.SelectedValue.ToString() +"," + txtproquantity.Text + ",'"+txtproimg.Text+"')", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("ADD successful");
                sqlConnection.Close();
                fillGridPro();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There are some error!!!"+ combocate.SelectedValue.ToString() +ex.Message.ToString());
            }
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
                combocate.ValueMember = "id";
                combocate.DataSource = dataTable;
                sqlConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("There are some error from category dbs ");

            }
        }

        private void btnupdateproduct_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update product set name='" + txtproname.Text + "',description='" + txtprodescription.Text + "' ,price=" + txtproprice.Text + " ,categoryid="+ combocate.SelectedValue.ToString() + " ,quantity="+ txtproquantity.Text+ " ,img=' " + txtproimg.Text + "' where id=" + txtproid.Text, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Update successful");
                sqlConnection.Close();
                fillGridPro();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void btndeleteproduct_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from product where id=" + txtproid.Text, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Delete successful");
                sqlConnection.Close();
                fillGridPro();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void addImport_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("insert into bill_import values(GETDATE(),'" + txtimportname.Text +"',NULL)", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("ADD successful");
                sqlConnection.Close();
                fillimport();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void gridimport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridimport.Rows[e.RowIndex];
            string id = row.Cells[0].Value.ToString();
            txtaddbilld.Text = id;
            fillAddeditem(id);
        }

        private void fillimport()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from bill_import", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                gridimport.DataSource = dataTable;
                sqlDataAdapter.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are some error from product dbs");
            }
        }

        private void girditemimport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = girditemimport.Rows[e.RowIndex];
            txtaddproid.Text = row.Cells[0].Value.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void fillItem()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from product", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                girditemimport.DataSource = dataTable;
                sqlDataAdapter.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are some error from category dbs");
            }
        }

        private void btnadditem_Click(object sender, EventArgs e)
        {
            if (txtaddproid.Text == "")
            {
                MessageBox.Show("Please select product");
            }else if (txtaddbilld.Text == "")
            {
                MessageBox.Show("Please select Bill");
            }
            else if (txtaddbilld.Text == "")
            {
                MessageBox.Show("Please fill quantity");
            }
            else
            {
                try
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("insert into product_billimport values(" + txtaddbilld.Text + ","+ txtaddproid.Text+","+txtaddquantity.Text+")", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("ADD successful");
                    sqlConnection.Close();
                    fillAddeditem(txtaddbilld.Text);
                }
                catch
                {
                    MessageBox.Show("There are some error!!!");
                }
            }
        }

        private void gridshowimport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void fillAddeditem(string id)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select name from product, product_billimport  where billid= id and id=" + id , sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                gridshowimport.DataSource = dataTable;
                sqlDataAdapter.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are some error from category dbs");
            }
        }

        private void deleteimport_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("delete from product_billimport where billid=" + txtaddbilld.Text, sqlConnection);
                sqlCommand.ExecuteNonQuery(); 
                sqlCommand = new SqlCommand("delete from bill_import where id=" + txtaddbilld.Text, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Delete successful");
                sqlConnection.Close();
                fillimport();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("update customerbill set status='be trans.'  where id=" + txttemp.Text , sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Successful");
                sqlConnection.Close();
                fillgridcusbill1();
                fillgridcusbill2();
            }
            catch
            {
                MessageBox.Show("There are some error!!!");
            }
        }

        private void gridcusbill1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gridimport.Rows[e.RowIndex];
            string id = row.Cells[0].Value.ToString();
            txttemp.Text = id;
            fillAddeditem(id);
        }

        private void fillgridcusbill1()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from customerbill where status='paid'", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                gridcusbill1.DataSource = dataTable;
                sqlDataAdapter.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are some error from product dbs");
            }
        }

        private void fillgridcusbill2()
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from customerbill where status='be trans.'", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                gridcusbill2.DataSource = dataTable;
                sqlDataAdapter.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("There are some error from product dbs");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("select * from customerbill where datecreate >='"+ dateTimePicker1.Value.Date+ "' and datecreate <='" + dateTimePicker2.Value.Date+"'", sqlConnection);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                sqlDataAdapter.Dispose();


                SqlCommand sqlCommand1 = new SqlCommand("select sum(customerbill.quantity* price) as total from customerbill, product where datecreate >='" + dateTimePicker1.Value.Date + "' and datecreate <='" + dateTimePicker2.Value.Date + "' and product.id=customerbill.id", sqlConnection);
                SqlDataAdapter sqlDataAdapter1 = new SqlDataAdapter(sqlCommand1);
                DataTable dataTable1 = new DataTable();
                sqlDataAdapter1.Fill(dataTable1);
                if (dataTable1.Rows.Count > 0)
                {
                    textBox1.Text = dataTable1.Rows[0]["total"].ToString();
                }
                else
                {
                    textBox1.Text = "0";
                }
                sqlDataAdapter1.Dispose();
                sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}

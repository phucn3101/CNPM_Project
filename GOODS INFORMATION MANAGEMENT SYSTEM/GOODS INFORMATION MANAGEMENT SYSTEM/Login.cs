using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOODS_INFORMATION_MANAGEMENT_SYSTEM
{
    public partial class Login : Form
    {
        private SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());

        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("select * from account ", sqlConnection);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            sqlConnection.Close();
            if (dt.Rows.Count > 0)
            {
                Main main = new Main();
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Username or password is wrong.");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
    }
}

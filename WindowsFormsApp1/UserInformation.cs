using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class UserInformation : Form
    {
        //string connectionString = "SERVER=localhost; DATABASE=chings; UID=root; PASSWORD=12345";
        //MySqlConnection myconn = new MySqlConnection(connectionString);
        
        public UserInformation()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            a_main ss = new a_main();
            ss.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserInformation_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * from normal_user", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "normal_user");
                dataGridView1.DataSource = ds.Tables["normal_user"];
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //private void UserInformation()
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            u_main ss = new u_main();
            ss.Show();
        }

        
        private void MyAccount_Load(object sender, EventArgs e)//string Query = "Select * from adb.room_booking where u_id='" + textBox1.Text + "';";
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from adb.room_booking where u_id = '" + textBox1.Text + "'; ;", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "ratings");
                dataGridView1.DataSource = ds.Tables["ratings"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                MySqlDataAdapter adapter = new MySqlDataAdapter("Select * from adb.room_booking where u_id = '" + textBox1.Text + "'; ;", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "ratings");
                dataGridView1.DataSource = ds.Tables["ratings"];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

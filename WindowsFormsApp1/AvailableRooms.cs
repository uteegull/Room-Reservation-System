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
    public partial class AvailableRooms : Form
    {
        public AvailableRooms()
        {
            InitializeComponent();
        }

        private void RoomDetails_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * from room_details", connection);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            u_main ss = new u_main();
            ss.Show();
        }
    }
}

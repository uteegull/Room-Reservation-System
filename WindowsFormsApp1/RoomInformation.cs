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
    public partial class RoomInformation : Form
    {
        public RoomInformation()
        {
            InitializeComponent();
        }

        public void disp_data()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * from room_details", connection);
                connection.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "room_details");
                dataGridView1.DataSource = ds.Tables["room_details"];
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
            a_main ss = new a_main();
            ss.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RoomInformation_Load(object sender, EventArgs e)
        {
            disp_data();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                MySqlConnection Myconnection2 = new MySqlConnection();
                Myconnection2.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                //string MyConnection2 = "datasource=localhost;port=3307;username=root;password=12345";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "update adb.room_details set room_no='" + this.textBox1.Text + "',capacity='" + this.textBox2.Text + "',room_type='" + this.textBox3.Text +"',amenities='"+textBox4.Text+ "' where room_no='" + this.textBox1.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Myconnection2);
                MySqlDataReader MyReader2;
                Myconnection2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                disp_data();
                Myconnection2.Close();
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
                //This is my connection string i have assigned the database file address path  
                MySqlConnection Myconnection2 = new MySqlConnection();
                Myconnection2.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                //string MyConnection2 = "datasource=localhost;port=3307;username=root;password=12345";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "insert into adb.room_details(room_no,capacity,room_type,amenities) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "');";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Myconnection2);
                MySqlDataReader MyReader2;
                Myconnection2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                disp_data();
                Myconnection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                MySqlConnection Myconnection2 = new MySqlConnection();
                Myconnection2.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                //string MyConnection2 = "datasource=localhost;port=3307;username=root;password=12345";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "delete from adb.room_details where room_no='" + this.textBox1.Text + "';";
                //This is  MySqlConnection here i have created the object and pass my connection string.  
                //MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, Myconnection2);
                MySqlDataReader MyReader2;
                Myconnection2.Open();
                MyReader2 = MyCommand2.ExecuteReader();     // Here our query will be executed and data saved into the database.  
                MessageBox.Show("Save Data");
                while (MyReader2.Read())
                {
                }
                disp_data();
                Myconnection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

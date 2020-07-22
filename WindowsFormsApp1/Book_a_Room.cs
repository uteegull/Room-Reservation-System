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
    public partial class Book_a_Room : Form
    {
        public Book_a_Room()
        {
            InitializeComponent();
        }

        public void disp_data()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * from room_booking", connection);
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

        private void Book_a_Room_Load(object sender, EventArgs e)
        {
            disp_data();
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
                string Query = "insert into adb.room_booking(u_id,room_no,special_req) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "');";
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                MySqlConnection Myconnection2 = new MySqlConnection();
                Myconnection2.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                //string MyConnection2 = "datasource=localhost;port=3307;username=root;password=12345";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "update adb.room_booking set u_id='" + this.textBox1.Text + "',room_no='" + this.textBox2.Text + "',special_req='" + this.textBox3.Text + "' where u_id='" + this.textBox1.Text + "';";
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                //This is my connection string i have assigned the database file address path  
                MySqlConnection Myconnection2 = new MySqlConnection();
                Myconnection2.ConnectionString = "database=adb;server=35.237.101.138;user id=root;pwd=12345";
                //string MyConnection2 = "datasource=localhost;port=3307;username=root;password=12345";
                //This is my insert query in which i am taking input from the user through windows forms  
                string Query = "delete from adb.room_booking where u_id='" + this.textBox1.Text + "';";
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Mysql.Data.MysqlClient;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        //textBox2.PasswordChar = '*';

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox3.Text;
            string password = textBox4.Text;

            if ((this.textBox3.Text == "User") && (this.textBox4.Text == "user"))
            {
                //attempt = 0;
                //pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Desktop\granted.jpg");
                MessageBox.Show("you are granted with access");
                this.Hide();
                u_main ss = new u_main();
                ss.Show();


            }
            
            else
            {
               // pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Desktop\denied.jpg");
                MessageBox.Show("you are not granted with access");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            register ss = new register();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            //textBox2.Text = "";
            //textBox2.PasswordChar = '*';
            //textBox2.MaxLength = 20;
            string password = textBox2.Text;
            //textBox2.PasswordChar = '*';

            if ((this.textBox1.Text == "Admin") && (this.textBox2.Text == "admin"))
            {
                //attempt = 0;
                //pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Desktop\granted.jpg");
                MessageBox.Show("you are granted with access");
                this.Hide();
                a_main ss = new a_main();
                ss.Show();


            }

            else
            {
                // pictureBox1.Image = new Bitmap(@"C:\Users\Mic 18\Desktop\denied.jpg");
                MessageBox.Show("you are not granted with access");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.PasswordChar = '*';
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}

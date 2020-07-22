using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class a_main : Form
    {
        public a_main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoomInformation ss = new RoomInformation();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserInformation ss = new UserInformation();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reports ss = new Reports();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Updation ss = new Updation();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // dim ExitedForm As login
            this.Hide();
            login ss = new login();
            ss.Show();
        }

        private void a_main_Load(object sender, EventArgs e)
        {

        }
    }
}

using PSEE.curd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSEE
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_event ds = new add_event();
            ds.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            delete_event ds = new delete_event();
            ds.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            updete_event ds = new updete_event();
            ds.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            show_all ds = new show_all();
            ds.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 login_Page = new Form1();
            this.Hide();
            login_Page.Show();
        }
    }
}

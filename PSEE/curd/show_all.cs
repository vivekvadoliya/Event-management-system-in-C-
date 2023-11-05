using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSEE.curd
{
    public partial class show_all : Form
    {
        function fn = new function();
        string query;

        public show_all()
        {
            InitializeComponent();
        }

        public void loaddata()
        {
            query = "select * from event";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void show_all_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            main dashbord = new main();
            this.Hide();
            dashbord.Show();
        }
    }
}

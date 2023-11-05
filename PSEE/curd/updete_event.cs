using System;
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
    public partial class updete_event : Form
    {
        function fn = new function();
        string query;
        public updete_event()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string type = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string price = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string date = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            textBox4.Text = date;
            textBox3.Text = type;
            textBox1.Text = name;
            textBox2.Text = price;
        }

        public void loaddata()
        {
            query = "select * from event";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            query = "update event set customer_name = '" + textBox1.Text + "' ,price ='" + textBox2.Text + "',date ='"+textBox4.Text+"' ,type =" + textBox3.Text + "";
            fn.getData(query);
            loaddata();
        }

        private void updete_event_Load(object sender, EventArgs e)
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

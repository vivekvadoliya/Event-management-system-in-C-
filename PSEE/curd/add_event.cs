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
    public partial class add_event : Form
    {
        function fn = new function();
        string query;
        public add_event()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            query = "insert into event (id,customer_name,date,type,price) values('"+txtid.Text+"','" + txtname.Text + "','" + txtdate.Text + "', '"+txttype.Text+"' ,'" + txtprice.Text + "')";
            fn.setData(query);
            clearall();
        }

        public void clearall()
        {
            txtid.Clear();
            txtname.Clear();
            txtdate.Clear();
            txtprice.Clear();
            txttype.Clear();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            main dashbord= new main();
            this.Hide();
            dashbord.Show();
        }
    }
}

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
    public partial class delete_event : Form
    {
        function fn = new function();
        string query;

        public void loaddata()
        {
            query = "select * from event";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        public delete_event()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("Delete Item?", "Important Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                int id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                query = "delete from event where id = " + id + "";
                fn.setData(query);
                loaddata();

            }
        }

        private void delete_event_Load(object sender, EventArgs e)
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

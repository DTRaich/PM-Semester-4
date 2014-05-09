using Supernova.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmCriteriaWeight : Form
    {
        public FrmCriteriaWeight()
        {
            InitializeComponent();
            DataLoad dl = new DataLoad();
            dataGridView1.DataSource = dl.loadtest();
            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            List<int> li = new List<int>();
            li.Add(1);
            li.Add(2);
            li.Add(3);
            comboBoxColumn.DataSource = li;

            comboBoxColumn.ValueType = typeof(int);
            dataGridView1.Columns.Add(comboBoxColumn);
            DataGridViewCheckBoxColumn cl = new DataGridViewCheckBoxColumn();
            dataGridView1.Columns.Add(cl);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dr in dataGridView1.Rows)
            {
                foreach (DataGridViewCell dc in dr.Cells)
                {
                    object dsd = dc.Value;
                }
            }
        }
    }
}

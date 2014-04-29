using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rechte_DEMO
{
    public partial class Frm_Main : Form
    {        

        public Frm_Main(bool test)
        {           
            InitializeComponent();
            InitializeRights(test);
            LoadDATA();
        }

        private void LoadDATA()
        {
            Data da = new Data();
            dataGridView1.DataSource = da.loadtest();


            dataGridView1.Columns["U_NAME"].HeaderText = "User-Name";
            dataGridView1.Columns[0].Visible = false;

            DataGridViewRow dgr = new DataGridViewRow();
            dataGridView2.Rows.Add(dgr);

        }

        private void InitializeRights(bool test)
        {
            //Data da = new Data();
            //da.UserRight(1, this.Name);

            if (test)
            {
                btn_Save.Visible = true;
                dataGridView1.ReadOnly = false;
            }
            else
            {
                btn_Save.Visible = false;
                dataGridView1.ReadOnly = true;
            }


        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

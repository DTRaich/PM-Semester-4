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
    public partial class Frm_Crud_test : Form
    {
        public Frm_Crud_test()
        {
            InitializeComponent();            
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Main myForm = new Frm_Main(true);
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            myForm.AutoSize = true;
            this.panel1.Controls.Add(myForm);
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Show();
        }

        private void tes3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data da =  new Data();
            try
            {
                da.SaveTest("eins", "zwei");

            }catch (Exception ex)
            {
                toolStripStatusLabel1.Text = ex.Message;
                statusStrip1.Refresh();
            }

                



        }
    }
}

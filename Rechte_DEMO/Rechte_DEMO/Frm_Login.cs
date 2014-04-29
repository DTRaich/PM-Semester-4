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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();            
            List<string> stuList = new List<string>();
            stuList.Add("test");
            stuList.Add("test2");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btn_Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            Login();
        }

        private void Login()
        {

            //Data da = new Data();
            //string fromname = this.Name.ToString();
            //da.UserRight(1, fromname);

            bool test = true;
            if (tb_Username.Text.Equals("Sina"))
            {
                test = false;
            }
            else
            {
                test = true;
            }

            Frm_Main login = new Frm_Main(test);
            login.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Crud_test frm = new Frm_Crud_test();
            frm.Show();
        }
    }
}

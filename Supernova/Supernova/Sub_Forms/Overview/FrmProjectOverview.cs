using Supernova.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.Overview
{
    public partial class FrmProjectOverview : Form
    {
        DataLoad dl = new DataLoad();

        public FrmProjectOverview()
        {
            InitializeComponent();
            DataTable dt = dl.LoadUserData(12);
            DataTable dl2 = dl.LoadUserData(13);
            dl2.Merge(dt);
            mainGrid.DataSource = dl2;
        }

        private void tsmDetail_Click(object sender, EventArgs e)
        {

        }

        private void tsmChange_Click(object sender, EventArgs e)
        {

        }

        private void mainGrid_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                int currentMouseOverRow = mainGrid.HitTest(e.X, e.Y).RowIndex;
                cmsGridMenu.Show(mainGrid, new Point(e.X, e.Y));
            }
        }
    }
}

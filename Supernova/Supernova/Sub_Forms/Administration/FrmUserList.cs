using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.data;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmUserList : Form
    {
        public string username { get; set; }

        public FrmUserList()
        {
            InitializeComponent();
            this.username = username;
            getData();
        }

        private void getData()
        {
            DataLoad loader = new DataLoad();

            DataTable userList = loader.getUserList();
            userGrid.DataSource = userList;
        }

        public void userGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string clickedUsername;
            int activeRow = 0;
            activeRow = Convert.ToInt32(e.RowIndex);

            if (activeRow > -1)
            {
                clickedUsername = userGrid.Rows[activeRow].Cells[0].Value.ToString();
                this.username = clickedUsername;
                this.Close();
            }
         

         }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.objects;

namespace Supernova.Sub_Forms.General
{
    public partial class FrmUserInformation : Form
    {
        User us;
        public FrmUserInformation(int uid)
        {
            InitializeComponent();
            InitializeUser(uid);
            InitializeData();

        }

        private void InitializeData()
        {
            tbFirstName.Text = us.firstname;
            tbLastName.Text = us.lastname;
            tbEmail.Text = us.email;
        }

        private void InitializeUser(int uid)
        {
            us = new User();
            us.LoadUser(uid);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

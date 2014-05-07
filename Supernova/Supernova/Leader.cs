using Supernova.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova
{
    class Leader
    {
        #region fields
        private Panel mainPanel;

        #endregion

        public Leader(Panel pnl)
        {
            this.mainPanel = pnl;
        }

        #region publicMethods

        public void LoadLogin()
        {
            mainPanel.Controls.Clear();            
            FrmLogin login = new FrmLogin();
            mainPanel.Controls.Add(prepareForm(login));
            login.Show();
            
        }
        #endregion

        #region privateMethods

        /// <summary>
        /// Diese Methode aufrufen, um die Form für PanelControl bereit zumachen.
        /// </summary>
        /// <param name="frm">Form</param>
        /// <returns>Form</returns>
        private Form prepareForm(Form frm)
        {
            frm.AutoScroll = true;
            frm.AutoSize = true;
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;

            return frm;
        }
        #endregion


    }
}

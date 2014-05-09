using Supernova.helper;
using Supernova.objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace Supernova
{
    public partial class FrmOrderControlling : Form
    {

        private List<Form> formslist;
        Form currentFrm;
        private int formNumber = 0;
        ProjektDataDummy projektDaten;

        public FrmOrderControlling(List<Form> FormList,ref ProjektDataDummy projektDummy)
        {
            InitializeComponent();
            this.formslist = FormList;
            projektDaten = projektDummy;
            
        }

        private void FrmOrderControlling_Load(object sender, EventArgs e)
        {
            currentFrm = formslist[formNumber];
            this.pnlControl.Controls.Add(currentFrm);
            currentFrm.Show();
        }
                

        private void btnNext_Click(object sender, EventArgs e)
        {
            MethodInfo info = currentFrm.GetType().GetMethod("checkAndValidateForm");

            bool ok = (bool)info.Invoke(currentFrm, null);
            if (ok)
            {
                formNumber = formNumber + 1;
                currentFrm.Close();
                currentFrm = formslist[formNumber];
                this.pnlControl.Controls.Add(currentFrm);
                currentFrm.Show();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formNumber = formNumber - 1;
            currentFrm.Close();
            currentFrm = formslist[formNumber];
            this.pnlControl.Controls.Add(currentFrm);
            currentFrm.Show();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(projektDaten.saveProjectDataToDb())
            {
                //speichern erfolgreich
                //wenn dialog result ok form schließen 
            }
            else
            {
                //Speichern fehlgeschlagen
            }
        }
    }
}

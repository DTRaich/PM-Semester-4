using Supernova.helper;
using Supernova.objects;
using Supernova.Sub_Forms.General;
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
        private int highestFormNumber = 0;
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
            setButtons();           
           
        }
                

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                MethodInfo info = currentFrm.GetType().GetMethod("checkAndValidateForm");

                bool ok = (bool)info.Invoke(currentFrm, null);
                if (ok)
                {

                    currentFrm.Visible = false;
                    formNumber = formNumber + 1;
                    currentFrm = formslist[formNumber];
                    this.pnlControl.Controls.Add(currentFrm);

                 
                    if (highestFormNumber > formNumber)
                    {
                        currentFrm.Visible = true;
                    }
                    else
                    {
                        highestFormNumber = formNumber;
                        currentFrm.Show();

                    }
                    setButtons();
                }
            }
            catch (Exception ex)
            {
                FrmAfirmative fatalError = new FrmAfirmative("Projektfehler!\nBitte wenden Sie sich umgehend an den Administrator", 'e');
                fatalError.ShowDialog();
                this.Close();
            }
                      

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmAfirmative cancel  = new FrmAfirmative("Abbrechen?\nProjekterstellung abbrechen?\n",'c');
            if (cancel.ShowDialog() == DialogResult.OK)
            {
                Leader.getLeaderInst().LoadProjektView();
                this.Close();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            formNumber = formNumber - 1;
            currentFrm.Visible = false;
            currentFrm = formslist[formNumber];            
            this.pnlControl.Controls.Add(currentFrm);
            currentFrm.Visible = true;
            setButtons();           

        }

        private void setButtons()
        {
            //back
            if (formNumber < 1)
            {
                btnBack.Visible = false;
            }
            else
            {
                btnBack.Visible = true;
            }

            //next
            if (formNumber < formslist.Count)
            {
                btnNext.Visible = true;
            }
            else
            {
                btnNext.Visible = false;
            }

            // save
            if (formNumber == formslist.Count-1)
            {
                btnSave.Visible = true;
                btnNext.Visible = false;
            }
            else
            {
                btnSave.Visible = false;
                btnNext.Visible = true;
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(projektDaten.saveProjectDataToDb())
            {
                FrmAfirmative affir = new FrmAfirmative("Projekt wurde erfolgreich gespeichert", 'i');
                affir.ShowDialog();
                Leader.getLeaderInst().LoadProjektView();
                this.Close(); 
            }
            else
            {
                FrmAfirmative affir = new FrmAfirmative("Speichern fehlgeschlagen!\n Bitte wenden Sie sich an den Administrator", 'e');
                affir.ShowDialog();
                this.Close();
            }
        }
    }
}

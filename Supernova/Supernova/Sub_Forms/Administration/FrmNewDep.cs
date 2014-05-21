using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Supernova.Sub_Forms.General;
using Supernova.data;

namespace Supernova.Sub_Forms.Administration
{
    public partial class FrmNewDep : Form
    {
        int budget1 = 0;
        int budget2 = 0;
        int budget3 = 0;
        string newDepName;
        DataTable List;

        public FrmNewDep( DataTable list)
        {
            InitializeComponent();
            btnCancel.DialogResult = DialogResult.Cancel;
            this.List = list;
        }

  
   private bool checkTextBox(string content, TextBox field)
   {
       field.BackColor = Color.White;

       if (String.IsNullOrWhiteSpace(content) || String.IsNullOrEmpty(content))
       {
           field.BackColor = Color.Bisque;
           return false;
       }
       else
       {

           return true;
       }
   }

   private bool checkMaskedBox(string content, MaskedTextBox field)
   {
       field.BackColor = Color.White;

       if (String.IsNullOrWhiteSpace(content) || String.IsNullOrEmpty(content))
       {
           field.BackColor = Color.Bisque;
           return false;
       }
       else
       {
           return true;
       }

   }

   private bool checkContent()
   {
       bool retval = true;



       if (checkTextBox(txtDepName.Text, txtDepName))
       {
           newDepName = txtDepName.Text;
       }
       else
       {
           retval = false;
       }



       if (checkMaskedBox(mtbBudget1.Text, mtbBudget1))
       {
           budget1 = Convert.ToInt32(mtbBudget1.Text);
       }
       else
       {
           retval = false;
       }

       if (checkMaskedBox(mtbBudget2.Text, mtbBudget2))
       {
           budget2 = Convert.ToInt32(mtbBudget2.Text);
       }
       else
       {
           retval = false;
       }

       if (checkMaskedBox(mtbBudget3.Text, mtbBudget3))
       {
           budget3 = Convert.ToInt32(mtbBudget3.Text);
       }
       else
       {
           retval = false;
       }

       return retval;
   }

   private void btnOk_Click(object sender, EventArgs e)
   {
       if (checkContent() == true)
       {
           if (checkAlreadyThere())
           {
               DataSave saver = new DataSave();
               saver.newDep(newDepName, budget1, budget2, budget3);

               FrmAfirmative newDep = new FrmAfirmative("Eine neue Abteilung wurde erstellt.", 'i');
               newDep.ShowDialog();
               this.Close();

               btnOk.DialogResult = DialogResult.OK;
           }
           else 
           { 
               FrmAfirmative alreadyThere = new FrmAfirmative("Diese Abteilung ist schon vorhanden.",'e');
               alreadyThere.ShowDialog();
           }
          
       }
       else 
       {
           FrmAfirmative error = new FrmAfirmative("Bitte alle Felder richtig ausfüllen.", 'e');
           error.ShowDialog();
       }
      }

   private bool checkAlreadyThere()
   {
       bool retval = true;
       string check = txtDepName.Text;

       foreach (DataRow dr in List.Rows) 
       {
           if (dr[1].ToString().Equals(check))
           {
               retval = false;
           }
       
       }


       return retval;
   }
    }
}

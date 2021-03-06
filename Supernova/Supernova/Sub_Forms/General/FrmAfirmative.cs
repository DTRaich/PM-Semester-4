﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Supernova.Sub_Forms.General
{
    public partial class FrmAfirmative : Form
    {
        public FrmAfirmative(string text, char type)
        {
            InitializeComponent();
            switch (type)
            {
                case 'e':
                    this.Text = "Fehler";
                    lblAfirmationText.Text = text;
                    btnCancel.Visible = false;
                    break;
                case 's':
                    this.Text = "Speichern";
                    lblAfirmationText.Text = text;
                    break;
                case 'd':
                    this.Text = "Löschen";
                    lblAfirmationText.Text = text;
                    break;
                case 'u':
                    this.Text = "Aktualisiert";
                    lblAfirmationText.Text = text;
                    btnCancel.Visible = false;
                    break;
                case 'i':
                    this.Text = "Gespeichert";
                    lblAfirmationText.Text = text;
                    btnCancel.Visible = false;
                    break;

            }

            btnCancel.DialogResult = DialogResult.Cancel;
            btnOkay.DialogResult = DialogResult.OK;
        }
    }
}

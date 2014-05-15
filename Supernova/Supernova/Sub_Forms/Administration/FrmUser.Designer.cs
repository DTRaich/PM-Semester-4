namespace Supernova.Sub_Forms.Administration
{
    partial class FrmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Load = new System.Windows.Forms.GroupBox();
            this.lblUsernameLoad = new System.Windows.Forms.Label();
            this.lblErrorText = new System.Windows.Forms.Label();
            this.btnUserLoad = new System.Windows.Forms.Button();
            this.txtUsernameLoad = new System.Windows.Forms.TextBox();
            this.gb_change = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.mtbPassword = new System.Windows.Forms.MaskedTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cbAbteilung = new System.Windows.Forms.ComboBox();
            this.lblBenutzergruppe = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbBenutzergruppe = new System.Windows.Forms.ComboBox();
            this.lblAbteilung = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNachname = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.gb_Load.SuspendLayout();
            this.gb_change.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Load
            // 
            this.gb_Load.Controls.Add(this.lblUsernameLoad);
            this.gb_Load.Controls.Add(this.lblErrorText);
            this.gb_Load.Controls.Add(this.btnUserLoad);
            this.gb_Load.Controls.Add(this.txtUsernameLoad);
            this.gb_Load.Location = new System.Drawing.Point(12, 12);
            this.gb_Load.Name = "gb_Load";
            this.gb_Load.Size = new System.Drawing.Size(921, 62);
            this.gb_Load.TabIndex = 0;
            this.gb_Load.TabStop = false;
            // 
            // lblUsernameLoad
            // 
            this.lblUsernameLoad.AutoSize = true;
            this.lblUsernameLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameLoad.Location = new System.Drawing.Point(131, 22);
            this.lblUsernameLoad.Name = "lblUsernameLoad";
            this.lblUsernameLoad.Size = new System.Drawing.Size(100, 17);
            this.lblUsernameLoad.TabIndex = 3;
            this.lblUsernameLoad.Text = "Benutzername";
            // 
            // lblErrorText
            // 
            this.lblErrorText.AutoSize = true;
            this.lblErrorText.Location = new System.Drawing.Point(239, 46);
            this.lblErrorText.Name = "lblErrorText";
            this.lblErrorText.Size = new System.Drawing.Size(144, 13);
            this.lblErrorText.TabIndex = 2;
            this.lblErrorText.Text = "Bitte Benutzername ausfüllen";
            this.lblErrorText.Visible = false;
            // 
            // btnUserLoad
            // 
            this.btnUserLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserLoad.Location = new System.Drawing.Point(495, 14);
            this.btnUserLoad.Name = "btnUserLoad";
            this.btnUserLoad.Size = new System.Drawing.Size(138, 32);
            this.btnUserLoad.TabIndex = 1;
            this.btnUserLoad.Text = "Benutzer Laden";
            this.btnUserLoad.UseVisualStyleBackColor = true;
            this.btnUserLoad.Click += new System.EventHandler(this.btnUserLoad_Click);
            // 
            // txtUsernameLoad
            // 
            this.txtUsernameLoad.Location = new System.Drawing.Point(238, 19);
            this.txtUsernameLoad.Name = "txtUsernameLoad";
            this.txtUsernameLoad.Size = new System.Drawing.Size(151, 20);
            this.txtUsernameLoad.TabIndex = 0;
            // 
            // gb_change
            // 
            this.gb_change.Controls.Add(this.btnCancel);
            this.gb_change.Controls.Add(this.btnDelete);
            this.gb_change.Controls.Add(this.mtbPassword);
            this.gb_change.Controls.Add(this.lblPassword);
            this.gb_change.Controls.Add(this.lblUsername);
            this.gb_change.Controls.Add(this.txtUsername);
            this.gb_change.Controls.Add(this.txtVorname);
            this.gb_change.Controls.Add(this.txtNachname);
            this.gb_change.Controls.Add(this.txtEmail);
            this.gb_change.Controls.Add(this.cbAbteilung);
            this.gb_change.Controls.Add(this.lblBenutzergruppe);
            this.gb_change.Controls.Add(this.btnSave);
            this.gb_change.Controls.Add(this.cbBenutzergruppe);
            this.gb_change.Controls.Add(this.lblAbteilung);
            this.gb_change.Controls.Add(this.lblEmail);
            this.gb_change.Controls.Add(this.lblNachname);
            this.gb_change.Controls.Add(this.lblVorname);
            this.gb_change.Location = new System.Drawing.Point(12, 80);
            this.gb_change.Name = "gb_change";
            this.gb_change.Size = new System.Drawing.Size(921, 289);
            this.gb_change.TabIndex = 1;
            this.gb_change.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(495, 245);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 29);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Verwerfen";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(661, 198);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 29);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Benutzer löschen";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // mtbPassword
            // 
            this.mtbPassword.Location = new System.Drawing.Point(661, 26);
            this.mtbPassword.Mask = "00000";
            this.mtbPassword.Name = "mtbPassword";
            this.mtbPassword.Size = new System.Drawing.Size(36, 20);
            this.mtbPassword.TabIndex = 14;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(494, 27);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(65, 17);
            this.lblPassword.TabIndex = 13;
            this.lblPassword.Text = "Passwort";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(131, 164);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(100, 17);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Benutzername";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(238, 163);
            this.txtUsername.MaxLength = 25;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(145, 20);
            this.txtUsername.TabIndex = 11;
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(238, 26);
            this.txtVorname.MaxLength = 25;
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.Size = new System.Drawing.Size(145, 20);
            this.txtVorname.TabIndex = 10;
            // 
            // txtNachname
            // 
            this.txtNachname.Location = new System.Drawing.Point(238, 98);
            this.txtNachname.MaxLength = 25;
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.Size = new System.Drawing.Size(145, 20);
            this.txtNachname.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(238, 234);
            this.txtEmail.MaxLength = 75;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(145, 20);
            this.txtEmail.TabIndex = 8;
            // 
            // cbAbteilung
            // 
            this.cbAbteilung.FormattingEnabled = true;
            this.cbAbteilung.Location = new System.Drawing.Point(661, 163);
            this.cbAbteilung.Name = "cbAbteilung";
            this.cbAbteilung.Size = new System.Drawing.Size(150, 21);
            this.cbAbteilung.TabIndex = 7;
            // 
            // lblBenutzergruppe
            // 
            this.lblBenutzergruppe.AutoSize = true;
            this.lblBenutzergruppe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBenutzergruppe.Location = new System.Drawing.Point(492, 98);
            this.lblBenutzergruppe.Name = "lblBenutzergruppe";
            this.lblBenutzergruppe.Size = new System.Drawing.Size(110, 17);
            this.lblBenutzergruppe.TabIndex = 6;
            this.lblBenutzergruppe.Text = "Benutzergruppe";
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(661, 245);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 29);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Benutzer speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbBenutzergruppe
            // 
            this.cbBenutzergruppe.FormattingEnabled = true;
            this.cbBenutzergruppe.Location = new System.Drawing.Point(661, 97);
            this.cbBenutzergruppe.Name = "cbBenutzergruppe";
            this.cbBenutzergruppe.Size = new System.Drawing.Size(150, 21);
            this.cbBenutzergruppe.TabIndex = 4;
            // 
            // lblAbteilung
            // 
            this.lblAbteilung.AutoSize = true;
            this.lblAbteilung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbteilung.Location = new System.Drawing.Point(492, 164);
            this.lblAbteilung.Name = "lblAbteilung";
            this.lblAbteilung.Size = new System.Drawing.Size(67, 17);
            this.lblAbteilung.TabIndex = 3;
            this.lblAbteilung.Text = "Abteilung";
            this.lblAbteilung.Click += new System.EventHandler(this.lblAbteilung_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(134, 235);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 17);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNachname.Location = new System.Drawing.Point(131, 99);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(76, 17);
            this.lblNachname.TabIndex = 1;
            this.lblNachname.Text = "Nachname";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVorname.Location = new System.Drawing.Point(131, 29);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(65, 17);
            this.lblVorname.TabIndex = 0;
            this.lblVorname.Text = "Vorname";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 381);
            this.Controls.Add(this.gb_change);
            this.Controls.Add(this.gb_Load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUser";
            this.Text = "FrmUserRights";
            this.gb_Load.ResumeLayout(false);
            this.gb_Load.PerformLayout();
            this.gb_change.ResumeLayout(false);
            this.gb_change.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Load;
        private System.Windows.Forms.Button btnUserLoad;
        private System.Windows.Forms.TextBox txtUsernameLoad;
        private System.Windows.Forms.GroupBox gb_change;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cbAbteilung;
        private System.Windows.Forms.Label lblBenutzergruppe;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbBenutzergruppe;
        private System.Windows.Forms.Label lblAbteilung;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblErrorText;
        private System.Windows.Forms.Label lblUsernameLoad;
        private System.Windows.Forms.MaskedTextBox mtbPassword;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
    }
}
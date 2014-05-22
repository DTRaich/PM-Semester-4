namespace Supernova.Sub_Forms.Administration
{
    partial class FrmDepartmentSpecifikation
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
            this.txtDepartmentChef = new System.Windows.Forms.TextBox();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.lblDepartmentChef = new System.Windows.Forms.Label();
            this.lblBudget1 = new System.Windows.Forms.Label();
            this.lblBudget2 = new System.Windows.Forms.Label();
            this.lblBudget3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gpLoad = new System.Windows.Forms.GroupBox();
            this.btnloadDepartment = new System.Windows.Forms.Button();
            this.gpDetails = new System.Windows.Forms.GroupBox();
            this.gpCreate = new System.Windows.Forms.GroupBox();
            this.btnNewDep = new System.Windows.Forms.Button();
            this.btnDeleteDep = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMT1 = new System.Windows.Forms.Label();
            this.mtbBudget3 = new System.Windows.Forms.MaskedTextBox();
            this.mtbBudget2 = new System.Windows.Forms.MaskedTextBox();
            this.mtbBudget1 = new System.Windows.Forms.MaskedTextBox();
            this.gpLoad.SuspendLayout();
            this.gpDetails.SuspendLayout();
            this.gpCreate.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDepartmentChef
            // 
            this.txtDepartmentChef.Location = new System.Drawing.Point(448, 27);
            this.txtDepartmentChef.Name = "txtDepartmentChef";
            this.txtDepartmentChef.ReadOnly = true;
            this.txtDepartmentChef.Size = new System.Drawing.Size(146, 20);
            this.txtDepartmentChef.TabIndex = 0;
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(448, 32);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(146, 21);
            this.cbDepartments.TabIndex = 2;
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartments.Location = new System.Drawing.Point(237, 33);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(109, 17);
            this.lblDepartments.TabIndex = 5;
            this.lblDepartments.Text = "Abteilungsname";
            // 
            // lblDepartmentChef
            // 
            this.lblDepartmentChef.AutoSize = true;
            this.lblDepartmentChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentChef.Location = new System.Drawing.Point(237, 28);
            this.lblDepartmentChef.Name = "lblDepartmentChef";
            this.lblDepartmentChef.Size = new System.Drawing.Size(105, 17);
            this.lblDepartmentChef.TabIndex = 6;
            this.lblDepartmentChef.Text = "Abteilungsleiter";
            // 
            // lblBudget1
            // 
            this.lblBudget1.AutoSize = true;
            this.lblBudget1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget1.Location = new System.Drawing.Point(237, 85);
            this.lblBudget1.Name = "lblBudget1";
            this.lblBudget1.Size = new System.Drawing.Size(175, 17);
            this.lblBudget1.TabIndex = 7;
            this.lblBudget1.Text = "Abteilungskapazität Jahr 1";
            // 
            // lblBudget2
            // 
            this.lblBudget2.AutoSize = true;
            this.lblBudget2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget2.Location = new System.Drawing.Point(237, 135);
            this.lblBudget2.Name = "lblBudget2";
            this.lblBudget2.Size = new System.Drawing.Size(175, 17);
            this.lblBudget2.TabIndex = 8;
            this.lblBudget2.Text = "Abteilungskapazität Jahr 2";
            // 
            // lblBudget3
            // 
            this.lblBudget3.AutoSize = true;
            this.lblBudget3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget3.Location = new System.Drawing.Point(237, 189);
            this.lblBudget3.Name = "lblBudget3";
            this.lblBudget3.Size = new System.Drawing.Size(175, 17);
            this.lblBudget3.TabIndex = 9;
            this.lblBudget3.Text = "Abteilungskapazität Jahr 3";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(447, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(312, 237);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 33);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Verwerfen";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gpLoad
            // 
            this.gpLoad.Controls.Add(this.btnloadDepartment);
            this.gpLoad.Controls.Add(this.lblDepartments);
            this.gpLoad.Controls.Add(this.cbDepartments);
            this.gpLoad.Location = new System.Drawing.Point(12, 3);
            this.gpLoad.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.gpLoad.Name = "gpLoad";
            this.gpLoad.Size = new System.Drawing.Size(920, 71);
            this.gpLoad.TabIndex = 12;
            this.gpLoad.TabStop = false;
            // 
            // btnloadDepartment
            // 
            this.btnloadDepartment.Location = new System.Drawing.Point(635, 33);
            this.btnloadDepartment.Name = "btnloadDepartment";
            this.btnloadDepartment.Size = new System.Drawing.Size(112, 23);
            this.btnloadDepartment.TabIndex = 6;
            this.btnloadDepartment.Text = "Abteilung laden";
            this.btnloadDepartment.UseVisualStyleBackColor = true;
            this.btnloadDepartment.Click += new System.EventHandler(this.btnloadDepartment_Click);
            // 
            // gpDetails
            // 
            this.gpDetails.Controls.Add(this.gpCreate);
            this.gpDetails.Controls.Add(this.label2);
            this.gpDetails.Controls.Add(this.label1);
            this.gpDetails.Controls.Add(this.lblMT1);
            this.gpDetails.Controls.Add(this.mtbBudget3);
            this.gpDetails.Controls.Add(this.mtbBudget2);
            this.gpDetails.Controls.Add(this.mtbBudget1);
            this.gpDetails.Controls.Add(this.lblDepartmentChef);
            this.gpDetails.Controls.Add(this.txtDepartmentChef);
            this.gpDetails.Controls.Add(this.btnReset);
            this.gpDetails.Controls.Add(this.btnSave);
            this.gpDetails.Controls.Add(this.lblBudget3);
            this.gpDetails.Controls.Add(this.lblBudget2);
            this.gpDetails.Controls.Add(this.lblBudget1);
            this.gpDetails.Location = new System.Drawing.Point(12, 80);
            this.gpDetails.Name = "gpDetails";
            this.gpDetails.Size = new System.Drawing.Size(920, 297);
            this.gpDetails.TabIndex = 13;
            this.gpDetails.TabStop = false;
            // 
            // gpCreate
            // 
            this.gpCreate.Controls.Add(this.btnNewDep);
            this.gpCreate.Controls.Add(this.btnDeleteDep);
            this.gpCreate.Location = new System.Drawing.Point(645, 20);
            this.gpCreate.Name = "gpCreate";
            this.gpCreate.Size = new System.Drawing.Size(261, 269);
            this.gpCreate.TabIndex = 20;
            this.gpCreate.TabStop = false;
            this.gpCreate.Text = "Verwaltung";
            // 
            // btnNewDep
            // 
            this.btnNewDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewDep.Location = new System.Drawing.Point(43, 65);
            this.btnNewDep.Name = "btnNewDep";
            this.btnNewDep.Size = new System.Drawing.Size(187, 46);
            this.btnNewDep.TabIndex = 18;
            this.btnNewDep.Text = "Neue Abteilung erstellen";
            this.btnNewDep.UseVisualStyleBackColor = true;
            this.btnNewDep.Click += new System.EventHandler(this.btnNewDep_Click);
            // 
            // btnDeleteDep
            // 
            this.btnDeleteDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDep.Location = new System.Drawing.Point(43, 140);
            this.btnDeleteDep.Name = "btnDeleteDep";
            this.btnDeleteDep.Size = new System.Drawing.Size(187, 46);
            this.btnDeleteDep.TabIndex = 19;
            this.btnDeleteDep.Text = "Diese Abteilung löschen";
            this.btnDeleteDep.UseVisualStyleBackColor = true;
            this.btnDeleteDep.Click += new System.EventHandler(this.btnDeleteDep_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(509, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "in MT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "in MT";
            // 
            // lblMT1
            // 
            this.lblMT1.AutoSize = true;
            this.lblMT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMT1.Location = new System.Drawing.Point(509, 85);
            this.lblMT1.Name = "lblMT1";
            this.lblMT1.Size = new System.Drawing.Size(43, 17);
            this.lblMT1.TabIndex = 15;
            this.lblMT1.Text = "in MT";
            // 
            // mtbBudget3
            // 
            this.mtbBudget3.Location = new System.Drawing.Point(448, 188);
            this.mtbBudget3.Mask = "00000000";
            this.mtbBudget3.Name = "mtbBudget3";
            this.mtbBudget3.Size = new System.Drawing.Size(55, 20);
            this.mtbBudget3.TabIndex = 14;
            this.mtbBudget3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbBudget2
            // 
            this.mtbBudget2.Location = new System.Drawing.Point(448, 134);
            this.mtbBudget2.Mask = "00000000";
            this.mtbBudget2.Name = "mtbBudget2";
            this.mtbBudget2.Size = new System.Drawing.Size(55, 20);
            this.mtbBudget2.TabIndex = 13;
            this.mtbBudget2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // mtbBudget1
            // 
            this.mtbBudget1.Location = new System.Drawing.Point(448, 84);
            this.mtbBudget1.Mask = "00000000";
            this.mtbBudget1.Name = "mtbBudget1";
            this.mtbBudget1.Size = new System.Drawing.Size(55, 20);
            this.mtbBudget1.TabIndex = 12;
            this.mtbBudget1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FrmDepartmentSpecifikation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 381);
            this.Controls.Add(this.gpDetails);
            this.Controls.Add(this.gpLoad);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepartmentSpecifikation";
            this.Text = "FrmDepartmentSpecifikation";
            this.gpLoad.ResumeLayout(false);
            this.gpLoad.PerformLayout();
            this.gpDetails.ResumeLayout(false);
            this.gpDetails.PerformLayout();
            this.gpCreate.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartmentChef;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.Label lblDepartmentChef;
        private System.Windows.Forms.Label lblBudget1;
        private System.Windows.Forms.Label lblBudget2;
        private System.Windows.Forms.Label lblBudget3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gpLoad;
        private System.Windows.Forms.GroupBox gpDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMT1;
        private System.Windows.Forms.MaskedTextBox mtbBudget3;
        private System.Windows.Forms.MaskedTextBox mtbBudget2;
        private System.Windows.Forms.MaskedTextBox mtbBudget1;
        private System.Windows.Forms.Button btnloadDepartment;
        private System.Windows.Forms.Button btnNewDep;
        private System.Windows.Forms.Button btnDeleteDep;
        private System.Windows.Forms.GroupBox gpCreate;

    }
}
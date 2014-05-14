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
            this.txtBudget1 = new System.Windows.Forms.TextBox();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.txtBudget2 = new System.Windows.Forms.TextBox();
            this.txtBudget3 = new System.Windows.Forms.TextBox();
            this.lblDepartments = new System.Windows.Forms.Label();
            this.lblDepartmentChef = new System.Windows.Forms.Label();
            this.lblBudget1 = new System.Windows.Forms.Label();
            this.lblBudget2 = new System.Windows.Forms.Label();
            this.lblBudget3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.gpLoad = new System.Windows.Forms.GroupBox();
            this.gpDetails = new System.Windows.Forms.GroupBox();
            this.gpLoad.SuspendLayout();
            this.gpDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDepartmentChef
            // 
            this.txtDepartmentChef.Location = new System.Drawing.Point(448, 26);
            this.txtDepartmentChef.Name = "txtDepartmentChef";
            this.txtDepartmentChef.Size = new System.Drawing.Size(146, 20);
            this.txtDepartmentChef.TabIndex = 0;
            // 
            // txtBudget1
            // 
            this.txtBudget1.Location = new System.Drawing.Point(448, 83);
            this.txtBudget1.Name = "txtBudget1";
            this.txtBudget1.Size = new System.Drawing.Size(146, 20);
            this.txtBudget1.TabIndex = 1;
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(448, 32);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(146, 21);
            this.cbDepartments.TabIndex = 2;
            // 
            // txtBudget2
            // 
            this.txtBudget2.Location = new System.Drawing.Point(448, 133);
            this.txtBudget2.Name = "txtBudget2";
            this.txtBudget2.Size = new System.Drawing.Size(146, 20);
            this.txtBudget2.TabIndex = 3;
            // 
            // txtBudget3
            // 
            this.txtBudget3.Location = new System.Drawing.Point(448, 187);
            this.txtBudget3.Name = "txtBudget3";
            this.txtBudget3.Size = new System.Drawing.Size(146, 20);
            this.txtBudget3.TabIndex = 4;
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
            this.lblDepartmentChef.Location = new System.Drawing.Point(237, 27);
            this.lblDepartmentChef.Name = "lblDepartmentChef";
            this.lblDepartmentChef.Size = new System.Drawing.Size(105, 17);
            this.lblDepartmentChef.TabIndex = 6;
            this.lblDepartmentChef.Text = "Abteilungsleiter";
            // 
            // lblBudget1
            // 
            this.lblBudget1.AutoSize = true;
            this.lblBudget1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget1.Location = new System.Drawing.Point(237, 84);
            this.lblBudget1.Name = "lblBudget1";
            this.lblBudget1.Size = new System.Drawing.Size(175, 17);
            this.lblBudget1.TabIndex = 7;
            this.lblBudget1.Text = "Abteilungskapazität Jahr 1";
            // 
            // lblBudget2
            // 
            this.lblBudget2.AutoSize = true;
            this.lblBudget2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget2.Location = new System.Drawing.Point(237, 134);
            this.lblBudget2.Name = "lblBudget2";
            this.lblBudget2.Size = new System.Drawing.Size(175, 17);
            this.lblBudget2.TabIndex = 8;
            this.lblBudget2.Text = "Abteilungskapazität Jahr 2";
            // 
            // lblBudget3
            // 
            this.lblBudget3.AutoSize = true;
            this.lblBudget3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget3.Location = new System.Drawing.Point(237, 188);
            this.lblBudget3.Name = "lblBudget3";
            this.lblBudget3.Size = new System.Drawing.Size(175, 17);
            this.lblBudget3.TabIndex = 9;
            this.lblBudget3.Text = "Abteilungskapazität Jahr 3";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(448, 237);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(287, 237);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 33);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Verwerfen";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // gpLoad
            // 
            this.gpLoad.Controls.Add(this.lblDepartments);
            this.gpLoad.Controls.Add(this.cbDepartments);
            this.gpLoad.Location = new System.Drawing.Point(12, 3);
            this.gpLoad.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.gpLoad.Name = "gpLoad";
            this.gpLoad.Size = new System.Drawing.Size(920, 71);
            this.gpLoad.TabIndex = 12;
            this.gpLoad.TabStop = false;
            // 
            // gpDetails
            // 
            this.gpDetails.Controls.Add(this.lblDepartmentChef);
            this.gpDetails.Controls.Add(this.txtDepartmentChef);
            this.gpDetails.Controls.Add(this.btnReset);
            this.gpDetails.Controls.Add(this.txtBudget1);
            this.gpDetails.Controls.Add(this.btnSave);
            this.gpDetails.Controls.Add(this.txtBudget2);
            this.gpDetails.Controls.Add(this.lblBudget3);
            this.gpDetails.Controls.Add(this.txtBudget3);
            this.gpDetails.Controls.Add(this.lblBudget2);
            this.gpDetails.Controls.Add(this.lblBudget1);
            this.gpDetails.Location = new System.Drawing.Point(12, 80);
            this.gpDetails.Name = "gpDetails";
            this.gpDetails.Size = new System.Drawing.Size(920, 297);
            this.gpDetails.TabIndex = 13;
            this.gpDetails.TabStop = false;
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartmentChef;
        private System.Windows.Forms.TextBox txtBudget1;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.TextBox txtBudget2;
        private System.Windows.Forms.TextBox txtBudget3;
        private System.Windows.Forms.Label lblDepartments;
        private System.Windows.Forms.Label lblDepartmentChef;
        private System.Windows.Forms.Label lblBudget1;
        private System.Windows.Forms.Label lblBudget2;
        private System.Windows.Forms.Label lblBudget3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox gpLoad;
        private System.Windows.Forms.GroupBox gpDetails;

    }
}
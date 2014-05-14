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
            this.SuspendLayout();
            // 
            // txtDepartmentChef
            // 
            this.txtDepartmentChef.Location = new System.Drawing.Point(460, 125);
            this.txtDepartmentChef.Name = "txtDepartmentChef";
            this.txtDepartmentChef.Size = new System.Drawing.Size(146, 20);
            this.txtDepartmentChef.TabIndex = 0;
            // 
            // txtBudget1
            // 
            this.txtBudget1.Location = new System.Drawing.Point(460, 164);
            this.txtBudget1.Name = "txtBudget1";
            this.txtBudget1.Size = new System.Drawing.Size(146, 20);
            this.txtBudget1.TabIndex = 1;
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(460, 90);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(146, 21);
            this.cbDepartments.TabIndex = 2;
            // 
            // txtBudget2
            // 
            this.txtBudget2.Location = new System.Drawing.Point(460, 200);
            this.txtBudget2.Name = "txtBudget2";
            this.txtBudget2.Size = new System.Drawing.Size(146, 20);
            this.txtBudget2.TabIndex = 3;
            // 
            // txtBudget3
            // 
            this.txtBudget3.Location = new System.Drawing.Point(460, 237);
            this.txtBudget3.Name = "txtBudget3";
            this.txtBudget3.Size = new System.Drawing.Size(146, 20);
            this.txtBudget3.TabIndex = 4;
            // 
            // lblDepartments
            // 
            this.lblDepartments.AutoSize = true;
            this.lblDepartments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartments.Location = new System.Drawing.Point(249, 91);
            this.lblDepartments.Name = "lblDepartments";
            this.lblDepartments.Size = new System.Drawing.Size(109, 17);
            this.lblDepartments.TabIndex = 5;
            this.lblDepartments.Text = "Abteilungsname";
            // 
            // lblDepartmentChef
            // 
            this.lblDepartmentChef.AutoSize = true;
            this.lblDepartmentChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartmentChef.Location = new System.Drawing.Point(249, 126);
            this.lblDepartmentChef.Name = "lblDepartmentChef";
            this.lblDepartmentChef.Size = new System.Drawing.Size(105, 17);
            this.lblDepartmentChef.TabIndex = 6;
            this.lblDepartmentChef.Text = "Abteilungsleiter";
            // 
            // lblBudget1
            // 
            this.lblBudget1.AutoSize = true;
            this.lblBudget1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget1.Location = new System.Drawing.Point(249, 165);
            this.lblBudget1.Name = "lblBudget1";
            this.lblBudget1.Size = new System.Drawing.Size(175, 17);
            this.lblBudget1.TabIndex = 7;
            this.lblBudget1.Text = "Abteilungskapazität Jahr 1";
            // 
            // lblBudget2
            // 
            this.lblBudget2.AutoSize = true;
            this.lblBudget2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget2.Location = new System.Drawing.Point(249, 201);
            this.lblBudget2.Name = "lblBudget2";
            this.lblBudget2.Size = new System.Drawing.Size(175, 17);
            this.lblBudget2.TabIndex = 8;
            this.lblBudget2.Text = "Abteilungskapazität Jahr 2";
            // 
            // lblBudget3
            // 
            this.lblBudget3.AutoSize = true;
            this.lblBudget3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget3.Location = new System.Drawing.Point(249, 238);
            this.lblBudget3.Name = "lblBudget3";
            this.lblBudget3.Size = new System.Drawing.Size(175, 17);
            this.lblBudget3.TabIndex = 9;
            this.lblBudget3.Text = "Abteilungskapazität Jahr 3";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(460, 300);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 33);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Speichern";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(299, 300);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 33);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Verwerfen";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FrmDepartmentSpecifikation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 381);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblBudget3);
            this.Controls.Add(this.lblBudget2);
            this.Controls.Add(this.lblBudget1);
            this.Controls.Add(this.lblDepartmentChef);
            this.Controls.Add(this.lblDepartments);
            this.Controls.Add(this.txtBudget3);
            this.Controls.Add(this.txtBudget2);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.txtBudget1);
            this.Controls.Add(this.txtDepartmentChef);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDepartmentSpecifikation";
            this.Text = "FrmDepartmentSpecifikation";
            this.ResumeLayout(false);
            this.PerformLayout();

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

    }
}
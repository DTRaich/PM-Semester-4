namespace Supernova.Sub_Forms.Administration
{
    partial class FrmCriteriaWeight
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbactive = new System.Windows.Forms.GroupBox();
            this.btnSaveActive = new System.Windows.Forms.Button();
            this.activationGrid = new System.Windows.Forms.DataGridView();
            this.gbweight = new System.Windows.Forms.GroupBox();
            this.weightGrid = new System.Windows.Forms.DataGridView();
            this.btnSaveWeight = new System.Windows.Forms.Button();
            this.btnDiscardActive = new System.Windows.Forms.Button();
            this.btnDiscardWeight = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbactive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.activationGrid)).BeginInit();
            this.gbweight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weightGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.gbactive, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbweight, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(945, 381);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbactive
            // 
            this.gbactive.Controls.Add(this.btnDiscardActive);
            this.gbactive.Controls.Add(this.btnSaveActive);
            this.gbactive.Controls.Add(this.activationGrid);
            this.gbactive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbactive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbactive.Location = new System.Drawing.Point(3, 25);
            this.gbactive.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.gbactive.Name = "gbactive";
            this.gbactive.Size = new System.Drawing.Size(264, 353);
            this.gbactive.TabIndex = 0;
            this.gbactive.TabStop = false;
            this.gbactive.Text = "Kriterienaktivierung";
            // 
            // btnSaveActive
            // 
            this.btnSaveActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveActive.Location = new System.Drawing.Point(183, 321);
            this.btnSaveActive.Name = "btnSaveActive";
            this.btnSaveActive.Size = new System.Drawing.Size(75, 23);
            this.btnSaveActive.TabIndex = 1;
            this.btnSaveActive.Text = "Speichern";
            this.btnSaveActive.UseVisualStyleBackColor = true;
            this.btnSaveActive.Click += new System.EventHandler(this.button1_Click);
            // 
            // activationGrid
            // 
            this.activationGrid.AllowUserToAddRows = false;
            this.activationGrid.AllowUserToDeleteRows = false;
            this.activationGrid.AllowUserToOrderColumns = true;
            this.activationGrid.AllowUserToResizeColumns = false;
            this.activationGrid.AllowUserToResizeRows = false;
            this.activationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.activationGrid.Location = new System.Drawing.Point(9, 19);
            this.activationGrid.Name = "activationGrid";
            this.activationGrid.Size = new System.Drawing.Size(249, 296);
            this.activationGrid.TabIndex = 0;
            // 
            // gbweight
            // 
            this.gbweight.Controls.Add(this.btnDiscardWeight);
            this.gbweight.Controls.Add(this.btnSaveWeight);
            this.gbweight.Controls.Add(this.weightGrid);
            this.gbweight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbweight.Location = new System.Drawing.Point(273, 25);
            this.gbweight.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.gbweight.Name = "gbweight";
            this.gbweight.Size = new System.Drawing.Size(669, 353);
            this.gbweight.TabIndex = 1;
            this.gbweight.TabStop = false;
            this.gbweight.Text = "Kriteriengewichtung";
            // 
            // weightGrid
            // 
            this.weightGrid.AllowUserToAddRows = false;
            this.weightGrid.AllowUserToDeleteRows = false;
            this.weightGrid.AllowUserToOrderColumns = true;
            this.weightGrid.AllowUserToResizeColumns = false;
            this.weightGrid.AllowUserToResizeRows = false;
            this.weightGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weightGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.weightGrid.Location = new System.Drawing.Point(3, 17);
            this.weightGrid.Name = "weightGrid";
            this.weightGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.weightGrid.Size = new System.Drawing.Size(663, 299);
            this.weightGrid.TabIndex = 0;
            this.weightGrid.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.weightGrid_EditingControlShowing);
            this.weightGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.weightGrid_KeyPress);
            // 
            // btnSaveWeight
            // 
            this.btnSaveWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveWeight.Location = new System.Drawing.Point(588, 321);
            this.btnSaveWeight.Name = "btnSaveWeight";
            this.btnSaveWeight.Size = new System.Drawing.Size(75, 23);
            this.btnSaveWeight.TabIndex = 1;
            this.btnSaveWeight.Text = "Speichern";
            this.btnSaveWeight.UseVisualStyleBackColor = true;
            this.btnSaveWeight.Click += new System.EventHandler(this.btnSaveWeight_Click);
            // 
            // btnDiscardActive
            // 
            this.btnDiscardActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscardActive.Location = new System.Drawing.Point(9, 324);
            this.btnDiscardActive.Name = "btnDiscardActive";
            this.btnDiscardActive.Size = new System.Drawing.Size(75, 23);
            this.btnDiscardActive.TabIndex = 2;
            this.btnDiscardActive.Text = "Verwerfen";
            this.btnDiscardActive.UseVisualStyleBackColor = true;
            this.btnDiscardActive.Click += new System.EventHandler(this.btnDiscardActive_Click);
            // 
            // btnDiscardWeight
            // 
            this.btnDiscardWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiscardWeight.Location = new System.Drawing.Point(6, 324);
            this.btnDiscardWeight.Name = "btnDiscardWeight";
            this.btnDiscardWeight.Size = new System.Drawing.Size(75, 23);
            this.btnDiscardWeight.TabIndex = 2;
            this.btnDiscardWeight.Text = "Verwerfen";
            this.btnDiscardWeight.UseVisualStyleBackColor = true;
            this.btnDiscardWeight.Click += new System.EventHandler(this.btnDiscardWeight_Click);
            // 
            // FrmCriteriaWeight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCriteriaWeight";
            this.Text = "CriteriaWeight";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmCriteriaWeight_KeyPress);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbactive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.activationGrid)).EndInit();
            this.gbweight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.weightGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbactive;
        private System.Windows.Forms.GroupBox gbweight;
        private System.Windows.Forms.DataGridView activationGrid;
        private System.Windows.Forms.Button btnSaveActive;
        private System.Windows.Forms.DataGridView weightGrid;
        private System.Windows.Forms.Button btnDiscardActive;
        private System.Windows.Forms.Button btnSaveWeight;
        private System.Windows.Forms.Button btnDiscardWeight;

    }
}
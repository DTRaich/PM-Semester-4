namespace Supernova.Sub_Forms.Administration.Schnitstellen
{
    partial class FrmWeiserRieseMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvExternStruct = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvExtern = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.cbConnector = new System.Windows.Forms.ComboBox();
            this.Operant = new System.Windows.Forms.Label();
            this.txtvalue2 = new System.Windows.Forms.TextBox();
            this.txtcolumn2 = new System.Windows.Forms.TextBox();
            this.cbOperant2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtvalue1 = new System.Windows.Forms.TextBox();
            this.cbOperant1 = new System.Windows.Forms.ComboBox();
            this.txtcolumn1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTabelle = new System.Windows.Forms.TextBox();
            this.txtConnect = new System.Windows.Forms.TextBox();
            this.lblDone = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.cbDBTYPE = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDBTYP = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvWeiserRieseStruct = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvWeiserRieseInhalt = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDiscardSettings = new System.Windows.Forms.Button();
            this.btnGetAViewData = new System.Windows.Forms.Button();
            this.btnGetStructAndWholetable = new System.Windows.Forms.Button();
            this.btnStruct = new System.Windows.Forms.Button();
            this.cbOriginTable = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExternStruct)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtern)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeiserRieseStruct)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeiserRieseInhalt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(985, 541);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 535);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 250);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 282);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvExternStruct);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(462, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Struktur";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvExternStruct
            // 
            this.dgvExternStruct.AllowUserToAddRows = false;
            this.dgvExternStruct.AllowUserToDeleteRows = false;
            this.dgvExternStruct.AllowUserToOrderColumns = true;
            this.dgvExternStruct.AllowUserToResizeColumns = false;
            this.dgvExternStruct.AllowUserToResizeRows = false;
            this.dgvExternStruct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExternStruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExternStruct.Location = new System.Drawing.Point(3, 3);
            this.dgvExternStruct.MultiSelect = false;
            this.dgvExternStruct.Name = "dgvExternStruct";
            this.dgvExternStruct.ReadOnly = true;
            this.dgvExternStruct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvExternStruct.Size = new System.Drawing.Size(456, 250);
            this.dgvExternStruct.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvExtern);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Inhalt";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvExtern
            // 
            this.dgvExtern.AllowUserToAddRows = false;
            this.dgvExtern.AllowUserToDeleteRows = false;
            this.dgvExtern.AllowUserToOrderColumns = true;
            this.dgvExtern.AllowUserToResizeColumns = false;
            this.dgvExtern.AllowUserToResizeRows = false;
            this.dgvExtern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExtern.Location = new System.Drawing.Point(3, 3);
            this.dgvExtern.MultiSelect = false;
            this.dgvExtern.Name = "dgvExtern";
            this.dgvExtern.ReadOnly = true;
            this.dgvExtern.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvExtern.Size = new System.Drawing.Size(456, 250);
            this.dgvExtern.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.cbConnector);
            this.groupBox1.Controls.Add(this.Operant);
            this.groupBox1.Controls.Add(this.txtvalue2);
            this.groupBox1.Controls.Add(this.txtcolumn2);
            this.groupBox1.Controls.Add(this.cbOperant2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtvalue1);
            this.groupBox1.Controls.Add(this.cbOperant1);
            this.groupBox1.Controls.Add(this.txtcolumn1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTabelle);
            this.groupBox1.Controls.Add(this.txtConnect);
            this.groupBox1.Controls.Add(this.lblDone);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Controls.Add(this.cbDBTYPE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblDBTYP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SetUp";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(6, 201);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 26);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Verwerfen";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(344, 201);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(126, 29);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Anzeigen";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // cbConnector
            // 
            this.cbConnector.FormattingEnabled = true;
            this.cbConnector.Location = new System.Drawing.Point(134, 144);
            this.cbConnector.Name = "cbConnector";
            this.cbConnector.Size = new System.Drawing.Size(117, 24);
            this.cbConnector.TabIndex = 18;
            // 
            // Operant
            // 
            this.Operant.AutoSize = true;
            this.Operant.Location = new System.Drawing.Point(7, 147);
            this.Operant.Name = "Operant";
            this.Operant.Size = new System.Drawing.Size(60, 17);
            this.Operant.TabIndex = 17;
            this.Operant.Text = "Operant";
            // 
            // txtvalue2
            // 
            this.txtvalue2.Location = new System.Drawing.Point(390, 172);
            this.txtvalue2.Name = "txtvalue2";
            this.txtvalue2.Size = new System.Drawing.Size(63, 23);
            this.txtvalue2.TabIndex = 16;
            // 
            // txtcolumn2
            // 
            this.txtcolumn2.Location = new System.Drawing.Point(134, 172);
            this.txtcolumn2.Name = "txtcolumn2";
            this.txtcolumn2.Size = new System.Drawing.Size(117, 23);
            this.txtcolumn2.TabIndex = 15;
            // 
            // cbOperant2
            // 
            this.cbOperant2.FormattingEnabled = true;
            this.cbOperant2.Location = new System.Drawing.Point(258, 172);
            this.cbOperant2.Name = "cbOperant2";
            this.cbOperant2.Size = new System.Drawing.Size(115, 24);
            this.cbOperant2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Filter Krit. 2";
            // 
            // txtvalue1
            // 
            this.txtvalue1.Location = new System.Drawing.Point(390, 116);
            this.txtvalue1.Name = "txtvalue1";
            this.txtvalue1.Size = new System.Drawing.Size(63, 23);
            this.txtvalue1.TabIndex = 12;
            // 
            // cbOperant1
            // 
            this.cbOperant1.FormattingEnabled = true;
            this.cbOperant1.Location = new System.Drawing.Point(257, 116);
            this.cbOperant1.Name = "cbOperant1";
            this.cbOperant1.Size = new System.Drawing.Size(116, 24);
            this.cbOperant1.TabIndex = 11;
            // 
            // txtcolumn1
            // 
            this.txtcolumn1.Location = new System.Drawing.Point(134, 116);
            this.txtcolumn1.Name = "txtcolumn1";
            this.txtcolumn1.Size = new System.Drawing.Size(117, 23);
            this.txtcolumn1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Filter Krit. 1";
            // 
            // txtTabelle
            // 
            this.txtTabelle.Location = new System.Drawing.Point(134, 88);
            this.txtTabelle.Name = "txtTabelle";
            this.txtTabelle.Size = new System.Drawing.Size(117, 23);
            this.txtTabelle.TabIndex = 8;
            this.txtTabelle.Text = "USER_DEMO_A";
            // 
            // txtConnect
            // 
            this.txtConnect.Location = new System.Drawing.Point(134, 61);
            this.txtConnect.Name = "txtConnect";
            this.txtConnect.Size = new System.Drawing.Size(334, 23);
            this.txtConnect.TabIndex = 7;
            this.txtConnect.Text = "Database=DEMO_RIESE;Data Source=188.226.215.238;User Id=user1;Password=password";
            this.txtConnect.TextChanged += new System.EventHandler(this.txtConnect_TextChanged);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.ForeColor = System.Drawing.Color.Green;
            this.lblDone.Location = new System.Drawing.Point(342, 29);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(76, 17);
            this.lblDone.TabIndex = 6;
            this.lblDone.Text = "Erfolgreich";
            this.lblDone.Visible = false;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(250, 26);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // cbDBTYPE
            // 
            this.cbDBTYPE.FormattingEnabled = true;
            this.cbDBTYPE.Location = new System.Drawing.Point(134, 26);
            this.cbDBTYPE.Name = "cbDBTYPE";
            this.cbDBTYPE.Size = new System.Drawing.Size(92, 24);
            this.cbDBTYPE.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tabelle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connection-String";
            // 
            // lblDBTYP
            // 
            this.lblDBTYP.AutoSize = true;
            this.lblDBTYP.Location = new System.Drawing.Point(7, 29);
            this.lblDBTYP.Name = "lblDBTYP";
            this.lblDBTYP.Size = new System.Drawing.Size(68, 17);
            this.lblDBTYP.TabIndex = 0;
            this.lblDBTYP.Text = "DB-TYPE";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl2);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(495, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 535);
            this.panel2.TabIndex = 1;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(13, 123);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(465, 409);
            this.tabControl2.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvWeiserRieseStruct);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(457, 383);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Struktur";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvWeiserRieseStruct
            // 
            this.dgvWeiserRieseStruct.AllowDrop = true;
            this.dgvWeiserRieseStruct.AllowUserToAddRows = false;
            this.dgvWeiserRieseStruct.AllowUserToDeleteRows = false;
            this.dgvWeiserRieseStruct.AllowUserToResizeColumns = false;
            this.dgvWeiserRieseStruct.AllowUserToResizeRows = false;
            this.dgvWeiserRieseStruct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvWeiserRieseStruct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeiserRieseStruct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWeiserRieseStruct.Location = new System.Drawing.Point(3, 3);
            this.dgvWeiserRieseStruct.MultiSelect = false;
            this.dgvWeiserRieseStruct.Name = "dgvWeiserRieseStruct";
            this.dgvWeiserRieseStruct.Size = new System.Drawing.Size(451, 377);
            this.dgvWeiserRieseStruct.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgvWeiserRieseInhalt);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(457, 383);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Inhalt";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvWeiserRieseInhalt
            // 
            this.dgvWeiserRieseInhalt.AllowDrop = true;
            this.dgvWeiserRieseInhalt.AllowUserToAddRows = false;
            this.dgvWeiserRieseInhalt.AllowUserToDeleteRows = false;
            this.dgvWeiserRieseInhalt.AllowUserToOrderColumns = true;
            this.dgvWeiserRieseInhalt.AllowUserToResizeColumns = false;
            this.dgvWeiserRieseInhalt.AllowUserToResizeRows = false;
            this.dgvWeiserRieseInhalt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeiserRieseInhalt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvWeiserRieseInhalt.Location = new System.Drawing.Point(3, 3);
            this.dgvWeiserRieseInhalt.MultiSelect = false;
            this.dgvWeiserRieseInhalt.Name = "dgvWeiserRieseInhalt";
            this.dgvWeiserRieseInhalt.ReadOnly = true;
            this.dgvWeiserRieseInhalt.Size = new System.Drawing.Size(451, 377);
            this.dgvWeiserRieseInhalt.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDiscardSettings);
            this.groupBox2.Controls.Add(this.btnGetAViewData);
            this.groupBox2.Controls.Add(this.btnGetStructAndWholetable);
            this.groupBox2.Controls.Add(this.btnStruct);
            this.groupBox2.Controls.Add(this.cbOriginTable);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 113);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Referenz";
            // 
            // btnDiscardSettings
            // 
            this.btnDiscardSettings.Location = new System.Drawing.Point(202, 69);
            this.btnDiscardSettings.Name = "btnDiscardSettings";
            this.btnDiscardSettings.Size = new System.Drawing.Size(100, 35);
            this.btnDiscardSettings.TabIndex = 5;
            this.btnDiscardSettings.Text = "Verwerfen";
            this.btnDiscardSettings.UseVisualStyleBackColor = true;
            // 
            // btnGetAViewData
            // 
            this.btnGetAViewData.Location = new System.Drawing.Point(367, 65);
            this.btnGetAViewData.Name = "btnGetAViewData";
            this.btnGetAViewData.Size = new System.Drawing.Size(101, 42);
            this.btnGetAViewData.TabIndex = 4;
            this.btnGetAViewData.Text = "Auswahl Übertragen";
            this.btnGetAViewData.UseVisualStyleBackColor = true;
            // 
            // btnGetStructAndWholetable
            // 
            this.btnGetStructAndWholetable.Location = new System.Drawing.Point(6, 65);
            this.btnGetStructAndWholetable.Name = "btnGetStructAndWholetable";
            this.btnGetStructAndWholetable.Size = new System.Drawing.Size(118, 42);
            this.btnGetStructAndWholetable.TabIndex = 3;
            this.btnGetStructAndWholetable.Text = "Tabelle Übertragen";
            this.btnGetStructAndWholetable.UseVisualStyleBackColor = true;
            this.btnGetStructAndWholetable.Click += new System.EventHandler(this.btnGetNewData_Click);
            // 
            // btnStruct
            // 
            this.btnStruct.Location = new System.Drawing.Point(278, 28);
            this.btnStruct.Name = "btnStruct";
            this.btnStruct.Size = new System.Drawing.Size(132, 23);
            this.btnStruct.TabIndex = 2;
            this.btnStruct.Text = "Struktur Laden";
            this.btnStruct.UseVisualStyleBackColor = true;
            this.btnStruct.Click += new System.EventHandler(this.btnStruct_Click);
            // 
            // cbOriginTable
            // 
            this.cbOriginTable.FormattingEnabled = true;
            this.cbOriginTable.Location = new System.Drawing.Point(94, 28);
            this.cbOriginTable.Name = "cbOriginTable";
            this.cbOriginTable.Size = new System.Drawing.Size(146, 24);
            this.cbOriginTable.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tabelle";
            // 
            // FrmWeiserRieseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 541);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWeiserRieseMain";
            this.Text = "Schnittstelle-Weiser Riese";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExternStruct)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtern)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeiserRieseStruct)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeiserRieseInhalt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDBTYP;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.ComboBox cbDBTYPE;
        private System.Windows.Forms.TextBox txtConnect;
        private System.Windows.Forms.TextBox txtTabelle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtvalue1;
        private System.Windows.Forms.ComboBox cbOperant1;
        private System.Windows.Forms.TextBox txtcolumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtvalue2;
        private System.Windows.Forms.TextBox txtcolumn2;
        private System.Windows.Forms.ComboBox cbOperant2;
        private System.Windows.Forms.ComboBox cbConnector;
        private System.Windows.Forms.Label Operant;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cbOriginTable;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnStruct;
        private System.Windows.Forms.Button btnGetStructAndWholetable;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvExternStruct;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvExtern;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvWeiserRieseStruct;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgvWeiserRieseInhalt;
        private System.Windows.Forms.Button btnDiscardSettings;
        private System.Windows.Forms.Button btnGetAViewData;
    }
}
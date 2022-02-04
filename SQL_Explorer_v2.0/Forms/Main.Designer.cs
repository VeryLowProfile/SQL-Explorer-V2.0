
namespace SQL_Explorer_v2._0
{
    partial class Main
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.connectionPanel = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonImportTable = new System.Windows.Forms.Button();
            this.comboBoxSheetName = new System.Windows.Forms.ComboBox();
            this.labelSheetName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxSelectedFile = new System.Windows.Forms.TextBox();
            this.buttonSelectExcelFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxMode = new System.Windows.Forms.ComboBox();
            this.buttonClearDataGrid = new System.Windows.Forms.Button();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonLoadRefresh = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSelectTable = new System.Windows.Forms.ComboBox();
            this.buttonReadConfig = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxConnString = new System.Windows.Forms.TextBox();
            this.buttonConnection = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxServerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDbName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUserPwd = new System.Windows.Forms.TextBox();
            this.textBoxUserId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewPanel = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.connectionPanel.SuspendLayout();
            this.dataGridViewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // connectionPanel
            // 
            this.connectionPanel.Controls.Add(this.buttonExport);
            this.connectionPanel.Controls.Add(this.buttonImportTable);
            this.connectionPanel.Controls.Add(this.comboBoxSheetName);
            this.connectionPanel.Controls.Add(this.labelSheetName);
            this.connectionPanel.Controls.Add(this.label9);
            this.connectionPanel.Controls.Add(this.textBoxSelectedFile);
            this.connectionPanel.Controls.Add(this.buttonSelectExcelFile);
            this.connectionPanel.Controls.Add(this.label8);
            this.connectionPanel.Controls.Add(this.comboBoxMode);
            this.connectionPanel.Controls.Add(this.buttonClearDataGrid);
            this.connectionPanel.Controls.Add(this.buttonSubmit);
            this.connectionPanel.Controls.Add(this.buttonLoadRefresh);
            this.connectionPanel.Controls.Add(this.label7);
            this.connectionPanel.Controls.Add(this.comboBoxSelectTable);
            this.connectionPanel.Controls.Add(this.buttonReadConfig);
            this.connectionPanel.Controls.Add(this.label6);
            this.connectionPanel.Controls.Add(this.textBoxConnString);
            this.connectionPanel.Controls.Add(this.buttonConnection);
            this.connectionPanel.Controls.Add(this.textBoxIP);
            this.connectionPanel.Controls.Add(this.label1);
            this.connectionPanel.Controls.Add(this.textBoxServerName);
            this.connectionPanel.Controls.Add(this.label2);
            this.connectionPanel.Controls.Add(this.textBoxDbName);
            this.connectionPanel.Controls.Add(this.label5);
            this.connectionPanel.Controls.Add(this.label3);
            this.connectionPanel.Controls.Add(this.textBoxUserPwd);
            this.connectionPanel.Controls.Add(this.textBoxUserId);
            this.connectionPanel.Controls.Add(this.label4);
            this.connectionPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.connectionPanel.Location = new System.Drawing.Point(0, 0);
            this.connectionPanel.Name = "connectionPanel";
            this.connectionPanel.Size = new System.Drawing.Size(286, 771);
            this.connectionPanel.TabIndex = 0;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(12, 733);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(255, 24);
            this.buttonExport.TabIndex = 37;
            this.buttonExport.Text = "Export";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonImportTable
            // 
            this.buttonImportTable.Location = new System.Drawing.Point(13, 602);
            this.buttonImportTable.Name = "buttonImportTable";
            this.buttonImportTable.Size = new System.Drawing.Size(255, 24);
            this.buttonImportTable.TabIndex = 36;
            this.buttonImportTable.Text = "Import Table";
            this.buttonImportTable.UseVisualStyleBackColor = true;
            this.buttonImportTable.Click += new System.EventHandler(this.buttonImportTable_Click);
            // 
            // comboBoxSheetName
            // 
            this.comboBoxSheetName.FormattingEnabled = true;
            this.comboBoxSheetName.Location = new System.Drawing.Point(12, 704);
            this.comboBoxSheetName.Name = "comboBoxSheetName";
            this.comboBoxSheetName.Size = new System.Drawing.Size(254, 21);
            this.comboBoxSheetName.TabIndex = 35;
            // 
            // labelSheetName
            // 
            this.labelSheetName.AutoSize = true;
            this.labelSheetName.Location = new System.Drawing.Point(13, 683);
            this.labelSheetName.Name = "labelSheetName";
            this.labelSheetName.Size = new System.Drawing.Size(63, 13);
            this.labelSheetName.TabIndex = 34;
            this.labelSheetName.Text = "SheetName";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 634);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Selected File";
            // 
            // textBoxSelectedFile
            // 
            this.textBoxSelectedFile.Location = new System.Drawing.Point(12, 655);
            this.textBoxSelectedFile.Name = "textBoxSelectedFile";
            this.textBoxSelectedFile.Size = new System.Drawing.Size(254, 20);
            this.textBoxSelectedFile.TabIndex = 32;
            // 
            // buttonSelectExcelFile
            // 
            this.buttonSelectExcelFile.Location = new System.Drawing.Point(12, 570);
            this.buttonSelectExcelFile.Name = "buttonSelectExcelFile";
            this.buttonSelectExcelFile.Size = new System.Drawing.Size(255, 24);
            this.buttonSelectExcelFile.TabIndex = 31;
            this.buttonSelectExcelFile.Text = "Select File For Table Import";
            this.buttonSelectExcelFile.UseVisualStyleBackColor = true;
            this.buttonSelectExcelFile.Click += new System.EventHandler(this.buttonSelectExcelFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 520);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Select IMPORT/EXPORT format";
            // 
            // comboBoxMode
            // 
            this.comboBoxMode.FormattingEnabled = true;
            this.comboBoxMode.Location = new System.Drawing.Point(13, 541);
            this.comboBoxMode.Name = "comboBoxMode";
            this.comboBoxMode.Size = new System.Drawing.Size(254, 21);
            this.comboBoxMode.TabIndex = 29;
            // 
            // buttonClearDataGrid
            // 
            this.buttonClearDataGrid.Location = new System.Drawing.Point(13, 456);
            this.buttonClearDataGrid.Name = "buttonClearDataGrid";
            this.buttonClearDataGrid.Size = new System.Drawing.Size(255, 24);
            this.buttonClearDataGrid.TabIndex = 28;
            this.buttonClearDataGrid.Text = "Clear Table";
            this.buttonClearDataGrid.UseVisualStyleBackColor = true;
            this.buttonClearDataGrid.Click += new System.EventHandler(this.buttonClearDataGrid_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Image = ((System.Drawing.Image)(resources.GetObject("buttonSubmit.Image")));
            this.buttonSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSubmit.Location = new System.Drawing.Point(13, 488);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(255, 24);
            this.buttonSubmit.TabIndex = 27;
            this.buttonSubmit.Text = "Submit Table Modification To SQL";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonLoadRefresh
            // 
            this.buttonLoadRefresh.Location = new System.Drawing.Point(13, 424);
            this.buttonLoadRefresh.Name = "buttonLoadRefresh";
            this.buttonLoadRefresh.Size = new System.Drawing.Size(255, 24);
            this.buttonLoadRefresh.TabIndex = 26;
            this.buttonLoadRefresh.Text = "Load / Refresh Table";
            this.buttonLoadRefresh.UseVisualStyleBackColor = true;
            this.buttonLoadRefresh.Click += new System.EventHandler(this.buttonLoadRefresh_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Select SQL Table";
            // 
            // comboBoxSelectTable
            // 
            this.comboBoxSelectTable.FormattingEnabled = true;
            this.comboBoxSelectTable.Location = new System.Drawing.Point(13, 395);
            this.comboBoxSelectTable.Name = "comboBoxSelectTable";
            this.comboBoxSelectTable.Size = new System.Drawing.Size(254, 21);
            this.comboBoxSelectTable.TabIndex = 24;
            // 
            // buttonReadConfig
            // 
            this.buttonReadConfig.Location = new System.Drawing.Point(13, 312);
            this.buttonReadConfig.Name = "buttonReadConfig";
            this.buttonReadConfig.Size = new System.Drawing.Size(254, 23);
            this.buttonReadConfig.TabIndex = 23;
            this.buttonReadConfig.Text = "Read Config File";
            this.buttonReadConfig.UseVisualStyleBackColor = true;
            this.buttonReadConfig.Click += new System.EventHandler(this.buttonReadConfig_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Connection String";
            // 
            // textBoxConnString
            // 
            this.textBoxConnString.Location = new System.Drawing.Point(13, 284);
            this.textBoxConnString.Name = "textBoxConnString";
            this.textBoxConnString.Size = new System.Drawing.Size(254, 20);
            this.textBoxConnString.TabIndex = 21;
            // 
            // buttonConnection
            // 
            this.buttonConnection.Location = new System.Drawing.Point(13, 343);
            this.buttonConnection.Name = "buttonConnection";
            this.buttonConnection.Size = new System.Drawing.Size(254, 23);
            this.buttonConnection.TabIndex = 20;
            this.buttonConnection.Text = "Connect";
            this.buttonConnection.UseVisualStyleBackColor = true;
            this.buttonConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(13, 39);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(254, 20);
            this.textBoxIP.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Sql Server IP";
            // 
            // textBoxServerName
            // 
            this.textBoxServerName.Location = new System.Drawing.Point(13, 88);
            this.textBoxServerName.Name = "textBoxServerName";
            this.textBoxServerName.Size = new System.Drawing.Size(254, 20);
            this.textBoxServerName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Sql Server Name";
            // 
            // textBoxDbName
            // 
            this.textBoxDbName.Location = new System.Drawing.Point(13, 137);
            this.textBoxDbName.Name = "textBoxDbName";
            this.textBoxDbName.Size = new System.Drawing.Size(254, 20);
            this.textBoxDbName.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "User PWD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sql Db Name";
            // 
            // textBoxUserPwd
            // 
            this.textBoxUserPwd.Location = new System.Drawing.Point(13, 235);
            this.textBoxUserPwd.Name = "textBoxUserPwd";
            this.textBoxUserPwd.Size = new System.Drawing.Size(254, 20);
            this.textBoxUserPwd.TabIndex = 18;
            // 
            // textBoxUserId
            // 
            this.textBoxUserId.Location = new System.Drawing.Point(13, 186);
            this.textBoxUserId.Name = "textBoxUserId";
            this.textBoxUserId.Size = new System.Drawing.Size(254, 20);
            this.textBoxUserId.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "User ID";
            // 
            // dataGridViewPanel
            // 
            this.dataGridViewPanel.Controls.Add(this.dataGridView);
            this.dataGridViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPanel.Location = new System.Drawing.Point(286, 0);
            this.dataGridViewPanel.Name = "dataGridViewPanel";
            this.dataGridViewPanel.Size = new System.Drawing.Size(655, 771);
            this.dataGridViewPanel.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(6, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(637, 747);
            this.dataGridView.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 771);
            this.Controls.Add(this.dataGridViewPanel);
            this.Controls.Add(this.connectionPanel);
            this.Name = "Main";
            this.Text = "SQL Explorer V2.0";
            this.Load += new System.EventHandler(this.Main_Load);
            this.connectionPanel.ResumeLayout(false);
            this.connectionPanel.PerformLayout();
            this.dataGridViewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel connectionPanel;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxServerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDbName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUserPwd;
        private System.Windows.Forms.TextBox textBoxUserId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonConnection;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxConnString;
        private System.Windows.Forms.Button buttonReadConfig;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxSelectTable;
        private System.Windows.Forms.Button buttonLoadRefresh;
        private System.Windows.Forms.Panel dataGridViewPanel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClearDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxMode;
        private System.Windows.Forms.Button buttonSelectExcelFile;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxSelectedFile;
        private System.Windows.Forms.ComboBox comboBoxSheetName;
        private System.Windows.Forms.Label labelSheetName;
        private System.Windows.Forms.Button buttonImportTable;
        private System.Windows.Forms.Button buttonExport;
    }
}


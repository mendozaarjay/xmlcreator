
namespace XmlCreator
{
    partial class MainForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtTenantId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgPreEOD = new System.Windows.Forms.DataGridView();
            this.dtlPreId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlPreTerminalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlPreTerminal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlPreTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlPreTimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlPreAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlPreDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlExportPreEOD = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgEOD = new System.Windows.Forms.DataGridView();
            this.dtlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTerminalId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlTerminalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlBeginDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtlExport = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPreEOD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEOD)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtTenantId);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtKey);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnBrowse);
            this.splitContainer1.Panel1.Controls.Add(this.txtPath);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(982, 553);
            this.splitContainer1.SplitterDistance = 142;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Path/Xml Destination";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(26, 40);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(847, 30);
            this.txtPath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(879, 38);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(91, 30);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Key";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(69, 84);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(296, 30);
            this.txtKey.TabIndex = 4;
            // 
            // txtTenantId
            // 
            this.txtTenantId.Location = new System.Drawing.Point(577, 84);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.Size = new System.Drawing.Size(296, 30);
            this.txtTenantId.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(494, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tenant Id";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(982, 407);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgPreEOD);
            this.tabPage1.Location = new System.Drawing.Point(4, 32);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(974, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pre End Of Day (Testing)";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgEOD);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(974, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "End Of Day (Testing)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgPreEOD
            // 
            this.dgPreEOD.AllowUserToAddRows = false;
            this.dgPreEOD.AllowUserToDeleteRows = false;
            this.dgPreEOD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgPreEOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPreEOD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlPreId,
            this.dtlPreTerminalId,
            this.dtlPreTerminal,
            this.dtlPreTimeIn,
            this.dtlPreTimeOut,
            this.dtlPreAmount,
            this.dtlPreDiscount,
            this.dtlExportPreEOD});
            this.dgPreEOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgPreEOD.Location = new System.Drawing.Point(3, 3);
            this.dgPreEOD.Name = "dgPreEOD";
            this.dgPreEOD.ReadOnly = true;
            this.dgPreEOD.RowHeadersWidth = 51;
            this.dgPreEOD.RowTemplate.Height = 24;
            this.dgPreEOD.Size = new System.Drawing.Size(968, 365);
            this.dgPreEOD.TabIndex = 0;
            this.dgPreEOD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPreEOD_CellContentClick);
            // 
            // dtlPreId
            // 
            this.dtlPreId.HeaderText = "Id";
            this.dtlPreId.MinimumWidth = 6;
            this.dtlPreId.Name = "dtlPreId";
            this.dtlPreId.ReadOnly = true;
            this.dtlPreId.Width = 125;
            // 
            // dtlPreTerminalId
            // 
            this.dtlPreTerminalId.HeaderText = "Terminal Id";
            this.dtlPreTerminalId.MinimumWidth = 6;
            this.dtlPreTerminalId.Name = "dtlPreTerminalId";
            this.dtlPreTerminalId.ReadOnly = true;
            this.dtlPreTerminalId.Width = 125;
            // 
            // dtlPreTerminal
            // 
            this.dtlPreTerminal.HeaderText = "Terminal";
            this.dtlPreTerminal.MinimumWidth = 6;
            this.dtlPreTerminal.Name = "dtlPreTerminal";
            this.dtlPreTerminal.ReadOnly = true;
            this.dtlPreTerminal.Width = 125;
            // 
            // dtlPreTimeIn
            // 
            this.dtlPreTimeIn.HeaderText = "Time In";
            this.dtlPreTimeIn.MinimumWidth = 6;
            this.dtlPreTimeIn.Name = "dtlPreTimeIn";
            this.dtlPreTimeIn.ReadOnly = true;
            this.dtlPreTimeIn.Width = 125;
            // 
            // dtlPreTimeOut
            // 
            this.dtlPreTimeOut.HeaderText = "Time Out";
            this.dtlPreTimeOut.MinimumWidth = 6;
            this.dtlPreTimeOut.Name = "dtlPreTimeOut";
            this.dtlPreTimeOut.ReadOnly = true;
            this.dtlPreTimeOut.Width = 125;
            // 
            // dtlPreAmount
            // 
            this.dtlPreAmount.HeaderText = "Amount";
            this.dtlPreAmount.MinimumWidth = 6;
            this.dtlPreAmount.Name = "dtlPreAmount";
            this.dtlPreAmount.ReadOnly = true;
            this.dtlPreAmount.Width = 125;
            // 
            // dtlPreDiscount
            // 
            this.dtlPreDiscount.HeaderText = "Discount";
            this.dtlPreDiscount.MinimumWidth = 6;
            this.dtlPreDiscount.Name = "dtlPreDiscount";
            this.dtlPreDiscount.ReadOnly = true;
            this.dtlPreDiscount.Width = 125;
            // 
            // dtlExportPreEOD
            // 
            this.dtlExportPreEOD.HeaderText = "Export";
            this.dtlExportPreEOD.MinimumWidth = 6;
            this.dtlExportPreEOD.Name = "dtlExportPreEOD";
            this.dtlExportPreEOD.ReadOnly = true;
            this.dtlExportPreEOD.Width = 125;
            // 
            // dgEOD
            // 
            this.dgEOD.AllowUserToAddRows = false;
            this.dgEOD.AllowUserToDeleteRows = false;
            this.dgEOD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgEOD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEOD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dtlId,
            this.dtlTerminalId,
            this.dtlTerminalName,
            this.dtlBeginDate,
            this.dtlEndDate,
            this.dtlExport});
            this.dgEOD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgEOD.Location = new System.Drawing.Point(3, 3);
            this.dgEOD.Name = "dgEOD";
            this.dgEOD.ReadOnly = true;
            this.dgEOD.RowHeadersWidth = 51;
            this.dgEOD.RowTemplate.Height = 24;
            this.dgEOD.Size = new System.Drawing.Size(968, 365);
            this.dgEOD.TabIndex = 1;
            this.dgEOD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEOD_CellContentClick);
            // 
            // dtlId
            // 
            this.dtlId.HeaderText = "Id";
            this.dtlId.MinimumWidth = 6;
            this.dtlId.Name = "dtlId";
            this.dtlId.ReadOnly = true;
            this.dtlId.Width = 125;
            // 
            // dtlTerminalId
            // 
            this.dtlTerminalId.HeaderText = "Terminal Id";
            this.dtlTerminalId.MinimumWidth = 6;
            this.dtlTerminalId.Name = "dtlTerminalId";
            this.dtlTerminalId.ReadOnly = true;
            this.dtlTerminalId.Width = 125;
            // 
            // dtlTerminalName
            // 
            this.dtlTerminalName.HeaderText = "Terminal";
            this.dtlTerminalName.MinimumWidth = 6;
            this.dtlTerminalName.Name = "dtlTerminalName";
            this.dtlTerminalName.ReadOnly = true;
            this.dtlTerminalName.Width = 125;
            // 
            // dtlBeginDate
            // 
            this.dtlBeginDate.HeaderText = "Date From";
            this.dtlBeginDate.MinimumWidth = 6;
            this.dtlBeginDate.Name = "dtlBeginDate";
            this.dtlBeginDate.ReadOnly = true;
            this.dtlBeginDate.Width = 125;
            // 
            // dtlEndDate
            // 
            this.dtlEndDate.HeaderText = "Date To";
            this.dtlEndDate.MinimumWidth = 6;
            this.dtlEndDate.Name = "dtlEndDate";
            this.dtlEndDate.ReadOnly = true;
            this.dtlEndDate.Width = 125;
            // 
            // dtlExport
            // 
            this.dtlExport.HeaderText = "Export";
            this.dtlExport.MinimumWidth = 6;
            this.dtlExport.Name = "dtlExport";
            this.dtlExport.ReadOnly = true;
            this.dtlExport.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "Xml Creator (For testing only)";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPreEOD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgEOD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtTenantId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgPreEOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPreId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPreTerminalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPreTerminal;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPreTimeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPreTimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPreAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlPreDiscount;
        private System.Windows.Forms.DataGridViewButtonColumn dtlExportPreEOD;
        private System.Windows.Forms.DataGridView dgEOD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTerminalId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlTerminalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlBeginDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtlEndDate;
        private System.Windows.Forms.DataGridViewButtonColumn dtlExport;
    }
}


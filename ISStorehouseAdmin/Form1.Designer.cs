
namespace ISStorehouseAdmin
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.OpenTab = new System.Windows.Forms.TabPage();
            this.ConnectGroup = new System.Windows.Forms.GroupBox();
            this.ComLbl = new System.Windows.Forms.Label();
            this.PortCmb = new System.Windows.Forms.ComboBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.ScanTab = new System.Windows.Forms.TabPage();
            this.ModulListGroup = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ModulId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrefixId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScanGroup = new System.Windows.Forms.GroupBox();
            this.FirstScanBtn = new System.Windows.Forms.Button();
            this.ToLbl = new System.Windows.Forms.Label();
            this.FranLbl = new System.Windows.Forms.Label();
            this.ToScanCmb = new System.Windows.Forms.ComboBox();
            this.FromScanCmb = new System.Windows.Forms.ComboBox();
            this.GenerateGroup = new System.Windows.Forms.GroupBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.AddPrefixBtn = new System.Windows.Forms.Button();
            this.DiagnoseGroup = new System.Windows.Forms.GroupBox();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.DiagnoseBtn = new System.Windows.Forms.Button();
            this.GroupDiagnoseGroup = new System.Windows.Forms.GroupBox();
            this.DiagModulBtn = new System.Windows.Forms.Label();
            this.ModulCmb = new System.Windows.Forms.ComboBox();
            this.ClearModulBtn = new System.Windows.Forms.Button();
            this.DiagnoseModulBtn = new System.Windows.Forms.Button();
            this.SendTab = new System.Windows.Forms.TabPage();
            this.CellInfoGroup = new System.Windows.Forms.GroupBox();
            this.ScanCellInfoBtn = new System.Windows.Forms.Button();
            this.CellCellInfoLbl = new System.Windows.Forms.Label();
            this.RowCellInfoLbl = new System.Windows.Forms.Label();
            this.ModulCellInfoLbl = new System.Windows.Forms.Label();
            this.CellCellInfoCmb = new System.Windows.Forms.ComboBox();
            this.RowCellInfoCmb = new System.Windows.Forms.ComboBox();
            this.ModulCellInfoCmb = new System.Windows.Forms.ComboBox();
            this.SendSingleGroup = new System.Windows.Forms.GroupBox();
            this.SendSingleBtn = new System.Windows.Forms.Button();
            this.PhysAddressLbl = new System.Windows.Forms.Label();
            this.LedsPerRowSendLbl = new System.Windows.Forms.Label();
            this.Color2SendLbl = new System.Windows.Forms.Label();
            this.EffectSendLbl = new System.Windows.Forms.Label();
            this.Color0SendLbl = new System.Windows.Forms.Label();
            this.PhysAddressTxt = new System.Windows.Forms.TextBox();
            this.LedsPerRowSendSingle = new System.Windows.Forms.TextBox();
            this.Color0SendSingleCmb = new System.Windows.Forms.ComboBox();
            this.EffectSendSingleCmb = new System.Windows.Forms.ComboBox();
            this.Color2SendSingleCmb = new System.Windows.Forms.ComboBox();
            this.Demo2Btn = new System.Windows.Forms.Button();
            this.Demo1Btn = new System.Windows.Forms.Button();
            this.PhysAddreses = new System.Windows.Forms.ListBox();
            this.SendMultipleBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.OpenTab.SuspendLayout();
            this.ConnectGroup.SuspendLayout();
            this.ScanTab.SuspendLayout();
            this.ModulListGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ScanGroup.SuspendLayout();
            this.GenerateGroup.SuspendLayout();
            this.DiagnoseGroup.SuspendLayout();
            this.GroupDiagnoseGroup.SuspendLayout();
            this.SendTab.SuspendLayout();
            this.CellInfoGroup.SuspendLayout();
            this.SendSingleGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.OpenTab);
            this.tabControl1.Controls.Add(this.ScanTab);
            this.tabControl1.Controls.Add(this.SendTab);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 425);
            this.tabControl1.TabIndex = 0;
            // 
            // OpenTab
            // 
            this.OpenTab.Controls.Add(this.ConnectGroup);
            this.OpenTab.Location = new System.Drawing.Point(4, 22);
            this.OpenTab.Name = "OpenTab";
            this.OpenTab.Padding = new System.Windows.Forms.Padding(3);
            this.OpenTab.Size = new System.Drawing.Size(767, 399);
            this.OpenTab.TabIndex = 0;
            this.OpenTab.Text = "Open";
            this.OpenTab.UseVisualStyleBackColor = true;
            // 
            // ConnectGroup
            // 
            this.ConnectGroup.Controls.Add(this.ComLbl);
            this.ConnectGroup.Controls.Add(this.PortCmb);
            this.ConnectGroup.Controls.Add(this.OpenBtn);
            this.ConnectGroup.Location = new System.Drawing.Point(21, 22);
            this.ConnectGroup.Name = "ConnectGroup";
            this.ConnectGroup.Size = new System.Drawing.Size(233, 109);
            this.ConnectGroup.TabIndex = 0;
            this.ConnectGroup.TabStop = false;
            this.ConnectGroup.Text = "Connect";
            // 
            // ComLbl
            // 
            this.ComLbl.AutoSize = true;
            this.ComLbl.Location = new System.Drawing.Point(145, 40);
            this.ComLbl.Name = "ComLbl";
            this.ComLbl.Size = new System.Drawing.Size(31, 13);
            this.ComLbl.TabIndex = 2;
            this.ComLbl.Text = "COM";
            // 
            // PortCmb
            // 
            this.PortCmb.FormattingEnabled = true;
            this.PortCmb.Location = new System.Drawing.Point(17, 33);
            this.PortCmb.Name = "PortCmb";
            this.PortCmb.Size = new System.Drawing.Size(121, 21);
            this.PortCmb.TabIndex = 1;
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(52, 73);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // ScanTab
            // 
            this.ScanTab.Controls.Add(this.ModulListGroup);
            this.ScanTab.Controls.Add(this.ScanGroup);
            this.ScanTab.Controls.Add(this.DiagnoseGroup);
            this.ScanTab.Location = new System.Drawing.Point(4, 22);
            this.ScanTab.Name = "ScanTab";
            this.ScanTab.Padding = new System.Windows.Forms.Padding(3);
            this.ScanTab.Size = new System.Drawing.Size(767, 399);
            this.ScanTab.TabIndex = 1;
            this.ScanTab.Text = "Scan";
            this.ScanTab.UseVisualStyleBackColor = true;
            // 
            // ModulListGroup
            // 
            this.ModulListGroup.Controls.Add(this.dataGridView1);
            this.ModulListGroup.Location = new System.Drawing.Point(287, 22);
            this.ModulListGroup.Name = "ModulListGroup";
            this.ModulListGroup.Size = new System.Drawing.Size(456, 371);
            this.ModulListGroup.TabIndex = 2;
            this.ModulListGroup.TabStop = false;
            this.ModulListGroup.Text = "Modul List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ModulId,
            this.RowId,
            this.CollumnId,
            this.PrefixId});
            this.dataGridView1.Location = new System.Drawing.Point(6, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // ModulId
            // 
            this.ModulId.HeaderText = "Modul";
            this.ModulId.Name = "ModulId";
            // 
            // RowId
            // 
            this.RowId.HeaderText = "Row";
            this.RowId.Name = "RowId";
            // 
            // CollumnId
            // 
            this.CollumnId.HeaderText = "Collumn";
            this.CollumnId.Name = "CollumnId";
            // 
            // PrefixId
            // 
            this.PrefixId.HeaderText = "Prefix";
            this.PrefixId.Name = "PrefixId";
            // 
            // ScanGroup
            // 
            this.ScanGroup.Controls.Add(this.FirstScanBtn);
            this.ScanGroup.Controls.Add(this.ToLbl);
            this.ScanGroup.Controls.Add(this.FranLbl);
            this.ScanGroup.Controls.Add(this.ToScanCmb);
            this.ScanGroup.Controls.Add(this.FromScanCmb);
            this.ScanGroup.Controls.Add(this.GenerateGroup);
            this.ScanGroup.Location = new System.Drawing.Point(23, 237);
            this.ScanGroup.Name = "ScanGroup";
            this.ScanGroup.Size = new System.Drawing.Size(257, 159);
            this.ScanGroup.TabIndex = 1;
            this.ScanGroup.TabStop = false;
            this.ScanGroup.Text = "Scan";
            // 
            // FirstScanBtn
            // 
            this.FirstScanBtn.Location = new System.Drawing.Point(167, 33);
            this.FirstScanBtn.Name = "FirstScanBtn";
            this.FirstScanBtn.Size = new System.Drawing.Size(75, 23);
            this.FirstScanBtn.TabIndex = 5;
            this.FirstScanBtn.Text = "Frist Scan";
            this.FirstScanBtn.UseVisualStyleBackColor = true;
            this.FirstScanBtn.Click += new System.EventHandler(this.FirstScanBtn_Click);
            // 
            // ToLbl
            // 
            this.ToLbl.AutoSize = true;
            this.ToLbl.Location = new System.Drawing.Point(95, 20);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(20, 13);
            this.ToLbl.TabIndex = 4;
            this.ToLbl.Text = "To";
            // 
            // FranLbl
            // 
            this.FranLbl.AutoSize = true;
            this.FranLbl.Location = new System.Drawing.Point(11, 20);
            this.FranLbl.Name = "FranLbl";
            this.FranLbl.Size = new System.Drawing.Size(30, 13);
            this.FranLbl.TabIndex = 3;
            this.FranLbl.Text = "From";
            // 
            // ToScanCmb
            // 
            this.ToScanCmb.FormattingEnabled = true;
            this.ToScanCmb.Location = new System.Drawing.Point(86, 33);
            this.ToScanCmb.Name = "ToScanCmb";
            this.ToScanCmb.Size = new System.Drawing.Size(74, 21);
            this.ToScanCmb.TabIndex = 2;
            // 
            // FromScanCmb
            // 
            this.FromScanCmb.FormattingEnabled = true;
            this.FromScanCmb.Location = new System.Drawing.Point(6, 33);
            this.FromScanCmb.Name = "FromScanCmb";
            this.FromScanCmb.Size = new System.Drawing.Size(74, 21);
            this.FromScanCmb.TabIndex = 1;
            // 
            // GenerateGroup
            // 
            this.GenerateGroup.Controls.Add(this.GenerateBtn);
            this.GenerateGroup.Controls.Add(this.AddPrefixBtn);
            this.GenerateGroup.Location = new System.Drawing.Point(7, 60);
            this.GenerateGroup.Name = "GenerateGroup";
            this.GenerateGroup.Size = new System.Drawing.Size(244, 93);
            this.GenerateGroup.TabIndex = 0;
            this.GenerateGroup.TabStop = false;
            this.GenerateGroup.Text = "Generate";
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(136, 37);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(102, 23);
            this.GenerateBtn.TabIndex = 1;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // AddPrefixBtn
            // 
            this.AddPrefixBtn.Location = new System.Drawing.Point(7, 37);
            this.AddPrefixBtn.Name = "AddPrefixBtn";
            this.AddPrefixBtn.Size = new System.Drawing.Size(101, 23);
            this.AddPrefixBtn.TabIndex = 0;
            this.AddPrefixBtn.Text = "Add Prefix";
            this.AddPrefixBtn.UseVisualStyleBackColor = true;
            this.AddPrefixBtn.Click += new System.EventHandler(this.AddPrefixBtn_Click);
            // 
            // DiagnoseGroup
            // 
            this.DiagnoseGroup.Controls.Add(this.ClearAllBtn);
            this.DiagnoseGroup.Controls.Add(this.DiagnoseBtn);
            this.DiagnoseGroup.Controls.Add(this.GroupDiagnoseGroup);
            this.DiagnoseGroup.Location = new System.Drawing.Point(23, 22);
            this.DiagnoseGroup.Name = "DiagnoseGroup";
            this.DiagnoseGroup.Size = new System.Drawing.Size(257, 208);
            this.DiagnoseGroup.TabIndex = 0;
            this.DiagnoseGroup.TabStop = false;
            this.DiagnoseGroup.Text = "Diagnose";
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.Location = new System.Drawing.Point(143, 33);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(108, 23);
            this.ClearAllBtn.TabIndex = 2;
            this.ClearAllBtn.Text = "Clear All";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // DiagnoseBtn
            // 
            this.DiagnoseBtn.Location = new System.Drawing.Point(7, 33);
            this.DiagnoseBtn.Name = "DiagnoseBtn";
            this.DiagnoseBtn.Size = new System.Drawing.Size(108, 23);
            this.DiagnoseBtn.TabIndex = 1;
            this.DiagnoseBtn.Text = "Diagnose";
            this.DiagnoseBtn.UseVisualStyleBackColor = true;
            this.DiagnoseBtn.Click += new System.EventHandler(this.DiagnoseBtn_Click);
            // 
            // GroupDiagnoseGroup
            // 
            this.GroupDiagnoseGroup.Controls.Add(this.DiagModulBtn);
            this.GroupDiagnoseGroup.Controls.Add(this.ModulCmb);
            this.GroupDiagnoseGroup.Controls.Add(this.ClearModulBtn);
            this.GroupDiagnoseGroup.Controls.Add(this.DiagnoseModulBtn);
            this.GroupDiagnoseGroup.Location = new System.Drawing.Point(7, 74);
            this.GroupDiagnoseGroup.Name = "GroupDiagnoseGroup";
            this.GroupDiagnoseGroup.Size = new System.Drawing.Size(244, 128);
            this.GroupDiagnoseGroup.TabIndex = 0;
            this.GroupDiagnoseGroup.TabStop = false;
            // 
            // DiagModulBtn
            // 
            this.DiagModulBtn.AutoSize = true;
            this.DiagModulBtn.Location = new System.Drawing.Point(15, 40);
            this.DiagModulBtn.Name = "DiagModulBtn";
            this.DiagModulBtn.Size = new System.Drawing.Size(36, 13);
            this.DiagModulBtn.TabIndex = 3;
            this.DiagModulBtn.Text = "Modul";
            this.DiagModulBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModulCmb
            // 
            this.ModulCmb.FormattingEnabled = true;
            this.ModulCmb.Location = new System.Drawing.Point(7, 56);
            this.ModulCmb.Name = "ModulCmb";
            this.ModulCmb.Size = new System.Drawing.Size(101, 21);
            this.ModulCmb.TabIndex = 2;
            // 
            // ClearModulBtn
            // 
            this.ClearModulBtn.Location = new System.Drawing.Point(136, 88);
            this.ClearModulBtn.Name = "ClearModulBtn";
            this.ClearModulBtn.Size = new System.Drawing.Size(102, 23);
            this.ClearModulBtn.TabIndex = 1;
            this.ClearModulBtn.Text = "Clear Modul";
            this.ClearModulBtn.UseVisualStyleBackColor = true;
            this.ClearModulBtn.Click += new System.EventHandler(this.ClearModulBtn_Click);
            // 
            // DiagnoseModulBtn
            // 
            this.DiagnoseModulBtn.Location = new System.Drawing.Point(136, 20);
            this.DiagnoseModulBtn.Name = "DiagnoseModulBtn";
            this.DiagnoseModulBtn.Size = new System.Drawing.Size(102, 23);
            this.DiagnoseModulBtn.TabIndex = 0;
            this.DiagnoseModulBtn.Text = "Diagnose Modul";
            this.DiagnoseModulBtn.UseVisualStyleBackColor = true;
            this.DiagnoseModulBtn.Click += new System.EventHandler(this.DiagnoseModulBtn_Click);
            // 
            // SendTab
            // 
            this.SendTab.Controls.Add(this.Demo1Btn);
            this.SendTab.Controls.Add(this.Demo2Btn);
            this.SendTab.Controls.Add(this.CellInfoGroup);
            this.SendTab.Controls.Add(this.SendSingleGroup);
            this.SendTab.Location = new System.Drawing.Point(4, 22);
            this.SendTab.Name = "SendTab";
            this.SendTab.Size = new System.Drawing.Size(767, 399);
            this.SendTab.TabIndex = 2;
            this.SendTab.Text = "Send";
            this.SendTab.UseVisualStyleBackColor = true;
            // 
            // CellInfoGroup
            // 
            this.CellInfoGroup.Controls.Add(this.ScanCellInfoBtn);
            this.CellInfoGroup.Controls.Add(this.CellCellInfoLbl);
            this.CellInfoGroup.Controls.Add(this.RowCellInfoLbl);
            this.CellInfoGroup.Controls.Add(this.ModulCellInfoLbl);
            this.CellInfoGroup.Controls.Add(this.CellCellInfoCmb);
            this.CellInfoGroup.Controls.Add(this.RowCellInfoCmb);
            this.CellInfoGroup.Controls.Add(this.ModulCellInfoCmb);
            this.CellInfoGroup.Location = new System.Drawing.Point(377, 48);
            this.CellInfoGroup.Name = "CellInfoGroup";
            this.CellInfoGroup.Size = new System.Drawing.Size(172, 180);
            this.CellInfoGroup.TabIndex = 1;
            this.CellInfoGroup.TabStop = false;
            this.CellInfoGroup.Text = "Cell Info";
            // 
            // ScanCellInfoBtn
            // 
            this.ScanCellInfoBtn.Location = new System.Drawing.Point(66, 130);
            this.ScanCellInfoBtn.Name = "ScanCellInfoBtn";
            this.ScanCellInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ScanCellInfoBtn.TabIndex = 19;
            this.ScanCellInfoBtn.Text = "Scan Cell";
            this.ScanCellInfoBtn.UseVisualStyleBackColor = true;
            this.ScanCellInfoBtn.Click += new System.EventHandler(this.ScanCellInfoBtn_Click);
            // 
            // CellCellInfoLbl
            // 
            this.CellCellInfoLbl.AutoSize = true;
            this.CellCellInfoLbl.Location = new System.Drawing.Point(63, 84);
            this.CellCellInfoLbl.Name = "CellCellInfoLbl";
            this.CellCellInfoLbl.Size = new System.Drawing.Size(24, 13);
            this.CellCellInfoLbl.TabIndex = 18;
            this.CellCellInfoLbl.Text = "Cell";
            // 
            // RowCellInfoLbl
            // 
            this.RowCellInfoLbl.AutoSize = true;
            this.RowCellInfoLbl.Location = new System.Drawing.Point(63, 57);
            this.RowCellInfoLbl.Name = "RowCellInfoLbl";
            this.RowCellInfoLbl.Size = new System.Drawing.Size(29, 13);
            this.RowCellInfoLbl.TabIndex = 17;
            this.RowCellInfoLbl.Text = "Row";
            // 
            // ModulCellInfoLbl
            // 
            this.ModulCellInfoLbl.AutoSize = true;
            this.ModulCellInfoLbl.Location = new System.Drawing.Point(63, 30);
            this.ModulCellInfoLbl.Name = "ModulCellInfoLbl";
            this.ModulCellInfoLbl.Size = new System.Drawing.Size(36, 13);
            this.ModulCellInfoLbl.TabIndex = 16;
            this.ModulCellInfoLbl.Text = "Modul";
            // 
            // CellCellInfoCmb
            // 
            this.CellCellInfoCmb.FormattingEnabled = true;
            this.CellCellInfoCmb.Location = new System.Drawing.Point(6, 81);
            this.CellCellInfoCmb.Name = "CellCellInfoCmb";
            this.CellCellInfoCmb.Size = new System.Drawing.Size(51, 21);
            this.CellCellInfoCmb.TabIndex = 10;
            // 
            // RowCellInfoCmb
            // 
            this.RowCellInfoCmb.FormattingEnabled = true;
            this.RowCellInfoCmb.Location = new System.Drawing.Point(6, 54);
            this.RowCellInfoCmb.Name = "RowCellInfoCmb";
            this.RowCellInfoCmb.Size = new System.Drawing.Size(51, 21);
            this.RowCellInfoCmb.TabIndex = 9;
            // 
            // ModulCellInfoCmb
            // 
            this.ModulCellInfoCmb.FormattingEnabled = true;
            this.ModulCellInfoCmb.Location = new System.Drawing.Point(6, 27);
            this.ModulCellInfoCmb.Name = "ModulCellInfoCmb";
            this.ModulCellInfoCmb.Size = new System.Drawing.Size(51, 21);
            this.ModulCellInfoCmb.TabIndex = 8;
            // 
            // SendSingleGroup
            // 
            this.SendSingleGroup.Controls.Add(this.SendMultipleBtn);
            this.SendSingleGroup.Controls.Add(this.PhysAddreses);
            this.SendSingleGroup.Controls.Add(this.SendSingleBtn);
            this.SendSingleGroup.Controls.Add(this.PhysAddressLbl);
            this.SendSingleGroup.Controls.Add(this.LedsPerRowSendLbl);
            this.SendSingleGroup.Controls.Add(this.Color2SendLbl);
            this.SendSingleGroup.Controls.Add(this.EffectSendLbl);
            this.SendSingleGroup.Controls.Add(this.Color0SendLbl);
            this.SendSingleGroup.Controls.Add(this.PhysAddressTxt);
            this.SendSingleGroup.Controls.Add(this.LedsPerRowSendSingle);
            this.SendSingleGroup.Controls.Add(this.Color0SendSingleCmb);
            this.SendSingleGroup.Controls.Add(this.EffectSendSingleCmb);
            this.SendSingleGroup.Controls.Add(this.Color2SendSingleCmb);
            this.SendSingleGroup.Location = new System.Drawing.Point(18, 25);
            this.SendSingleGroup.Name = "SendSingleGroup";
            this.SendSingleGroup.Size = new System.Drawing.Size(325, 203);
            this.SendSingleGroup.TabIndex = 0;
            this.SendSingleGroup.TabStop = false;
            this.SendSingleGroup.Text = "Send Single";
            this.SendSingleGroup.Enter += new System.EventHandler(this.SendSingleGroup_Enter);
            // 
            // SendSingleBtn
            // 
            this.SendSingleBtn.Location = new System.Drawing.Point(6, 165);
            this.SendSingleBtn.Name = "SendSingleBtn";
            this.SendSingleBtn.Size = new System.Drawing.Size(75, 23);
            this.SendSingleBtn.TabIndex = 16;
            this.SendSingleBtn.Text = "Send";
            this.SendSingleBtn.UseVisualStyleBackColor = true;
            this.SendSingleBtn.Click += new System.EventHandler(this.SendSingleBtn_Click);
            // 
            // PhysAddressLbl
            // 
            this.PhysAddressLbl.AutoSize = true;
            this.PhysAddressLbl.Location = new System.Drawing.Point(101, 23);
            this.PhysAddressLbl.Name = "PhysAddressLbl";
            this.PhysAddressLbl.Size = new System.Drawing.Size(68, 13);
            this.PhysAddressLbl.TabIndex = 15;
            this.PhysAddressLbl.Text = "PhysAddress";
            // 
            // LedsPerRowSendLbl
            // 
            this.LedsPerRowSendLbl.AutoSize = true;
            this.LedsPerRowSendLbl.Location = new System.Drawing.Point(63, 129);
            this.LedsPerRowSendLbl.Name = "LedsPerRowSendLbl";
            this.LedsPerRowSendLbl.Size = new System.Drawing.Size(68, 13);
            this.LedsPerRowSendLbl.TabIndex = 14;
            this.LedsPerRowSendLbl.Text = "LedsPerRow";
            // 
            // Color2SendLbl
            // 
            this.Color2SendLbl.AutoSize = true;
            this.Color2SendLbl.Location = new System.Drawing.Point(63, 102);
            this.Color2SendLbl.Name = "Color2SendLbl";
            this.Color2SendLbl.Size = new System.Drawing.Size(37, 13);
            this.Color2SendLbl.TabIndex = 13;
            this.Color2SendLbl.Text = "Color2";
            // 
            // EffectSendLbl
            // 
            this.EffectSendLbl.AutoSize = true;
            this.EffectSendLbl.Location = new System.Drawing.Point(63, 75);
            this.EffectSendLbl.Name = "EffectSendLbl";
            this.EffectSendLbl.Size = new System.Drawing.Size(35, 13);
            this.EffectSendLbl.TabIndex = 12;
            this.EffectSendLbl.Text = "Effect";
            // 
            // Color0SendLbl
            // 
            this.Color0SendLbl.AutoSize = true;
            this.Color0SendLbl.Location = new System.Drawing.Point(63, 49);
            this.Color0SendLbl.Name = "Color0SendLbl";
            this.Color0SendLbl.Size = new System.Drawing.Size(37, 13);
            this.Color0SendLbl.TabIndex = 11;
            this.Color0SendLbl.Text = "Color0";
            // 
            // PhysAddressTxt
            // 
            this.PhysAddressTxt.Location = new System.Drawing.Point(6, 23);
            this.PhysAddressTxt.Name = "PhysAddressTxt";
            this.PhysAddressTxt.Size = new System.Drawing.Size(89, 20);
            this.PhysAddressTxt.TabIndex = 7;
            // 
            // LedsPerRowSendSingle
            // 
            this.LedsPerRowSendSingle.Location = new System.Drawing.Point(6, 129);
            this.LedsPerRowSendSingle.Name = "LedsPerRowSendSingle";
            this.LedsPerRowSendSingle.Size = new System.Drawing.Size(51, 20);
            this.LedsPerRowSendSingle.TabIndex = 5;
            // 
            // Color0SendSingleCmb
            // 
            this.Color0SendSingleCmb.FormattingEnabled = true;
            this.Color0SendSingleCmb.Location = new System.Drawing.Point(6, 49);
            this.Color0SendSingleCmb.Name = "Color0SendSingleCmb";
            this.Color0SendSingleCmb.Size = new System.Drawing.Size(51, 21);
            this.Color0SendSingleCmb.TabIndex = 4;
            // 
            // EffectSendSingleCmb
            // 
            this.EffectSendSingleCmb.FormattingEnabled = true;
            this.EffectSendSingleCmb.Location = new System.Drawing.Point(6, 75);
            this.EffectSendSingleCmb.Name = "EffectSendSingleCmb";
            this.EffectSendSingleCmb.Size = new System.Drawing.Size(51, 21);
            this.EffectSendSingleCmb.TabIndex = 3;
            // 
            // Color2SendSingleCmb
            // 
            this.Color2SendSingleCmb.FormattingEnabled = true;
            this.Color2SendSingleCmb.Location = new System.Drawing.Point(6, 102);
            this.Color2SendSingleCmb.Name = "Color2SendSingleCmb";
            this.Color2SendSingleCmb.Size = new System.Drawing.Size(51, 21);
            this.Color2SendSingleCmb.TabIndex = 2;
            // 
            // Demo2Btn
            // 
            this.Demo2Btn.Location = new System.Drawing.Point(582, 97);
            this.Demo2Btn.Name = "Demo2Btn";
            this.Demo2Btn.Size = new System.Drawing.Size(75, 23);
            this.Demo2Btn.TabIndex = 3;
            this.Demo2Btn.Text = "Demo2";
            this.Demo2Btn.UseVisualStyleBackColor = true;
            this.Demo2Btn.Click += new System.EventHandler(this.Demo2Btn_Click);
            // 
            // Demo1Btn
            // 
            this.Demo1Btn.Location = new System.Drawing.Point(582, 68);
            this.Demo1Btn.Name = "Demo1Btn";
            this.Demo1Btn.Size = new System.Drawing.Size(75, 23);
            this.Demo1Btn.TabIndex = 4;
            this.Demo1Btn.Text = "Demo1";
            this.Demo1Btn.UseVisualStyleBackColor = true;
            this.Demo1Btn.Click += new System.EventHandler(this.Demo1Btn_Click);
            // 
            // PhysAddreses
            // 
            this.PhysAddreses.FormattingEnabled = true;
            this.PhysAddreses.Location = new System.Drawing.Point(175, 23);
            this.PhysAddreses.Name = "PhysAddreses";
            this.PhysAddreses.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.PhysAddreses.Size = new System.Drawing.Size(120, 95);
            this.PhysAddreses.TabIndex = 18;
            // 
            // SendMultipleBtn
            // 
            this.SendMultipleBtn.Location = new System.Drawing.Point(195, 165);
            this.SendMultipleBtn.Name = "SendMultipleBtn";
            this.SendMultipleBtn.Size = new System.Drawing.Size(100, 23);
            this.SendMultipleBtn.TabIndex = 19;
            this.SendMultipleBtn.Text = "Send list";
            this.SendMultipleBtn.UseVisualStyleBackColor = true;
            this.SendMultipleBtn.Click += new System.EventHandler(this.SendMultipleBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.OpenTab.ResumeLayout(false);
            this.ConnectGroup.ResumeLayout(false);
            this.ConnectGroup.PerformLayout();
            this.ScanTab.ResumeLayout(false);
            this.ModulListGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ScanGroup.ResumeLayout(false);
            this.ScanGroup.PerformLayout();
            this.GenerateGroup.ResumeLayout(false);
            this.DiagnoseGroup.ResumeLayout(false);
            this.GroupDiagnoseGroup.ResumeLayout(false);
            this.GroupDiagnoseGroup.PerformLayout();
            this.SendTab.ResumeLayout(false);
            this.CellInfoGroup.ResumeLayout(false);
            this.CellInfoGroup.PerformLayout();
            this.SendSingleGroup.ResumeLayout(false);
            this.SendSingleGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage OpenTab;
        private System.Windows.Forms.GroupBox ConnectGroup;
        private System.Windows.Forms.TabPage ScanTab;
        private System.Windows.Forms.TabPage SendTab;
        private System.Windows.Forms.Label ComLbl;
        private System.Windows.Forms.ComboBox PortCmb;
        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.GroupBox ModulListGroup;
        private System.Windows.Forms.GroupBox ScanGroup;
        private System.Windows.Forms.GroupBox GenerateGroup;
        private System.Windows.Forms.GroupBox DiagnoseGroup;
        private System.Windows.Forms.Button ClearAllBtn;
        private System.Windows.Forms.Button DiagnoseBtn;
        private System.Windows.Forms.GroupBox GroupDiagnoseGroup;
        private System.Windows.Forms.ComboBox ModulCmb;
        private System.Windows.Forms.Button ClearModulBtn;
        private System.Windows.Forms.Button DiagnoseModulBtn;
        private System.Windows.Forms.GroupBox CellInfoGroup;
        private System.Windows.Forms.GroupBox SendSingleGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ModulId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CollumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrefixId;
        private System.Windows.Forms.Button FirstScanBtn;
        private System.Windows.Forms.Label ToLbl;
        private System.Windows.Forms.Label FranLbl;
        private System.Windows.Forms.ComboBox ToScanCmb;
        private System.Windows.Forms.ComboBox FromScanCmb;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button AddPrefixBtn;
        private System.Windows.Forms.Label DiagModulBtn;
        private System.Windows.Forms.Label CellCellInfoLbl;
        private System.Windows.Forms.Label RowCellInfoLbl;
        private System.Windows.Forms.Label ModulCellInfoLbl;
        private System.Windows.Forms.ComboBox CellCellInfoCmb;
        private System.Windows.Forms.ComboBox RowCellInfoCmb;
        private System.Windows.Forms.ComboBox ModulCellInfoCmb;
        private System.Windows.Forms.Label PhysAddressLbl;
        private System.Windows.Forms.Label LedsPerRowSendLbl;
        private System.Windows.Forms.Label Color2SendLbl;
        private System.Windows.Forms.Label EffectSendLbl;
        private System.Windows.Forms.Label Color0SendLbl;
        private System.Windows.Forms.TextBox PhysAddressTxt;
        private System.Windows.Forms.TextBox LedsPerRowSendSingle;
        private System.Windows.Forms.ComboBox Color0SendSingleCmb;
        private System.Windows.Forms.ComboBox EffectSendSingleCmb;
        private System.Windows.Forms.ComboBox Color2SendSingleCmb;
        private System.Windows.Forms.Button ScanCellInfoBtn;
        private System.Windows.Forms.Button SendSingleBtn;
        private System.Windows.Forms.Button Demo2Btn;
        private System.Windows.Forms.Button Demo1Btn;
        public System.Windows.Forms.ListBox PhysAddreses;
        private System.Windows.Forms.Button SendMultipleBtn;
    }
}


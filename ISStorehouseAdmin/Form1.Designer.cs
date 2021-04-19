
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
            this.ScanTab = new System.Windows.Forms.TabPage();
            this.SendTab = new System.Windows.Forms.TabPage();
            this.ConnectGroup = new System.Windows.Forms.GroupBox();
            this.OpenBtn = new System.Windows.Forms.Button();
            this.PortCmb = new System.Windows.Forms.ComboBox();
            this.ComLbl = new System.Windows.Forms.Label();
            this.DiagnoseGroup = new System.Windows.Forms.GroupBox();
            this.GroupDiagnoseGroup = new System.Windows.Forms.GroupBox();
            this.ScanGroup = new System.Windows.Forms.GroupBox();
            this.GenerateGroup = new System.Windows.Forms.GroupBox();
            this.ModulListGroup = new System.Windows.Forms.GroupBox();
            this.SendSingleGroup = new System.Windows.Forms.GroupBox();
            this.CellInfoGroup = new System.Windows.Forms.GroupBox();
            this.DiagnoseBtn = new System.Windows.Forms.Button();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.DiagnoseModulBtn = new System.Windows.Forms.Button();
            this.ClearModulBtn = new System.Windows.Forms.Button();
            this.ModulCmb = new System.Windows.Forms.ComboBox();
            this.DiagModulBtn = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.FranLbl = new System.Windows.Forms.Label();
            this.ToLbl = new System.Windows.Forms.Label();
            this.FirstScanBtn = new System.Windows.Forms.Button();
            this.AddPrefixBtn = new System.Windows.Forms.Button();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ModulId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrefixId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.ModulSendLbl = new System.Windows.Forms.Label();
            this.RowSendLbl = new System.Windows.Forms.Label();
            this.LedSendLbl = new System.Windows.Forms.Label();
            this.Color0SendLbl = new System.Windows.Forms.Label();
            this.EffectSendLbl = new System.Windows.Forms.Label();
            this.Color2SendLbl = new System.Windows.Forms.Label();
            this.LedsPerRowSendLbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ModulCellInfoLbl = new System.Windows.Forms.Label();
            this.RowCellInfoLbl = new System.Windows.Forms.Label();
            this.CellCellInfoLbl = new System.Windows.Forms.Label();
            this.SendSingleBtn = new System.Windows.Forms.Button();
            this.ScanCellInfoBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.OpenTab.SuspendLayout();
            this.ScanTab.SuspendLayout();
            this.SendTab.SuspendLayout();
            this.ConnectGroup.SuspendLayout();
            this.DiagnoseGroup.SuspendLayout();
            this.GroupDiagnoseGroup.SuspendLayout();
            this.ScanGroup.SuspendLayout();
            this.GenerateGroup.SuspendLayout();
            this.ModulListGroup.SuspendLayout();
            this.SendSingleGroup.SuspendLayout();
            this.CellInfoGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // SendTab
            // 
            this.SendTab.Controls.Add(this.CellInfoGroup);
            this.SendTab.Controls.Add(this.SendSingleGroup);
            this.SendTab.Location = new System.Drawing.Point(4, 22);
            this.SendTab.Name = "SendTab";
            this.SendTab.Size = new System.Drawing.Size(767, 399);
            this.SendTab.TabIndex = 2;
            this.SendTab.Text = "Send";
            this.SendTab.UseVisualStyleBackColor = true;
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
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(52, 73);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(75, 23);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            // 
            // PortCmb
            // 
            this.PortCmb.FormattingEnabled = true;
            this.PortCmb.Location = new System.Drawing.Point(17, 33);
            this.PortCmb.Name = "PortCmb";
            this.PortCmb.Size = new System.Drawing.Size(121, 21);
            this.PortCmb.TabIndex = 1;
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
            // ScanGroup
            // 
            this.ScanGroup.Controls.Add(this.FirstScanBtn);
            this.ScanGroup.Controls.Add(this.ToLbl);
            this.ScanGroup.Controls.Add(this.FranLbl);
            this.ScanGroup.Controls.Add(this.comboBox2);
            this.ScanGroup.Controls.Add(this.comboBox1);
            this.ScanGroup.Controls.Add(this.GenerateGroup);
            this.ScanGroup.Location = new System.Drawing.Point(23, 237);
            this.ScanGroup.Name = "ScanGroup";
            this.ScanGroup.Size = new System.Drawing.Size(257, 159);
            this.ScanGroup.TabIndex = 1;
            this.ScanGroup.TabStop = false;
            this.ScanGroup.Text = "Scan";
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
            // SendSingleGroup
            // 
            this.SendSingleGroup.Controls.Add(this.SendSingleBtn);
            this.SendSingleGroup.Controls.Add(this.label8);
            this.SendSingleGroup.Controls.Add(this.LedsPerRowSendLbl);
            this.SendSingleGroup.Controls.Add(this.Color2SendLbl);
            this.SendSingleGroup.Controls.Add(this.EffectSendLbl);
            this.SendSingleGroup.Controls.Add(this.Color0SendLbl);
            this.SendSingleGroup.Controls.Add(this.LedSendLbl);
            this.SendSingleGroup.Controls.Add(this.RowSendLbl);
            this.SendSingleGroup.Controls.Add(this.ModulSendLbl);
            this.SendSingleGroup.Controls.Add(this.textBox3);
            this.SendSingleGroup.Controls.Add(this.textBox2);
            this.SendSingleGroup.Controls.Add(this.textBox1);
            this.SendSingleGroup.Controls.Add(this.comboBox7);
            this.SendSingleGroup.Controls.Add(this.comboBox6);
            this.SendSingleGroup.Controls.Add(this.comboBox5);
            this.SendSingleGroup.Controls.Add(this.comboBox4);
            this.SendSingleGroup.Controls.Add(this.comboBox3);
            this.SendSingleGroup.Location = new System.Drawing.Point(18, 25);
            this.SendSingleGroup.Name = "SendSingleGroup";
            this.SendSingleGroup.Size = new System.Drawing.Size(325, 278);
            this.SendSingleGroup.TabIndex = 0;
            this.SendSingleGroup.TabStop = false;
            this.SendSingleGroup.Text = "Send Single";
            // 
            // CellInfoGroup
            // 
            this.CellInfoGroup.Controls.Add(this.ScanCellInfoBtn);
            this.CellInfoGroup.Controls.Add(this.CellCellInfoLbl);
            this.CellInfoGroup.Controls.Add(this.RowCellInfoLbl);
            this.CellInfoGroup.Controls.Add(this.ModulCellInfoLbl);
            this.CellInfoGroup.Controls.Add(this.comboBox10);
            this.CellInfoGroup.Controls.Add(this.comboBox9);
            this.CellInfoGroup.Controls.Add(this.comboBox8);
            this.CellInfoGroup.Location = new System.Drawing.Point(377, 48);
            this.CellInfoGroup.Name = "CellInfoGroup";
            this.CellInfoGroup.Size = new System.Drawing.Size(172, 180);
            this.CellInfoGroup.TabIndex = 1;
            this.CellInfoGroup.TabStop = false;
            this.CellInfoGroup.Text = "Cell Info";
            // 
            // DiagnoseBtn
            // 
            this.DiagnoseBtn.Location = new System.Drawing.Point(7, 33);
            this.DiagnoseBtn.Name = "DiagnoseBtn";
            this.DiagnoseBtn.Size = new System.Drawing.Size(108, 23);
            this.DiagnoseBtn.TabIndex = 1;
            this.DiagnoseBtn.Text = "Diagnose";
            this.DiagnoseBtn.UseVisualStyleBackColor = true;
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.Location = new System.Drawing.Point(143, 33);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(108, 23);
            this.ClearAllBtn.TabIndex = 2;
            this.ClearAllBtn.Text = "Clear All";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            // 
            // DiagnoseModulBtn
            // 
            this.DiagnoseModulBtn.Location = new System.Drawing.Point(136, 20);
            this.DiagnoseModulBtn.Name = "DiagnoseModulBtn";
            this.DiagnoseModulBtn.Size = new System.Drawing.Size(102, 23);
            this.DiagnoseModulBtn.TabIndex = 0;
            this.DiagnoseModulBtn.Text = "Diagnose Modul";
            this.DiagnoseModulBtn.UseVisualStyleBackColor = true;
            // 
            // ClearModulBtn
            // 
            this.ClearModulBtn.Location = new System.Drawing.Point(136, 88);
            this.ClearModulBtn.Name = "ClearModulBtn";
            this.ClearModulBtn.Size = new System.Drawing.Size(102, 23);
            this.ClearModulBtn.TabIndex = 1;
            this.ClearModulBtn.Text = "Clear Modul";
            this.ClearModulBtn.UseVisualStyleBackColor = true;
            // 
            // ModulCmb
            // 
            this.ModulCmb.FormattingEnabled = true;
            this.ModulCmb.Location = new System.Drawing.Point(7, 56);
            this.ModulCmb.Name = "ModulCmb";
            this.ModulCmb.Size = new System.Drawing.Size(101, 21);
            this.ModulCmb.TabIndex = 2;
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(74, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(86, 33);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(74, 21);
            this.comboBox2.TabIndex = 2;
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
            // ToLbl
            // 
            this.ToLbl.AutoSize = true;
            this.ToLbl.Location = new System.Drawing.Point(95, 20);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(20, 13);
            this.ToLbl.TabIndex = 4;
            this.ToLbl.Text = "To";
            // 
            // FirstScanBtn
            // 
            this.FirstScanBtn.Location = new System.Drawing.Point(167, 33);
            this.FirstScanBtn.Name = "FirstScanBtn";
            this.FirstScanBtn.Size = new System.Drawing.Size(75, 23);
            this.FirstScanBtn.TabIndex = 5;
            this.FirstScanBtn.Text = "Frist Scan";
            this.FirstScanBtn.UseVisualStyleBackColor = true;
            // 
            // AddPrefixBtn
            // 
            this.AddPrefixBtn.Location = new System.Drawing.Point(7, 37);
            this.AddPrefixBtn.Name = "AddPrefixBtn";
            this.AddPrefixBtn.Size = new System.Drawing.Size(101, 23);
            this.AddPrefixBtn.TabIndex = 0;
            this.AddPrefixBtn.Text = "Add Prefix";
            this.AddPrefixBtn.UseVisualStyleBackColor = true;
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(136, 37);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(102, 23);
            this.GenerateBtn.TabIndex = 1;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
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
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(7, 23);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(51, 21);
            this.comboBox3.TabIndex = 0;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(7, 50);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(51, 21);
            this.comboBox4.TabIndex = 1;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(7, 156);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(51, 21);
            this.comboBox5.TabIndex = 2;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(7, 129);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(51, 21);
            this.comboBox6.TabIndex = 3;
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(7, 103);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(51, 21);
            this.comboBox7.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(51, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(130, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(89, 20);
            this.textBox3.TabIndex = 7;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(6, 27);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(51, 21);
            this.comboBox8.TabIndex = 8;
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(6, 54);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(51, 21);
            this.comboBox9.TabIndex = 9;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(6, 81);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(51, 21);
            this.comboBox10.TabIndex = 10;
            // 
            // ModulSendLbl
            // 
            this.ModulSendLbl.AutoSize = true;
            this.ModulSendLbl.Location = new System.Drawing.Point(64, 23);
            this.ModulSendLbl.Name = "ModulSendLbl";
            this.ModulSendLbl.Size = new System.Drawing.Size(36, 13);
            this.ModulSendLbl.TabIndex = 8;
            this.ModulSendLbl.Text = "Modul";
            // 
            // RowSendLbl
            // 
            this.RowSendLbl.AutoSize = true;
            this.RowSendLbl.Location = new System.Drawing.Point(64, 50);
            this.RowSendLbl.Name = "RowSendLbl";
            this.RowSendLbl.Size = new System.Drawing.Size(29, 13);
            this.RowSendLbl.TabIndex = 9;
            this.RowSendLbl.Text = "Row";
            // 
            // LedSendLbl
            // 
            this.LedSendLbl.AutoSize = true;
            this.LedSendLbl.Location = new System.Drawing.Point(64, 77);
            this.LedSendLbl.Name = "LedSendLbl";
            this.LedSendLbl.Size = new System.Drawing.Size(25, 13);
            this.LedSendLbl.TabIndex = 10;
            this.LedSendLbl.Text = "Led";
            // 
            // Color0SendLbl
            // 
            this.Color0SendLbl.AutoSize = true;
            this.Color0SendLbl.Location = new System.Drawing.Point(64, 103);
            this.Color0SendLbl.Name = "Color0SendLbl";
            this.Color0SendLbl.Size = new System.Drawing.Size(37, 13);
            this.Color0SendLbl.TabIndex = 11;
            this.Color0SendLbl.Text = "Color0";
            // 
            // EffectSendLbl
            // 
            this.EffectSendLbl.AutoSize = true;
            this.EffectSendLbl.Location = new System.Drawing.Point(64, 129);
            this.EffectSendLbl.Name = "EffectSendLbl";
            this.EffectSendLbl.Size = new System.Drawing.Size(35, 13);
            this.EffectSendLbl.TabIndex = 12;
            this.EffectSendLbl.Text = "Effect";
            // 
            // Color2SendLbl
            // 
            this.Color2SendLbl.AutoSize = true;
            this.Color2SendLbl.Location = new System.Drawing.Point(64, 156);
            this.Color2SendLbl.Name = "Color2SendLbl";
            this.Color2SendLbl.Size = new System.Drawing.Size(37, 13);
            this.Color2SendLbl.TabIndex = 13;
            this.Color2SendLbl.Text = "Color2";
            // 
            // LedsPerRowSendLbl
            // 
            this.LedsPerRowSendLbl.AutoSize = true;
            this.LedsPerRowSendLbl.Location = new System.Drawing.Point(64, 183);
            this.LedsPerRowSendLbl.Name = "LedsPerRowSendLbl";
            this.LedsPerRowSendLbl.Size = new System.Drawing.Size(68, 13);
            this.LedsPerRowSendLbl.TabIndex = 14;
            this.LedsPerRowSendLbl.Text = "LedsPerRow";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "label8";
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
            // RowCellInfoLbl
            // 
            this.RowCellInfoLbl.AutoSize = true;
            this.RowCellInfoLbl.Location = new System.Drawing.Point(63, 57);
            this.RowCellInfoLbl.Name = "RowCellInfoLbl";
            this.RowCellInfoLbl.Size = new System.Drawing.Size(29, 13);
            this.RowCellInfoLbl.TabIndex = 17;
            this.RowCellInfoLbl.Text = "Row";
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
            // SendSingleBtn
            // 
            this.SendSingleBtn.Location = new System.Drawing.Point(67, 229);
            this.SendSingleBtn.Name = "SendSingleBtn";
            this.SendSingleBtn.Size = new System.Drawing.Size(75, 23);
            this.SendSingleBtn.TabIndex = 16;
            this.SendSingleBtn.Text = "Send";
            this.SendSingleBtn.UseVisualStyleBackColor = true;
            // 
            // ScanCellInfoBtn
            // 
            this.ScanCellInfoBtn.Location = new System.Drawing.Point(66, 130);
            this.ScanCellInfoBtn.Name = "ScanCellInfoBtn";
            this.ScanCellInfoBtn.Size = new System.Drawing.Size(75, 23);
            this.ScanCellInfoBtn.TabIndex = 19;
            this.ScanCellInfoBtn.Text = "Scan Cell";
            this.ScanCellInfoBtn.UseVisualStyleBackColor = true;
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
            this.ScanTab.ResumeLayout(false);
            this.SendTab.ResumeLayout(false);
            this.ConnectGroup.ResumeLayout(false);
            this.ConnectGroup.PerformLayout();
            this.DiagnoseGroup.ResumeLayout(false);
            this.GroupDiagnoseGroup.ResumeLayout(false);
            this.GroupDiagnoseGroup.PerformLayout();
            this.ScanGroup.ResumeLayout(false);
            this.ScanGroup.PerformLayout();
            this.GenerateGroup.ResumeLayout(false);
            this.ModulListGroup.ResumeLayout(false);
            this.SendSingleGroup.ResumeLayout(false);
            this.SendSingleGroup.PerformLayout();
            this.CellInfoGroup.ResumeLayout(false);
            this.CellInfoGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button AddPrefixBtn;
        private System.Windows.Forms.Label DiagModulBtn;
        private System.Windows.Forms.Label CellCellInfoLbl;
        private System.Windows.Forms.Label RowCellInfoLbl;
        private System.Windows.Forms.Label ModulCellInfoLbl;
        private System.Windows.Forms.ComboBox comboBox10;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LedsPerRowSendLbl;
        private System.Windows.Forms.Label Color2SendLbl;
        private System.Windows.Forms.Label EffectSendLbl;
        private System.Windows.Forms.Label Color0SendLbl;
        private System.Windows.Forms.Label LedSendLbl;
        private System.Windows.Forms.Label RowSendLbl;
        private System.Windows.Forms.Label ModulSendLbl;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Button ScanCellInfoBtn;
        private System.Windows.Forms.Button SendSingleBtn;
    }
}


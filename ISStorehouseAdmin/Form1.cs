using ISStorehouseDLL;
using ISStorehouseDLL.Common;
using ISStorehouseDLL.Models;
using Realms;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static ISStorehouseDLL.Common.Settings;

namespace ISStorehouseAdmin
{
    public partial class Form1 : Form
    {
        private Settings settings = new Settings();
        private ScanClass scan = new ScanClass();
        private InfoClass info = new InfoClass();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var realm = Realm.GetInstance();

            var addresses = realm.All<Storehouse>();

            foreach(var addres in addresses)
            {
                this.PhysAddreses.Items.Add(addres.PhysicAddress);
            }

            realm.Dispose();

            var Portnames = SerialPort.GetPortNames();
            this.PortCmb.Items.AddRange(Portnames);
            this.PortCmb.SelectedItem = Portnames.LastOrDefault();

            this.Color0SendSingleCmb.DataSource = Enum.GetValues(typeof(Colors));
            this.Color2SendSingleCmb.DataSource = Enum.GetValues(typeof(Colors));
            this.EffectSendSingleCmb.DataSource = Enum.GetValues(typeof(Effects));

            Thread CheckDataBase = new Thread(settings.CheckDataBase);
            CheckDataBase.Start();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            settings.SavePort(this.PortCmb.Text);
        }

        private void DiagnoseBtn_Click(object sender, EventArgs e)
        {
            var message = settings.AllModulsDiagnose();
            MessageBox.Show(message, "Diagnose");
        }

        private void ClearAllBtn_Click(object sender, EventArgs e)
        {
            scan.ClearAllModuls();
        }

        private void DiagnoseModulBtn_Click(object sender, EventArgs e)
        {
            settings.OneModulTest(Convert.ToInt16(this.ModulCmb.Text));
        }

        private void ClearModulBtn_Click(object sender, EventArgs e)
        {
            scan.ClearOneModul(Convert.ToInt32(this.ModulCmb.Text));
        }

        private void FirstScanBtn_Click(object sender, EventArgs e)
        {
            var message = settings.FirstScanDeposit(Convert.ToInt32(this.FromScanCmb.Text), Convert.ToInt32(this.ToScanCmb.Text));
            List<object> RowList = scan.DisplayModules();

            foreach (var obj in RowList)
            {
                if (obj is object)
                {
                    var splited = obj.ToString().TrimStart('(').Split(',', ')');
                    this.dataGridView1.Rows.Add(splited);
                }
            }

            MessageBox.Show(message, "Scan");
        }

        private void AddPrefixBtn_Click(object sender, EventArgs e)
        {
            var realm = Realm.GetInstance();
            var PrefixModuls = realm.All<Moduls>().FirstOrDefault(
                    x => x.Module == Convert.ToInt16(dataGridView1.CurrentRow.Cells["ModulId"].Value) &&
                    x.Rows == Convert.ToInt16(dataGridView1.CurrentRow.Cells["RowId"].Value) &&
                    x.Collumns == Convert.ToInt16(dataGridView1.CurrentRow.Cells["CollumnId"].Value)
                );

            realm.Write(() =>
            {
                PrefixModuls.Prefix = dataGridView1.CurrentRow.Cells["PrefixId"].Value.ToString().ToUpper();
                PrefixModuls.ModifyTime = DateTimeOffset.Now;
            });

            realm.Dispose();
        }

        private void GenerateBtn_Click(object sender, EventArgs e)
        {
            scan.GenerateAddreses();
        }

        private void SendSingleBtn_Click(object sender, EventArgs e)
        {
            info.SendToCell(this.PhysAddressTxt.Text, Convert.ToByte(this.Color0SendSingleCmb.SelectedItem), Convert.ToByte(this.Color2SendSingleCmb.SelectedItem), Convert.ToByte(this.EffectSendSingleCmb.SelectedItem));


        }

        private void ScanCellInfoBtn_Click(object sender, EventArgs e)
        {
            var message = info.GetCellInformation(Convert.ToInt32(this.ModulCellInfoCmb.Text), Convert.ToInt32(this.RowCellInfoCmb.Text), Convert.ToInt32(this.CellCellInfoCmb.Text));

            MessageBox.Show(message, "Scan");
        }

        private void Demo1Btn_Click(object sender, EventArgs e)
        {
            scan.ClearOneModul(Convert.ToInt32(1));
            info.SendToCell("01003", 2, Convert.ToByte(this.Color2SendSingleCmb.SelectedItem), 1);
            info.SendToCell("01008", 3, Convert.ToByte(this.Color2SendSingleCmb.SelectedItem), 1);
            info.SendToCell("01206", 5, Convert.ToByte(this.Color2SendSingleCmb.SelectedItem), 1);
            info.SendToCell("01307", 1, Convert.ToByte(this.Color2SendSingleCmb.SelectedItem), 1);
        }

        private void Demo2Btn_Click(object sender, EventArgs e)
        {
            scan.ClearOneModul(Convert.ToInt32(1));
            info.SendToCell("01006", 2, Convert.ToByte(this.Color2SendSingleCmb.SelectedItem), 1);
            info.SendToCell("01103", 3, Convert.ToByte(this.Color2SendSingleCmb.SelectedItem), 1);
            info.SendToCell("01201", 5, Convert.ToByte(this.Color2SendSingleCmb.SelectedItem), 1);
            info.SendToCell("01207", 1, Convert.ToByte(this.Color2SendSingleCmb.SelectedItem), 1);
        }

        private void SendMultipleBtn_Click(object sender, EventArgs e)
        {
            scan.ClearOneModul(Convert.ToInt32(1));
            Random rnd = new Random();
            foreach (object element in this.PhysAddreses.SelectedItems)
            {
                int color = rnd.Next(1, 7);
                info.SendToCells(element.ToString(), Convert.ToByte(color), Convert.ToByte(this.Color2SendSingleCmb.SelectedItem), 1);

            }
        }

        private void SendSingleGroup_Enter(object sender, EventArgs e)
        {

        }
    }
}

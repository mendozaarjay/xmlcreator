using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XmlCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            LoadTestDataForPreEOD();
            LoadTestDataForEndOfDay();
            base.OnLoad(e);
        }

        private void LoadTestDataForEndOfDay()
        {
            dgEOD.Rows.Clear();
            var items = services.GetEODData(Properties.Settings.Default.UserConnectionString);
            if(items != null)
            {
                int row = 0;
                foreach(DataRow dr in items.Rows)
                {
                    dgEOD.Rows.Add(1);
                    dgEOD[dtlId.Index, row].Value = dr["Id"];
                    dgEOD[dtlBeginDate.Index, row].Value = dr["BeginDT"];
                    dgEOD[dtlEndDate.Index, row].Value = dr["EndDT"];
                    dgEOD[dtlTerminalId.Index, row].Value = dr["TerminalId"];
                    dgEOD[dtlTerminalName.Index, row].Value = dr["TerminalName"];
                    row++;
                }
            }
        }

        TestDataServices services = new TestDataServices();
        private void LoadTestDataForPreEOD()
        {
            dgPreEOD.Rows.Clear();
            var items = services.GetPreOEDData(Properties.Settings.Default.UserConnectionString);
            if(items != null)
            {
                int row = 0;
                foreach(DataRow dr in items.Rows)
                {
                    dgPreEOD.Rows.Add(1);
                    dgPreEOD[dtlPreId.Index, row].Value = dr["Id"];
                    dgPreEOD[dtlPreTerminalId.Index, row].Value = dr["TerminalId"];
                    dgPreEOD[dtlPreTerminal.Index, row].Value = dr["TerminalName"];
                    dgPreEOD[dtlPreTimeIn.Index, row].Value = dr["TimeIn"];
                    dgPreEOD[dtlPreTimeOut.Index, row].Value = dr["TimeOut"];
                    dgPreEOD[dtlPreAmount.Index, row].Value = dr["Amount"];
                    dgPreEOD[dtlPreDiscount.Index, row].Value = dr["Discount"];
                    row++;
                }
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fd = new FolderBrowserDialog();
            fd.ShowDialog();
            if(fd.SelectedPath.Length > 0)
            {
                txtPath.Text = fd.SelectedPath;
            }
        }

        private void dgPreEOD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if(e.ColumnIndex == dtlExportPreEOD.Index)
            {
                var id = dgPreEOD[dtlPreId.Index, e.RowIndex].Value.ToString();
                var terminal = dgPreEOD[dtlPreTerminalId.Index, e.RowIndex].Value.ToString();
                if(isValidEntry())
                {
                    XmlExport.ExportPreEndOfDay(txtPath.Text, txtKey.Text, txtTenantId.Text, terminal, id, Properties.Settings.Default.UserConnectionString);
                    MessageBox.Show("Process has been successfully completed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        bool isValidEntry()
        {
            var checkThis = string.Empty;
            if (txtPath.Text.Length <= 0)
                checkThis += "Cannot Continue. Path/Xml Destination is required.\n";
            if (txtKey.Text.Length <= 0)
                checkThis += "Cannot Continue. Key is required.\n";
            if (txtTenantId.Text.Length <= 0)
                checkThis += "Cannot Continue. Tenant Id is required.\n";
            if(checkThis.Length > 0)
            {
                MessageBox.Show(checkThis, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return checkThis.Length > 0 ? false : true;
        }

        private void dgEOD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            if(e.ColumnIndex == dtlExport.Index)
            {
                var id = dgEOD[dtlId.Index, e.RowIndex].Value.ToString();
                var terminal = dgEOD[dtlTerminalId.Index, e.RowIndex].Value.ToString();
                if(isValidEntry())
                {
                    XmlExport.ExportEndOfDay(txtPath.Text, txtKey.Text, txtTenantId.Text, terminal, id, Properties.Settings.Default.UserConnectionString);
                    MessageBox.Show("Process has been successfully completed.", this.Text, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}

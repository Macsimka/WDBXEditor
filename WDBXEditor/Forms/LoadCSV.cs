using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using WDBXEditor.Storage;
using static WDBXEditor.Common.Constants;

namespace WDBXEditor
{
    public partial class LoadCSV : Form
    {
        public DBEntry Entry { get; set; }
        public string ErrorMessage = string.Empty;

        private string filePath;

        public LoadCSV()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                btnLoad.Enabled = true;
                filePath = openFileDialog.FileName;
                txtFilePath.Text = filePath;
                openFileDialog.Dispose();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ((Main)Owner).ProgressBarHandle(true, "Importing CSV...");
            Enabled = false;
            bool header = chkHeader.Checked;

            ImportFlags flags = ImportFlags.None;
            if (rdoFixIds.Checked)
                flags |= ImportFlags.FixIds;
            if (rdoNewest.Checked)
                flags |= ImportFlags.TakeNewest;

            Task.Factory.StartNew(() =>
            {
                UpdateMode mode = UpdateMode.Insert;
                if (radUpdate.Checked)
                    mode = UpdateMode.Update;
                else if (radOverride.Checked)
                    mode = UpdateMode.Replace;

                if (!Entry.ImportCSV(filePath, header, mode, out ErrorMessage, flags))
                    return DialogResult.Abort;
                else
                    return DialogResult.OK;
            })
            .ContinueWith(x =>
            {
                Enabled = true;
                DialogResult = x.Result;
                Close();

            }, TaskScheduler.FromCurrentSynchronizationContext());

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chkFixIds_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoFixIds.Checked)
                rdoNewest.Checked = false;
        }

        private void chkNewest_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNewest.Checked)
                rdoFixIds.Checked = false;
        }
    }
}

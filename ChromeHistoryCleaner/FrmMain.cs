#region Using

using System;
using System.Numerics;
using System.Windows.Forms;
using ChromeHistoryCleaner.Properties;
using ExtensionMethods;

#endregion

namespace ChromeHistoryCleaner
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            this.InitializeComponent();
            this.tbFilePath.Text = HistoryCleaner.GetPathToHistory();
            this.LoadSettings();
        }

        private void SaveSettings()
        {
            Settings.Default.VisitCount = this.nudVisitCount.Value;
            Settings.Default.DayDef = this.nudDefDays.Value;
            Settings.Default.MakeBackup = this.cbMakeBackup.Checked;
            Settings.Default.Save();
        }

        private void LoadSettings()
        {
            this.nudVisitCount.Value = Settings.Default.VisitCount;
            this.nudDefDays.Value = Settings.Default.DayDef;
            this.cbMakeBackup.Checked = Settings.Default.MakeBackup;
        }

        private void btnStart_Click( object sender, EventArgs e )
        {
            this.btnStart.Enabled = false;
            string path = this.tbFilePath.Text;
            int visitCount = (int)this.nudVisitCount.Value;
            int dayDefs = (int)this.nudDefDays.Value;
            bool makeBackup = this.cbMakeBackup.Checked;
            BigInteger removedCount = 0;
            try
            {
                removedCount = HistoryCleaner.ClearHistory( path, visitCount, dayDefs, makeBackup );
            }
            catch ( Exception ex )
            {
                MessageBox.Show( ex.Message, strings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
            finally
            {
                MessageBox.Show( strings.RemovedInfo.F( removedCount ), strings.Information, MessageBoxButtons.OK,
                    MessageBoxIcon.Information );
                this.btnStart.Enabled = true;
            }
        }

        private void FrmMain_FormClosing( object sender, FormClosingEventArgs e )
        {
            this.SaveSettings();
        }

        private void btnSelectFile_Click( object sender, EventArgs e )
        {
            var ofd = new OpenFileDialog { Filter = "Все файлы|*.*", Multiselect = false };
            if ( ofd.ShowDialog() == DialogResult.OK )
            {
                tbFilePath.Text = ofd.FileName;
            }
        }
    }
}
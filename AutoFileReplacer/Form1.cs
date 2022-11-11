using System;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;
using System.Text;

namespace AutoFileReplacer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            LoadSettings();
            lblstatus.Text = "Running";
            Replacer.Start();
            CheckState();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;

        }
        private void btnPickRthis_Click(object sender, EventArgs e)
        {
            ofdRthis.Reset();
            ofdRthis.Title = ("Select a file to replace");
            ofdRthis.ShowDialog();
            tbFileRthis.Text = ofdRthis.FileName;
        }

        private void btnPickRwith_Click(object sender, EventArgs e)
        {

            ofdRwith.Reset();
            ofdRwith.Title = ("Select a file replacer");
            ofdRwith.ShowDialog();
            tbFileRwith.Text = ofdRwith.FileName;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            clearSelectedProcess();
        }

        private void btnSaveEntry_Click(object sender, EventArgs e)
        {

            if (tbFileRthis.Text.Length > 0)
            {
                ProcessOps.settingsJson.Interval = Convert.ToInt16(numInterval.Value);
                string replaced = tbFileRthis.Text;
                string replacer = tbFileRwith.Text;
                string name = tbProcessName.Text;
                ProcessOps.EditProcess(name, replaced, replacer);
                UpdateProcessListBox();
            }
            else
            {
                ProcessOps.updateInterval(Convert.ToInt16(numInterval.Value));
            }
            
        }
        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            if (lvProcessItems.SelectedIndices.Count <= 0)
            {
                return;
            }
            int selectedindex = lvProcessItems.SelectedIndices[0];
            if (selectedindex >= 0)
            {
                ProcessOps.RemoveProcess(selectedindex);
                UpdateProcessListBox();
            }
        }

        private void lvProcessItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvProcessItems.SelectedIndices.Count <= 0)
            {
                return;
            }
            int selectedindex = lvProcessItems.SelectedIndices[0];
            if (selectedindex >= 0)
            {
                String text = lvProcessItems.Items[selectedindex].Text;
                getProcess(selectedindex);

            }
        }
        private void LoadSettings()
        {
            ProcessOps.OpenSettingsFile();
            numInterval.Text = ProcessOps.Interval();
            //lbProcessList.Items = ProcessOps.settingsJson.Processes.ToList();
            UpdateProcessListBox();
        }
        public void UpdateProcessListBox()
        {
            lvProcessItems.Items.Clear();
            var Plist = ProcessOps.getProcesses();
            Console.WriteLine(Plist);
            //foreach (var process in Plist)
            for (int key = 0; key < Plist.Count; ++key)
            {
                ListViewItem item = new ListViewItem(key.ToString());
                item.SubItems.Add(Plist[key].Name);
                var thisFile = Path.GetFileName(Plist[key].ReplaceThis);
                item.SubItems.Add(thisFile);
                var withFile = Path.GetFileName(Plist[key].ReplaceWith);
                item.SubItems.Add(withFile);
                lvProcessItems.Items.Add(item);
                clearSelectedProcess();
            }
        }

        private void getProcess(int index)
        {
            var process = ProcessOps.getProcesses()[index];
            tbProcessName.Text = process.Name;
            tbFileRthis.Text = process.ReplaceThis;
            tbFileRwith.Text = process.ReplaceWith;
        }

        private void clearSelectedProcess()
        {
            tbFileRthis.Text = "";
            ofdRwith.Reset();
            tbFileRwith.Text = "";
            tbProcessName.Text = "";
            lvProcessItems.SelectedItems.Clear();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {


            Replacer.Stop();
            lblstatus.Text = "Stopped";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

            Replacer.Start();
            lblstatus.Text = "Running";
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_SizeChanged(object sender, EventArgs e) {
            CheckState();
        }

        private void CheckState()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon.Visible = true;
                this.ShowInTaskbar = false;
            }
            else
            {
                this.Show();
                notifyIcon.Visible = false;
                this.ShowInTaskbar = true;
            }
        }
    }
}

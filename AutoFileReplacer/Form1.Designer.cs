namespace AutoFileReplacer
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnStop = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.tbFileRthis = new System.Windows.Forms.TextBox();
            this.tbFileRwith = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPickRthis = new System.Windows.Forms.Button();
            this.btnPickRwith = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.btnSaveEntry = new System.Windows.Forms.Button();
            this.btnClearEntry = new System.Windows.Forms.Button();
            this.ofdRthis = new System.Windows.Forms.OpenFileDialog();
            this.ofdRwith = new System.Windows.Forms.OpenFileDialog();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.lvProcessItems = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStop
            // 
            this.btnStop.CausesValidation = false;
            this.btnStop.Location = new System.Drawing.Point(534, 24);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(615, 24);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 1;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // tbProcessName
            // 
            this.tbProcessName.Location = new System.Drawing.Point(100, 154);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.Size = new System.Drawing.Size(198, 20);
            this.tbProcessName.TabIndex = 3;
            this.tbProcessName.WordWrap = false;
            // 
            // tbFileRthis
            // 
            this.tbFileRthis.Location = new System.Drawing.Point(100, 78);
            this.tbFileRthis.Name = "tbFileRthis";
            this.tbFileRthis.Size = new System.Drawing.Size(471, 20);
            this.tbFileRthis.TabIndex = 1;
            this.tbFileRthis.WordWrap = false;
            // 
            // tbFileRwith
            // 
            this.tbFileRwith.Location = new System.Drawing.Point(100, 119);
            this.tbFileRwith.Name = "tbFileRwith";
            this.tbFileRwith.Size = new System.Drawing.Size(471, 20);
            this.tbFileRwith.TabIndex = 2;
            this.tbFileRwith.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Replace This:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Replace With:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPickRthis
            // 
            this.btnPickRthis.CausesValidation = false;
            this.btnPickRthis.Location = new System.Drawing.Point(594, 76);
            this.btnPickRthis.Name = "btnPickRthis";
            this.btnPickRthis.Size = new System.Drawing.Size(75, 23);
            this.btnPickRthis.TabIndex = 8;
            this.btnPickRthis.Text = "Select";
            this.btnPickRthis.UseVisualStyleBackColor = true;
            this.btnPickRthis.Click += new System.EventHandler(this.btnPickRthis_Click);
            // 
            // btnPickRwith
            // 
            this.btnPickRwith.CausesValidation = false;
            this.btnPickRwith.Location = new System.Drawing.Point(594, 117);
            this.btnPickRwith.Name = "btnPickRwith";
            this.btnPickRwith.Size = new System.Drawing.Size(75, 23);
            this.btnPickRwith.TabIndex = 9;
            this.btnPickRwith.Text = "Select";
            this.btnPickRwith.UseVisualStyleBackColor = true;
            this.btnPickRwith.Click += new System.EventHandler(this.btnPickRwith_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Interval (sec):";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Location = new System.Drawing.Point(615, 185);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEntry.TabIndex = 13;
            this.btnDeleteEntry.Text = "Delete";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // btnSaveEntry
            // 
            this.btnSaveEntry.CausesValidation = false;
            this.btnSaveEntry.Location = new System.Drawing.Point(496, 152);
            this.btnSaveEntry.Name = "btnSaveEntry";
            this.btnSaveEntry.Size = new System.Drawing.Size(75, 23);
            this.btnSaveEntry.TabIndex = 14;
            this.btnSaveEntry.Text = "Save";
            this.btnSaveEntry.UseVisualStyleBackColor = true;
            this.btnSaveEntry.Click += new System.EventHandler(this.btnSaveEntry_Click);
            // 
            // btnClearEntry
            // 
            this.btnClearEntry.CausesValidation = false;
            this.btnClearEntry.Location = new System.Drawing.Point(415, 152);
            this.btnClearEntry.Name = "btnClearEntry";
            this.btnClearEntry.Size = new System.Drawing.Size(75, 23);
            this.btnClearEntry.TabIndex = 15;
            this.btnClearEntry.Text = "Clear";
            this.btnClearEntry.UseVisualStyleBackColor = true;
            this.btnClearEntry.Click += new System.EventHandler(this.btnClearEntry_Click);
            // 
            // ofdRthis
            // 
            this.ofdRthis.FileName = "openFileDialog1";
            // 
            // ofdRwith
            // 
            this.ofdRwith.FileName = "openFileDialog1";
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(163, 27);
            this.numInterval.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(48, 20);
            this.numInterval.TabIndex = 16;
            this.numInterval.TabStop = false;
            // 
            // lvProcessItems
            // 
            this.lvProcessItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvProcessItems.FullRowSelect = true;
            this.lvProcessItems.GridLines = true;
            this.lvProcessItems.HideSelection = false;
            this.lvProcessItems.Location = new System.Drawing.Point(12, 181);
            this.lvProcessItems.Name = "lvProcessItems";
            this.lvProcessItems.Size = new System.Drawing.Size(597, 316);
            this.lvProcessItems.TabIndex = 17;
            this.lvProcessItems.UseCompatibleStateImageBehavior = false;
            this.lvProcessItems.View = System.Windows.Forms.View.Details;
            this.lvProcessItems.SelectedIndexChanged += new System.EventHandler(this.lvProcessItems_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            this.columnHeader1.Width = 30;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 96;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Replace this";
            this.columnHeader3.Width = 235;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Replace with";
            this.columnHeader4.Width = 235;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Status:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblstatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblstatus.Location = new System.Drawing.Point(386, 29);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(2, 15);
            this.lblstatus.TabIndex = 19;
            this.lblstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "notifyIcon";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 513);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvProcessItems);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.btnClearEntry);
            this.Controls.Add(this.btnSaveEntry);
            this.Controls.Add(this.btnDeleteEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnPickRwith);
            this.Controls.Add(this.btnPickRthis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFileRwith);
            this.Controls.Add(this.tbFileRthis);
            this.Controls.Add(this.tbProcessName);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnStop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoFileReplacer";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.SizeChanged += new System.EventHandler(this.frmMain_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox tbProcessName;
        private System.Windows.Forms.TextBox tbFileRthis;
        private System.Windows.Forms.TextBox tbFileRwith;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPickRthis;
        private System.Windows.Forms.Button btnPickRwith;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.Button btnSaveEntry;
        private System.Windows.Forms.Button btnClearEntry;
        private System.Windows.Forms.OpenFileDialog ofdRthis;
        private System.Windows.Forms.OpenFileDialog ofdRwith;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.ListView lvProcessItems;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}


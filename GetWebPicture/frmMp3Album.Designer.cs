namespace Mp3AlbumCoverUpdater
{
    partial class frmMp3Album
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.ptbNew = new System.Windows.Forms.PictureBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.gitHubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ptpOld = new System.Windows.Forms.PictureBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.cobEngine = new System.Windows.Forms.ComboBox();
            this.flpPicture = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenDir = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnUpdateAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNew)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptpOld)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(637, 39);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(63, 24);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(460, 41);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(170, 21);
            this.txtKeyWord.TabIndex = 2;
            // 
            // ptbNew
            // 
            this.ptbNew.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbNew.Location = new System.Drawing.Point(873, 261);
            this.ptbNew.Name = "ptbNew";
            this.ptbNew.Size = new System.Drawing.Size(240, 259);
            this.ptbNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNew.TabIndex = 5;
            this.ptbNew.TabStop = false;
            this.ptbNew.DoubleClick += new System.EventHandler(this.ptbNew_DoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(554, 521);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(55, 23);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "更 新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFile,
            this.gitHubToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(971, 22);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // OpenFile
            // 
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(80, 18);
            this.OpenFile.Text = "打开文件夹";
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // gitHubToolStripMenuItem
            // 
            this.gitHubToolStripMenuItem.Name = "gitHubToolStripMenuItem";
            this.gitHubToolStripMenuItem.Size = new System.Drawing.Size(60, 18);
            this.gitHubToolStripMenuItem.Text = "GitHub";
            this.gitHubToolStripMenuItem.Click += new System.EventHandler(this.gitHubToolStripMenuItem_Click);
            // 
            // ptpOld
            // 
            this.ptpOld.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptpOld.Location = new System.Drawing.Point(873, 6);
            this.ptpOld.Name = "ptpOld";
            this.ptpOld.Size = new System.Drawing.Size(240, 240);
            this.ptpOld.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptpOld.TabIndex = 5;
            this.ptpOld.TabStop = false;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvList.Location = new System.Drawing.Point(0, 0);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowTemplate.Height = 23;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(384, 556);
            this.dgvList.TabIndex = 9;
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // cobEngine
            // 
            this.cobEngine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobEngine.FormattingEnabled = true;
            this.cobEngine.Items.AddRange(new object[] {
            "QQ",
            "163",
            "BaiDu",
            "SouGou",
            "360",
            "Google"});
            this.cobEngine.Location = new System.Drawing.Point(390, 42);
            this.cobEngine.Name = "cobEngine";
            this.cobEngine.Size = new System.Drawing.Size(64, 20);
            this.cobEngine.TabIndex = 10;
            // 
            // flpPicture
            // 
            this.flpPicture.AutoScroll = true;
            this.flpPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpPicture.Location = new System.Drawing.Point(390, 71);
            this.flpPicture.Name = "flpPicture";
            this.flpPicture.Size = new System.Drawing.Size(464, 449);
            this.flpPicture.TabIndex = 11;
            this.flpPicture.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(727, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 12;
            // 
            // OpenDir
            // 
            this.OpenDir.Location = new System.Drawing.Point(391, 6);
            this.OpenDir.Name = "OpenDir";
            this.OpenDir.Size = new System.Drawing.Size(78, 23);
            this.OpenDir.TabIndex = 13;
            this.OpenDir.Text = "打开文件夹";
            this.OpenDir.UseVisualStyleBackColor = true;
            this.OpenDir.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(389, 532);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 12);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // btnUpdateAll
            // 
            this.btnUpdateAll.Location = new System.Drawing.Point(637, 521);
            this.btnUpdateAll.Name = "btnUpdateAll";
            this.btnUpdateAll.Size = new System.Drawing.Size(92, 23);
            this.btnUpdateAll.TabIndex = 15;
            this.btnUpdateAll.Text = "全文件夹更新";
            this.btnUpdateAll.UseVisualStyleBackColor = true;
            this.btnUpdateAll.Click += new System.EventHandler(this.btnUpdateAll_Click);
            // 
            // frmMp3Album
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 556);
            this.Controls.Add(this.btnUpdateAll);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.OpenDir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpPicture);
            this.Controls.Add(this.cobEngine);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.ptpOld);
            this.Controls.Add(this.ptbNew);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMp3Album";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "音频专辑封面更新——Modify By Coby";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbNew)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptpOld)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.PictureBox ptbNew;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem OpenFile;
        private System.Windows.Forms.PictureBox ptpOld;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.ComboBox cobEngine;
        private System.Windows.Forms.FlowLayoutPanel flpPicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem gitHubToolStripMenuItem;
        private System.Windows.Forms.Button OpenDir;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnUpdateAll;
    }
}


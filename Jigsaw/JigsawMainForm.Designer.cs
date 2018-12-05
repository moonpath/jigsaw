namespace Jigsaw
{
    partial class JigsawMainForm
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JigsawMainForm));
            this.start = new System.Windows.Forms.Button();
            this.easy = new System.Windows.Forms.RadioButton();
            this.normal = new System.Windows.Forms.RadioButton();
            this.hard = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.Button();
            this.records = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.游戏ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ControlPanel = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.choosePicture = new System.Windows.Forms.OpenFileDialog();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ShowPictureBox = new System.Windows.Forms.PictureBox();
            this.menu.SuspendLayout();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(33, 279);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(107, 23);
            this.start.TabIndex = 6;
            this.start.Text = "开始";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // easy
            // 
            this.easy.AutoSize = true;
            this.easy.Checked = true;
            this.easy.Location = new System.Drawing.Point(16, 22);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(47, 16);
            this.easy.TabIndex = 8;
            this.easy.TabStop = true;
            this.easy.Text = "简单";
            this.easy.UseVisualStyleBackColor = true;
            // 
            // normal
            // 
            this.normal.AutoSize = true;
            this.normal.Location = new System.Drawing.Point(63, 22);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(47, 16);
            this.normal.TabIndex = 9;
            this.normal.Text = "普通";
            this.normal.UseVisualStyleBackColor = true;
            // 
            // hard
            // 
            this.hard.AutoSize = true;
            this.hard.Location = new System.Drawing.Point(110, 22);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(47, 16);
            this.hard.TabIndex = 10;
            this.hard.Text = "困难";
            this.hard.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(33, 337);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(108, 23);
            this.add.TabIndex = 11;
            this.add.Text = "选择";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // records
            // 
            this.records.Location = new System.Drawing.Point(33, 308);
            this.records.Name = "records";
            this.records.Size = new System.Drawing.Size(108, 23);
            this.records.TabIndex = 12;
            this.records.Text = "记录";
            this.records.UseVisualStyleBackColor = true;
            this.records.Click += new System.EventHandler(this.records_Click);
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.游戏ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(556, 25);
            this.menu.TabIndex = 13;
            this.menu.Text = "menuStrip1";
            // 
            // 游戏ToolStripMenuItem
            // 
            this.游戏ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StartToolStripMenuItem,
            this.RecordToolStripMenuItem,
            this.AddToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.游戏ToolStripMenuItem.Name = "游戏ToolStripMenuItem";
            this.游戏ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.游戏ToolStripMenuItem.Text = "游戏";
            // 
            // StartToolStripMenuItem
            // 
            this.StartToolStripMenuItem.Name = "StartToolStripMenuItem";
            this.StartToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.StartToolStripMenuItem.Text = "开始";
            this.StartToolStripMenuItem.Click += new System.EventHandler(this.StartToolStripMenuItem_Click);
            // 
            // RecordToolStripMenuItem
            // 
            this.RecordToolStripMenuItem.Name = "RecordToolStripMenuItem";
            this.RecordToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.RecordToolStripMenuItem.Text = "记录";
            this.RecordToolStripMenuItem.Click += new System.EventHandler(this.RecordToolStripMenuItem_Click);
            // 
            // AddToolStripMenuItem
            // 
            this.AddToolStripMenuItem.Name = "AddToolStripMenuItem";
            this.AddToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.AddToolStripMenuItem.Text = "选择";
            this.AddToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.ExitToolStripMenuItem.Text = "退出";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.说明ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 说明ToolStripMenuItem
            // 
            this.说明ToolStripMenuItem.Name = "说明ToolStripMenuItem";
            this.说明ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.说明ToolStripMenuItem.Text = "说明";
            this.说明ToolStripMenuItem.Click += new System.EventHandler(this.说明ToolStripMenuItem_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.Control;
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Location = new System.Drawing.Point(1, 26);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(380, 380);
            this.MainPanel.TabIndex = 14;
            // 
            // ControlPanel
            // 
            this.ControlPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlPanel.Controls.Add(this.timeLabel);
            this.ControlPanel.Controls.Add(this.ShowPictureBox);
            this.ControlPanel.Controls.Add(this.add);
            this.ControlPanel.Controls.Add(this.records);
            this.ControlPanel.Controls.Add(this.start);
            this.ControlPanel.Controls.Add(this.hard);
            this.ControlPanel.Controls.Add(this.normal);
            this.ControlPanel.Controls.Add(this.easy);
            this.ControlPanel.Location = new System.Drawing.Point(382, 26);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Size = new System.Drawing.Size(173, 380);
            this.ControlPanel.TabIndex = 15;
            // 
            // timeLabel
            // 
            this.timeLabel.Location = new System.Drawing.Point(16, 52);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(141, 20);
            this.timeLabel.TabIndex = 14;
            this.timeLabel.Text = "用时：0秒";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // choosePicture
            // 
            this.choosePicture.Filter = "Picture|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ShowPictureBox
            // 
            this.ShowPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShowPictureBox.Location = new System.Drawing.Point(1, 89);
            this.ShowPictureBox.Name = "ShowPictureBox";
            this.ShowPictureBox.Size = new System.Drawing.Size(169, 169);
            this.ShowPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ShowPictureBox.TabIndex = 13;
            this.ShowPictureBox.TabStop = false;
            this.ShowPictureBox.Click += new System.EventHandler(this.ShowPictureBox_Click);
            // 
            // JigsawMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 407);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "JigsawMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "梦羽拼图";
            this.Load += new System.EventHandler(this.JigsawMainForm_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShowPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.RadioButton easy;
        private System.Windows.Forms.RadioButton normal;
        private System.Windows.Forms.RadioButton hard;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button records;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem 游戏ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RecordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 说明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ControlPanel;
        private System.Windows.Forms.PictureBox ShowPictureBox;
        private System.Windows.Forms.OpenFileDialog choosePicture;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}


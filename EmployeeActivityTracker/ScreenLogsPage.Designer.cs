namespace EmployeeActivityTracker
{
    partial class ScreenLogsPage
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.prevPanel = new System.Windows.Forms.Panel();
            this.prevButton = new MaterialSkin.Controls.MaterialButton();
            this.nextPanel = new System.Windows.Forms.Panel();
            this.nextButton = new MaterialSkin.Controls.MaterialButton();
            this.imageLoadProgess = new MaterialSkin.Controls.MaterialProgressBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.separatorLeft = new System.Windows.Forms.Panel();
            this.userSelectPanel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.screenlogsGrid = new System.Windows.Forms.DataGridView();
            this.computernameSettingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usersComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.dateLabel = new MaterialSkin.Controls.MaterialLabel();
            this.idLabel = new MaterialSkin.Controls.MaterialLabel();
            this.mainPanel.SuspendLayout();
            this.prevPanel.SuspendLayout();
            this.nextPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.userSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenlogsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.idLabel);
            this.mainPanel.Controls.Add(this.dateLabel);
            this.mainPanel.Controls.Add(this.prevPanel);
            this.mainPanel.Controls.Add(this.nextPanel);
            this.mainPanel.Controls.Add(this.imageLoadProgess);
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(2, 57);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(900, 494);
            this.mainPanel.TabIndex = 0;
            // 
            // prevPanel
            // 
            this.prevPanel.Controls.Add(this.prevButton);
            this.prevPanel.Location = new System.Drawing.Point(802, 446);
            this.prevPanel.Name = "prevPanel";
            this.prevPanel.Size = new System.Drawing.Size(40, 36);
            this.prevPanel.TabIndex = 28;
            // 
            // prevButton
            // 
            this.prevButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.prevButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.prevButton.Depth = 0;
            this.prevButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prevButton.DrawShadows = false;
            this.prevButton.Enabled = false;
            this.prevButton.HighEmphasis = true;
            this.prevButton.Icon = global::EmployeeActivityTracker.Properties.Resources.ArrowPrev;
            this.prevButton.Location = new System.Drawing.Point(0, 0);
            this.prevButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.prevButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.prevButton.Name = "prevButton";
            this.prevButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.prevButton.Size = new System.Drawing.Size(40, 36);
            this.prevButton.TabIndex = 23;
            this.prevButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.prevButton.UseAccentColor = false;
            this.prevButton.UseVisualStyleBackColor = true;
            this.prevButton.Click += new System.EventHandler(this.prevButton_Click);
            // 
            // nextPanel
            // 
            this.nextPanel.Controls.Add(this.nextButton);
            this.nextPanel.Location = new System.Drawing.Point(848, 446);
            this.nextPanel.Name = "nextPanel";
            this.nextPanel.Size = new System.Drawing.Size(40, 36);
            this.nextPanel.TabIndex = 25;
            // 
            // nextButton
            // 
            this.nextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nextButton.Depth = 0;
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextButton.Enabled = false;
            this.nextButton.HighEmphasis = true;
            this.nextButton.Icon = global::EmployeeActivityTracker.Properties.Resources.ArrowNext;
            this.nextButton.Location = new System.Drawing.Point(0, 0);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nextButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextButton.Name = "nextButton";
            this.nextButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.nextButton.Size = new System.Drawing.Size(40, 36);
            this.nextButton.TabIndex = 1;
            this.nextButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nextButton.UseAccentColor = false;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // imageLoadProgess
            // 
            this.imageLoadProgess.Depth = 0;
            this.imageLoadProgess.Location = new System.Drawing.Point(62, 446);
            this.imageLoadProgess.Maximum = 8;
            this.imageLoadProgess.MouseState = MaterialSkin.MouseState.HOVER;
            this.imageLoadProgess.Name = "imageLoadProgess";
            this.imageLoadProgess.Size = new System.Drawing.Size(714, 5);
            this.imageLoadProgess.TabIndex = 2;
            this.imageLoadProgess.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.pictureBox1.Location = new System.Drawing.Point(62, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(768, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // separatorLeft
            // 
            this.separatorLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.separatorLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.separatorLeft.Location = new System.Drawing.Point(0, 0);
            this.separatorLeft.Name = "separatorLeft";
            this.separatorLeft.Size = new System.Drawing.Size(2, 551);
            this.separatorLeft.TabIndex = 10;
            // 
            // userSelectPanel
            // 
            this.userSelectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userSelectPanel.Controls.Add(this.panel2);
            this.userSelectPanel.Controls.Add(this.screenlogsGrid);
            this.userSelectPanel.Controls.Add(this.computernameSettingLabel);
            this.userSelectPanel.Controls.Add(this.usersComboBox);
            this.userSelectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userSelectPanel.Location = new System.Drawing.Point(2, 0);
            this.userSelectPanel.Name = "userSelectPanel";
            this.userSelectPanel.Size = new System.Drawing.Size(900, 57);
            this.userSelectPanel.TabIndex = 15;
            this.userSelectPanel.TabStop = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 2);
            this.panel2.TabIndex = 14;
            // 
            // screenlogsGrid
            // 
            this.screenlogsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.screenlogsGrid.Location = new System.Drawing.Point(263, 3);
            this.screenlogsGrid.Name = "screenlogsGrid";
            this.screenlogsGrid.Size = new System.Drawing.Size(34, 10);
            this.screenlogsGrid.TabIndex = 27;
            this.screenlogsGrid.Visible = false;
            // 
            // computernameSettingLabel
            // 
            this.computernameSettingLabel.AutoSize = true;
            this.computernameSettingLabel.Depth = 0;
            this.computernameSettingLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.computernameSettingLabel.Location = new System.Drawing.Point(9, 18);
            this.computernameSettingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.computernameSettingLabel.Name = "computernameSettingLabel";
            this.computernameSettingLabel.Size = new System.Drawing.Size(210, 19);
            this.computernameSettingLabel.TabIndex = 0;
            this.computernameSettingLabel.Text = "Имя компьютера (в логах) -";
            // 
            // usersComboBox
            // 
            this.usersComboBox.AutoResize = false;
            this.usersComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.usersComboBox.Depth = 0;
            this.usersComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.usersComboBox.DropDownHeight = 174;
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.DropDownWidth = 121;
            this.usersComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.usersComboBox.ForeColor = System.Drawing.Color.Green;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.IntegralHeight = false;
            this.usersComboBox.ItemHeight = 43;
            this.usersComboBox.Location = new System.Drawing.Point(294, 3);
            this.usersComboBox.MaxDropDownItems = 4;
            this.usersComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(603, 49);
            this.usersComboBox.StartIndex = 0;
            this.usersComboBox.TabIndex = 11;
            this.usersComboBox.SelectedIndexChanged += new System.EventHandler(this.usersComboBox_SelectedIndexChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Depth = 0;
            this.dateLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateLabel.Location = new System.Drawing.Point(220, 456);
            this.dateLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(51, 19);
            this.dateLabel.TabIndex = 30;
            this.dateLabel.Text = "Дата - ";
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Depth = 0;
            this.idLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idLabel.Location = new System.Drawing.Point(59, 456);
            this.idLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(28, 19);
            this.idLabel.TabIndex = 31;
            this.idLabel.Text = "ID - ";
            // 
            // ScreenLogsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(902, 551);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.userSelectPanel);
            this.Controls.Add(this.separatorLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScreenLogsPage";
            this.Text = "ScreenLogsPage";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.prevPanel.ResumeLayout(false);
            this.prevPanel.PerformLayout();
            this.nextPanel.ResumeLayout(false);
            this.nextPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.userSelectPanel.ResumeLayout(false);
            this.userSelectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenlogsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.PictureBox pictureBox1;
        public MaterialSkin.Controls.MaterialProgressBar imageLoadProgess;
        public MaterialSkin.Controls.MaterialButton nextButton;
        private System.Windows.Forms.Panel separatorLeft;
        private System.Windows.Forms.Panel nextPanel;
        public System.Windows.Forms.Panel userSelectPanel;
        public System.Windows.Forms.DataGridView screenlogsGrid;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel computernameSettingLabel;
        public MaterialSkin.Controls.MaterialComboBox usersComboBox;
        private System.Windows.Forms.Panel prevPanel;
        public MaterialSkin.Controls.MaterialButton prevButton;
        public MaterialSkin.Controls.MaterialLabel idLabel;
        public MaterialSkin.Controls.MaterialLabel dateLabel;
    }
}
namespace EmployeeActivityTracker
{
    partial class KeyLogsPage
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
            this.separatorLeft = new System.Windows.Forms.Panel();
            this.usersComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.userSelectPanel = new System.Windows.Forms.Panel();
            this.keylogsGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.computernameSettingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.logStrip0 = new System.Windows.Forms.Panel();
            this.dateBox0 = new MaterialSkin.Controls.MaterialLabel();
            this.idBox0 = new MaterialSkin.Controls.MaterialLabel();
            this.dateLabel0 = new MaterialSkin.Controls.MaterialLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idLabel0 = new MaterialSkin.Controls.MaterialLabel();
            this.logBox0 = new System.Windows.Forms.RichTextBox();
            this.divider0 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.logStrip1 = new System.Windows.Forms.Panel();
            this.dateBox1 = new MaterialSkin.Controls.MaterialLabel();
            this.idBox1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.idLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.logBox1 = new System.Windows.Forms.RichTextBox();
            this.divider1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.logStrip2 = new System.Windows.Forms.Panel();
            this.dateBox2 = new MaterialSkin.Controls.MaterialLabel();
            this.idBox2 = new MaterialSkin.Controls.MaterialLabel();
            this.dateLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.idLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.logBox2 = new System.Windows.Forms.RichTextBox();
            this.divider2 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.nextPanel = new System.Windows.Forms.Panel();
            this.nextButton = new MaterialSkin.Controls.MaterialButton();
            this.prevPanel = new System.Windows.Forms.Panel();
            this.prevButton = new MaterialSkin.Controls.MaterialButton();
            this.pagesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernamesGrid = new System.Windows.Forms.DataGridView();
            this.userSelectPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keylogsGrid)).BeginInit();
            this.logStrip0.SuspendLayout();
            this.divider0.SuspendLayout();
            this.logStrip1.SuspendLayout();
            this.divider1.SuspendLayout();
            this.logStrip2.SuspendLayout();
            this.divider2.SuspendLayout();
            this.nextPanel.SuspendLayout();
            this.prevPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernamesGrid)).BeginInit();
            this.SuspendLayout();
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
            // userSelectPanel
            // 
            this.userSelectPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userSelectPanel.Controls.Add(this.keylogsGrid);
            this.userSelectPanel.Controls.Add(this.panel2);
            this.userSelectPanel.Controls.Add(this.computernameSettingLabel);
            this.userSelectPanel.Controls.Add(this.usernamesGrid);
            this.userSelectPanel.Controls.Add(this.usersComboBox);
            this.userSelectPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.userSelectPanel.Location = new System.Drawing.Point(2, 0);
            this.userSelectPanel.Name = "userSelectPanel";
            this.userSelectPanel.Size = new System.Drawing.Size(900, 57);
            this.userSelectPanel.TabIndex = 14;
            this.userSelectPanel.TabStop = true;
            // 
            // keylogsGrid
            // 
            this.keylogsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.keylogsGrid.Location = new System.Drawing.Point(240, 17);
            this.keylogsGrid.Name = "keylogsGrid";
            this.keylogsGrid.Size = new System.Drawing.Size(48, 10);
            this.keylogsGrid.TabIndex = 27;
            this.keylogsGrid.Visible = false;
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
            // logStrip0
            // 
            this.logStrip0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logStrip0.Controls.Add(this.dateBox0);
            this.logStrip0.Controls.Add(this.idBox0);
            this.logStrip0.Controls.Add(this.dateLabel0);
            this.logStrip0.Controls.Add(this.panel1);
            this.logStrip0.Controls.Add(this.idLabel0);
            this.logStrip0.Controls.Add(this.logBox0);
            this.logStrip0.Controls.Add(this.divider0);
            this.logStrip0.Dock = System.Windows.Forms.DockStyle.Top;
            this.logStrip0.Location = new System.Drawing.Point(2, 57);
            this.logStrip0.Name = "logStrip0";
            this.logStrip0.Size = new System.Drawing.Size(900, 145);
            this.logStrip0.TabIndex = 16;
            this.logStrip0.TabStop = true;
            // 
            // dateBox0
            // 
            this.dateBox0.AutoSize = true;
            this.dateBox0.Depth = 0;
            this.dateBox0.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateBox0.Location = new System.Drawing.Point(64, 89);
            this.dateBox0.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateBox0.Name = "dateBox0";
            this.dateBox0.Size = new System.Drawing.Size(151, 19);
            this.dateBox0.TabIndex = 25;
            this.dateBox0.Text = "Данные не найдены";
            // 
            // idBox0
            // 
            this.idBox0.AutoSize = true;
            this.idBox0.Depth = 0;
            this.idBox0.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idBox0.Location = new System.Drawing.Point(64, 27);
            this.idBox0.MouseState = MaterialSkin.MouseState.HOVER;
            this.idBox0.Name = "idBox0";
            this.idBox0.Size = new System.Drawing.Size(151, 19);
            this.idBox0.TabIndex = 22;
            this.idBox0.Text = "Данные не найдены";
            // 
            // dateLabel0
            // 
            this.dateLabel0.AutoSize = true;
            this.dateLabel0.Depth = 0;
            this.dateLabel0.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateLabel0.Location = new System.Drawing.Point(9, 89);
            this.dateLabel0.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateLabel0.Name = "dateLabel0";
            this.dateLabel0.Size = new System.Drawing.Size(47, 19);
            this.dateLabel0.TabIndex = 21;
            this.dateLabel0.Text = "Дата -";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(294, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 135);
            this.panel1.TabIndex = 20;
            // 
            // idLabel0
            // 
            this.idLabel0.AutoSize = true;
            this.idLabel0.Depth = 0;
            this.idLabel0.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idLabel0.Location = new System.Drawing.Point(9, 27);
            this.idLabel0.MouseState = MaterialSkin.MouseState.HOVER;
            this.idLabel0.Name = "idLabel0";
            this.idLabel0.Size = new System.Drawing.Size(24, 19);
            this.idLabel0.TabIndex = 14;
            this.idLabel0.Text = "ID -";
            // 
            // logBox0
            // 
            this.logBox0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.logBox0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox0.Dock = System.Windows.Forms.DockStyle.Right;
            this.logBox0.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox0.ForeColor = System.Drawing.Color.White;
            this.logBox0.Location = new System.Drawing.Point(296, 0);
            this.logBox0.Name = "logBox0";
            this.logBox0.Size = new System.Drawing.Size(604, 135);
            this.logBox0.TabIndex = 18;
            this.logBox0.Text = "";
            // 
            // divider0
            // 
            this.divider0.Controls.Add(this.panel8);
            this.divider0.Controls.Add(this.panel3);
            this.divider0.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.divider0.Location = new System.Drawing.Point(0, 135);
            this.divider0.Name = "divider0";
            this.divider0.Size = new System.Drawing.Size(900, 10);
            this.divider0.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 8);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(900, 2);
            this.panel8.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 2);
            this.panel3.TabIndex = 15;
            // 
            // logStrip1
            // 
            this.logStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logStrip1.Controls.Add(this.dateBox1);
            this.logStrip1.Controls.Add(this.idBox1);
            this.logStrip1.Controls.Add(this.dateLabel1);
            this.logStrip1.Controls.Add(this.panel5);
            this.logStrip1.Controls.Add(this.idLabel1);
            this.logStrip1.Controls.Add(this.logBox1);
            this.logStrip1.Controls.Add(this.divider1);
            this.logStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.logStrip1.Location = new System.Drawing.Point(2, 202);
            this.logStrip1.Name = "logStrip1";
            this.logStrip1.Size = new System.Drawing.Size(900, 145);
            this.logStrip1.TabIndex = 17;
            this.logStrip1.TabStop = true;
            // 
            // dateBox1
            // 
            this.dateBox1.AutoSize = true;
            this.dateBox1.Depth = 0;
            this.dateBox1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateBox1.Location = new System.Drawing.Point(64, 89);
            this.dateBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateBox1.Name = "dateBox1";
            this.dateBox1.Size = new System.Drawing.Size(151, 19);
            this.dateBox1.TabIndex = 26;
            this.dateBox1.Text = "Данные не найдены";
            // 
            // idBox1
            // 
            this.idBox1.AutoSize = true;
            this.idBox1.Depth = 0;
            this.idBox1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idBox1.Location = new System.Drawing.Point(64, 27);
            this.idBox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.idBox1.Name = "idBox1";
            this.idBox1.Size = new System.Drawing.Size(151, 19);
            this.idBox1.TabIndex = 23;
            this.idBox1.Text = "Данные не найдены";
            // 
            // dateLabel1
            // 
            this.dateLabel1.AutoSize = true;
            this.dateLabel1.Depth = 0;
            this.dateLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateLabel1.Location = new System.Drawing.Point(9, 89);
            this.dateLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateLabel1.Name = "dateLabel1";
            this.dateLabel1.Size = new System.Drawing.Size(47, 19);
            this.dateLabel1.TabIndex = 21;
            this.dateLabel1.Text = "Дата -";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(294, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 135);
            this.panel5.TabIndex = 20;
            // 
            // idLabel1
            // 
            this.idLabel1.AutoSize = true;
            this.idLabel1.Depth = 0;
            this.idLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idLabel1.Location = new System.Drawing.Point(9, 27);
            this.idLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(24, 19);
            this.idLabel1.TabIndex = 14;
            this.idLabel1.Text = "ID -";
            // 
            // logBox1
            // 
            this.logBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.logBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.logBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox1.ForeColor = System.Drawing.Color.White;
            this.logBox1.Location = new System.Drawing.Point(296, 0);
            this.logBox1.Name = "logBox1";
            this.logBox1.Size = new System.Drawing.Size(604, 135);
            this.logBox1.TabIndex = 18;
            this.logBox1.Text = "";
            // 
            // divider1
            // 
            this.divider1.Controls.Add(this.panel9);
            this.divider1.Controls.Add(this.panel7);
            this.divider1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.divider1.Location = new System.Drawing.Point(0, 135);
            this.divider1.Name = "divider1";
            this.divider1.Size = new System.Drawing.Size(900, 10);
            this.divider1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 8);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(900, 2);
            this.panel9.TabIndex = 16;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(900, 2);
            this.panel7.TabIndex = 15;
            // 
            // logStrip2
            // 
            this.logStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logStrip2.Controls.Add(this.dateBox2);
            this.logStrip2.Controls.Add(this.idBox2);
            this.logStrip2.Controls.Add(this.dateLabel2);
            this.logStrip2.Controls.Add(this.panel11);
            this.logStrip2.Controls.Add(this.idLabel2);
            this.logStrip2.Controls.Add(this.logBox2);
            this.logStrip2.Controls.Add(this.divider2);
            this.logStrip2.Dock = System.Windows.Forms.DockStyle.Top;
            this.logStrip2.Location = new System.Drawing.Point(2, 347);
            this.logStrip2.Name = "logStrip2";
            this.logStrip2.Size = new System.Drawing.Size(900, 145);
            this.logStrip2.TabIndex = 18;
            this.logStrip2.TabStop = true;
            // 
            // dateBox2
            // 
            this.dateBox2.AutoSize = true;
            this.dateBox2.Depth = 0;
            this.dateBox2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateBox2.Location = new System.Drawing.Point(64, 89);
            this.dateBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateBox2.Name = "dateBox2";
            this.dateBox2.Size = new System.Drawing.Size(151, 19);
            this.dateBox2.TabIndex = 25;
            this.dateBox2.Text = "Данные не найдены";
            // 
            // idBox2
            // 
            this.idBox2.AutoSize = true;
            this.idBox2.Depth = 0;
            this.idBox2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idBox2.Location = new System.Drawing.Point(64, 27);
            this.idBox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.idBox2.Name = "idBox2";
            this.idBox2.Size = new System.Drawing.Size(151, 19);
            this.idBox2.TabIndex = 24;
            this.idBox2.Text = "Данные не найдены";
            // 
            // dateLabel2
            // 
            this.dateLabel2.AutoSize = true;
            this.dateLabel2.Depth = 0;
            this.dateLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dateLabel2.Location = new System.Drawing.Point(9, 89);
            this.dateLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.dateLabel2.Name = "dateLabel2";
            this.dateLabel2.Size = new System.Drawing.Size(47, 19);
            this.dateLabel2.TabIndex = 21;
            this.dateLabel2.Text = "Дата -";
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel11.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel11.Location = new System.Drawing.Point(294, 0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(2, 135);
            this.panel11.TabIndex = 20;
            // 
            // idLabel2
            // 
            this.idLabel2.AutoSize = true;
            this.idLabel2.Depth = 0;
            this.idLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.idLabel2.Location = new System.Drawing.Point(9, 27);
            this.idLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.idLabel2.Name = "idLabel2";
            this.idLabel2.Size = new System.Drawing.Size(24, 19);
            this.idLabel2.TabIndex = 14;
            this.idLabel2.Text = "ID -";
            // 
            // logBox2
            // 
            this.logBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.logBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.logBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox2.ForeColor = System.Drawing.Color.White;
            this.logBox2.Location = new System.Drawing.Point(296, 0);
            this.logBox2.Name = "logBox2";
            this.logBox2.Size = new System.Drawing.Size(604, 135);
            this.logBox2.TabIndex = 18;
            this.logBox2.Text = "";
            // 
            // divider2
            // 
            this.divider2.Controls.Add(this.panel14);
            this.divider2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.divider2.Location = new System.Drawing.Point(0, 135);
            this.divider2.Name = "divider2";
            this.divider2.Size = new System.Drawing.Size(900, 10);
            this.divider2.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.panel14.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel14.Location = new System.Drawing.Point(0, 0);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(900, 2);
            this.panel14.TabIndex = 15;
            // 
            // nextPanel
            // 
            this.nextPanel.Controls.Add(this.nextButton);
            this.nextPanel.Location = new System.Drawing.Point(850, 503);
            this.nextPanel.Name = "nextPanel";
            this.nextPanel.Size = new System.Drawing.Size(40, 36);
            this.nextPanel.TabIndex = 24;
            // 
            // nextButton
            // 
            this.nextButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.nextButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.nextButton.Depth = 0;
            this.nextButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextButton.DrawShadows = false;
            this.nextButton.Enabled = false;
            this.nextButton.HighEmphasis = true;
            this.nextButton.Icon = global::EmployeeActivityTracker.Properties.Resources.ArrowNext;
            this.nextButton.Location = new System.Drawing.Point(0, 0);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.nextButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.nextButton.Name = "nextButton";
            this.nextButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.nextButton.Size = new System.Drawing.Size(40, 36);
            this.nextButton.TabIndex = 23;
            this.nextButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.nextButton.UseAccentColor = false;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // prevPanel
            // 
            this.prevPanel.Controls.Add(this.prevButton);
            this.prevPanel.Location = new System.Drawing.Point(803, 503);
            this.prevPanel.Name = "prevPanel";
            this.prevPanel.Size = new System.Drawing.Size(40, 36);
            this.prevPanel.TabIndex = 25;
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
            // pagesLabel
            // 
            this.pagesLabel.AutoSize = true;
            this.pagesLabel.Depth = 0;
            this.pagesLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.pagesLabel.Location = new System.Drawing.Point(11, 513);
            this.pagesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.pagesLabel.Name = "pagesLabel";
            this.pagesLabel.Size = new System.Drawing.Size(90, 19);
            this.pagesLabel.TabIndex = 26;
            this.pagesLabel.Text = "Страница: 0";
            // 
            // usernamesGrid
            // 
            this.usernamesGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usernamesGrid.Location = new System.Drawing.Point(240, 3);
            this.usernamesGrid.Name = "usernamesGrid";
            this.usernamesGrid.Size = new System.Drawing.Size(48, 10);
            this.usernamesGrid.TabIndex = 13;
            this.usernamesGrid.Visible = false;
            // 
            // KeyLogsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(902, 551);
            this.Controls.Add(this.pagesLabel);
            this.Controls.Add(this.prevPanel);
            this.Controls.Add(this.nextPanel);
            this.Controls.Add(this.logStrip2);
            this.Controls.Add(this.logStrip1);
            this.Controls.Add(this.logStrip0);
            this.Controls.Add(this.userSelectPanel);
            this.Controls.Add(this.separatorLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KeyLogsPage";
            this.Text = "Form1";
            this.userSelectPanel.ResumeLayout(false);
            this.userSelectPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.keylogsGrid)).EndInit();
            this.logStrip0.ResumeLayout(false);
            this.logStrip0.PerformLayout();
            this.divider0.ResumeLayout(false);
            this.logStrip1.ResumeLayout(false);
            this.logStrip1.PerformLayout();
            this.divider1.ResumeLayout(false);
            this.logStrip2.ResumeLayout(false);
            this.logStrip2.PerformLayout();
            this.divider2.ResumeLayout(false);
            this.nextPanel.ResumeLayout(false);
            this.nextPanel.PerformLayout();
            this.prevPanel.ResumeLayout(false);
            this.prevPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usernamesGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel separatorLeft;
        public MaterialSkin.Controls.MaterialComboBox usersComboBox;
        public System.Windows.Forms.Panel userSelectPanel;
        private MaterialSkin.Controls.MaterialLabel computernameSettingLabel;
        public System.Windows.Forms.Panel logStrip0;
        private System.Windows.Forms.Panel divider0;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.Panel logStrip1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel divider1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        public System.Windows.Forms.Panel logStrip2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel divider2;
        private System.Windows.Forms.Panel panel14;
        public MaterialSkin.Controls.MaterialButton nextButton;
        private System.Windows.Forms.Panel nextPanel;
        private System.Windows.Forms.Panel prevPanel;
        public MaterialSkin.Controls.MaterialButton prevButton;
        private MaterialSkin.Controls.MaterialLabel pagesLabel;
        public System.Windows.Forms.DataGridView keylogsGrid;
        public MaterialSkin.Controls.MaterialLabel idLabel0;
        public MaterialSkin.Controls.MaterialLabel dateLabel0;
        public MaterialSkin.Controls.MaterialLabel dateLabel1;
        public MaterialSkin.Controls.MaterialLabel idLabel1;
        public MaterialSkin.Controls.MaterialLabel dateLabel2;
        public MaterialSkin.Controls.MaterialLabel idLabel2;
        public MaterialSkin.Controls.MaterialLabel dateBox0;
        public MaterialSkin.Controls.MaterialLabel idBox0;
        public MaterialSkin.Controls.MaterialLabel dateBox1;
        public MaterialSkin.Controls.MaterialLabel idBox1;
        public MaterialSkin.Controls.MaterialLabel dateBox2;
        public MaterialSkin.Controls.MaterialLabel idBox2;
        public System.Windows.Forms.RichTextBox logBox0;
        public System.Windows.Forms.RichTextBox logBox1;
        public System.Windows.Forms.RichTextBox logBox2;
        public System.Windows.Forms.DataGridView usernamesGrid;
    }
}
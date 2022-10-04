namespace HotelManagment
{
    partial class Home
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
            this.phome = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblwelcome = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbltime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.PanelMove = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnbuyurtma = new System.Windows.Forms.Button();
            this.btnroom = new System.Windows.Forms.Button();
            this.btnclient = new System.Windows.Forms.Button();
            this.btnboshsahifa = new System.Windows.Forms.Button();
            this.pblogin = new System.Windows.Forms.PictureBox();
            this.userControlRoom1 = new HotelManagment.UserControlSetting.UserControlRoom();
            this.userControlSetting2 = new HotelManagment.UserControlSetting.UserControlSetting();
            this.userControlClient1 = new HotelManagment.UserControlSetting.UserControlClient();
            this.phome.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).BeginInit();
            this.SuspendLayout();
            // 
            // phome
            // 
            this.phome.BackColor = System.Drawing.Color.White;
            this.phome.Controls.Add(this.panel2);
            this.phome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phome.Location = new System.Drawing.Point(0, 0);
            this.phome.Name = "phome";
            this.phome.Size = new System.Drawing.Size(1300, 700);
            this.phome.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 700);
            this.panel2.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.userControlRoom1);
            this.panel7.Controls.Add(this.userControlSetting2);
            this.panel7.Controls.Add(this.userControlClient1);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(250, 200);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1050, 450);
            this.panel7.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel5.Controls.Add(this.lblwelcome);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(250, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1050, 200);
            this.panel5.TabIndex = 0;
            // 
            // lblwelcome
            // 
            this.lblwelcome.AutoSize = true;
            this.lblwelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblwelcome.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblwelcome.ForeColor = System.Drawing.Color.White;
            this.lblwelcome.Location = new System.Drawing.Point(15, 139);
            this.lblwelcome.Name = "lblwelcome";
            this.lblwelcome.Size = new System.Drawing.Size(116, 20);
            this.lblwelcome.TabIndex = 0;
            this.lblwelcome.Text = "Xush Kelibsiz: ";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel6.Controls.Add(this.linkLabel1);
            this.panel6.Controls.Add(this.pictureBox1);
            this.panel6.Controls.Add(this.lbltime);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1050, 100);
            this.panel6.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(0, 8);
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.linkLabel1.Location = new System.Drawing.Point(960, 50);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 26);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lbltime.Location = new System.Drawing.Point(15, 46);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(15, 20);
            this.lbltime.TabIndex = 0;
            this.lbltime.Text = "?";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel3.Location = new System.Drawing.Point(250, 650);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1050, 50);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(329, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ishlab chiqildi. ©️ 2022. Zikrulla Production";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 700);
            this.panel1.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel8.Controls.Add(this.PanelMove);
            this.panel8.Controls.Add(this.btnsettings);
            this.panel8.Controls.Add(this.btnbuyurtma);
            this.panel8.Controls.Add(this.btnroom);
            this.panel8.Controls.Add(this.btnclient);
            this.panel8.Controls.Add(this.btnboshsahifa);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 200);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 500);
            this.panel8.TabIndex = 0;
            // 
            // PanelMove
            // 
            this.PanelMove.BackColor = System.Drawing.Color.White;
            this.PanelMove.Location = new System.Drawing.Point(15, 5);
            this.PanelMove.Name = "PanelMove";
            this.PanelMove.Size = new System.Drawing.Size(10, 40);
            this.PanelMove.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pblogin);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 200);
            this.panel4.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(85, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(35, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hotel Managment";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox1.Image = global::HotelManagment.Properties.Resources.useraccount;
            this.pictureBox1.Location = new System.Drawing.Point(910, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnsettings
            // 
            this.btnsettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnsettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnsettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnsettings.ForeColor = System.Drawing.Color.White;
            this.btnsettings.Image = global::HotelManagment.Properties.Resources.usersettings;
            this.btnsettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsettings.Location = new System.Drawing.Point(39, 165);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(200, 40);
            this.btnsettings.TabIndex = 0;
            this.btnsettings.Text = "Sozlamalar        ";
            this.btnsettings.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsettings.UseVisualStyleBackColor = false;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            // 
            // btnbuyurtma
            // 
            this.btnbuyurtma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnbuyurtma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnbuyurtma.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnbuyurtma.FlatAppearance.BorderSize = 0;
            this.btnbuyurtma.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnbuyurtma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnbuyurtma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnbuyurtma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuyurtma.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnbuyurtma.ForeColor = System.Drawing.Color.White;
            this.btnbuyurtma.Image = global::HotelManagment.Properties.Resources.hotel_bell;
            this.btnbuyurtma.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnbuyurtma.Location = new System.Drawing.Point(40, 125);
            this.btnbuyurtma.Name = "btnbuyurtma";
            this.btnbuyurtma.Size = new System.Drawing.Size(200, 40);
            this.btnbuyurtma.TabIndex = 0;
            this.btnbuyurtma.Text = "Buyurtma qilish";
            this.btnbuyurtma.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnbuyurtma.UseVisualStyleBackColor = false;
            this.btnbuyurtma.Click += new System.EventHandler(this.btnbuyurtma_Click);
            // 
            // btnroom
            // 
            this.btnroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnroom.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnroom.FlatAppearance.BorderSize = 0;
            this.btnroom.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnroom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnroom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroom.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnroom.ForeColor = System.Drawing.Color.White;
            this.btnroom.Image = global::HotelManagment.Properties.Resources.bed;
            this.btnroom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnroom.Location = new System.Drawing.Point(40, 85);
            this.btnroom.Name = "btnroom";
            this.btnroom.Size = new System.Drawing.Size(200, 40);
            this.btnroom.TabIndex = 0;
            this.btnroom.Text = "Xona                   ";
            this.btnroom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnroom.UseVisualStyleBackColor = false;
            this.btnroom.Click += new System.EventHandler(this.btnroom_Click);
            // 
            // btnclient
            // 
            this.btnclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnclient.FlatAppearance.BorderSize = 0;
            this.btnclient.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnclient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnclient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclient.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnclient.ForeColor = System.Drawing.Color.White;
            this.btnclient.Image = global::HotelManagment.Properties.Resources.customer;
            this.btnclient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclient.Location = new System.Drawing.Point(40, 45);
            this.btnclient.Name = "btnclient";
            this.btnclient.Size = new System.Drawing.Size(200, 40);
            this.btnclient.TabIndex = 0;
            this.btnclient.Text = "Mijoz                  ";
            this.btnclient.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclient.UseVisualStyleBackColor = false;
            this.btnclient.Click += new System.EventHandler(this.btnclient_Click);
            // 
            // btnboshsahifa
            // 
            this.btnboshsahifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnboshsahifa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnboshsahifa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnboshsahifa.FlatAppearance.BorderSize = 0;
            this.btnboshsahifa.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnboshsahifa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Turquoise;
            this.btnboshsahifa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnboshsahifa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnboshsahifa.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnboshsahifa.ForeColor = System.Drawing.Color.White;
            this.btnboshsahifa.Image = global::HotelManagment.Properties.Resources.dashboards;
            this.btnboshsahifa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnboshsahifa.Location = new System.Drawing.Point(40, 5);
            this.btnboshsahifa.Name = "btnboshsahifa";
            this.btnboshsahifa.Size = new System.Drawing.Size(200, 40);
            this.btnboshsahifa.TabIndex = 0;
            this.btnboshsahifa.Text = "Bosh sahifa      ";
            this.btnboshsahifa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnboshsahifa.UseVisualStyleBackColor = false;
            this.btnboshsahifa.Click += new System.EventHandler(this.btnboshsahifa_Click);
            // 
            // pblogin
            // 
            this.pblogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pblogin.BackColor = System.Drawing.Color.Transparent;
            this.pblogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pblogin.Image = global::HotelManagment.Properties.Resources.home128;
            this.pblogin.Location = new System.Drawing.Point(75, 25);
            this.pblogin.Name = "pblogin";
            this.pblogin.Size = new System.Drawing.Size(100, 100);
            this.pblogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogin.TabIndex = 2;
            this.pblogin.TabStop = false;
            // 
            // userControlRoom1
            // 
            this.userControlRoom1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRoom1.Location = new System.Drawing.Point(0, 0);
            this.userControlRoom1.Name = "userControlRoom1";
            this.userControlRoom1.Size = new System.Drawing.Size(1050, 450);
            this.userControlRoom1.TabIndex = 1;
            this.userControlRoom1.Visible = false;
            // 
            // userControlSetting2
            // 
            this.userControlSetting2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlSetting2.Location = new System.Drawing.Point(0, 0);
            this.userControlSetting2.Name = "userControlSetting2";
            this.userControlSetting2.Size = new System.Drawing.Size(1050, 450);
            this.userControlSetting2.TabIndex = 0;
            this.userControlSetting2.Visible = false;
            // 
            // userControlClient1
            // 
            this.userControlClient1.BackColor = System.Drawing.Color.White;
            this.userControlClient1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlClient1.Location = new System.Drawing.Point(0, 0);
            this.userControlClient1.Name = "userControlClient1";
            this.userControlClient1.Size = new System.Drawing.Size(1050, 450);
            this.userControlClient1.TabIndex = 0;
            this.userControlClient1.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.phome);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.phome.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pblogin;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel phome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblwelcome;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Button btnboshsahifa;
        private System.Windows.Forms.Panel PanelMove;
        private System.Windows.Forms.Button btnbuyurtma;
        private System.Windows.Forms.Button btnroom;
        private System.Windows.Forms.Button btnclient;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private UserControlSetting.UserControlSetting userControlSetting1;
        private System.Windows.Forms.Panel panel7;
        private UserControlSetting.UserControlSetting userControlSetting2;
        private UserControlSetting.UserControlClient userControlClient1;
        private UserControlSetting.UserControlRoom userControlRoom1;
    }
}
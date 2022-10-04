namespace HotelManagment.UserControlSetting
{
    partial class UserControlRoom
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlRoom = new System.Windows.Forms.TabControl();
            this.tabPageAddRoom = new System.Windows.Forms.TabPage();
            this.rbAddNo = new System.Windows.Forms.RadioButton();
            this.rbAddYes = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBoxaddtype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnaddroom = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtaddphone = new System.Windows.Forms.TextBox();
            this.txtaddroom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchRoom = new System.Windows.Forms.TabPage();
            this.comboBoxSearchRoom = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsearchRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpdateRoom = new System.Windows.Forms.TabPage();
            this.radioButtonUpdateNo = new System.Windows.Forms.RadioButton();
            this.radioButtonUpdateYes = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxupdate = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtupdatephone = new System.Windows.Forms.TextBox();
            this.txtupdatenumber = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btndeleteroom = new System.Windows.Forms.Button();
            this.btnupdateroom = new System.Windows.Forms.Button();
            this.tabControlRoom.SuspendLayout();
            this.tabPageAddRoom.SuspendLayout();
            this.tabPageSearchRoom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPageUpdateRoom.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlRoom
            // 
            this.tabControlRoom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlRoom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlRoom.Controls.Add(this.tabPageAddRoom);
            this.tabControlRoom.Controls.Add(this.tabPageSearchRoom);
            this.tabControlRoom.Controls.Add(this.tabPageUpdateRoom);
            this.tabControlRoom.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlRoom.Location = new System.Drawing.Point(25, 25);
            this.tabControlRoom.Multiline = true;
            this.tabControlRoom.Name = "tabControlRoom";
            this.tabControlRoom.SelectedIndex = 0;
            this.tabControlRoom.Size = new System.Drawing.Size(1000, 400);
            this.tabControlRoom.TabIndex = 2;
            // 
            // tabPageAddRoom
            // 
            this.tabPageAddRoom.Controls.Add(this.rbAddNo);
            this.tabPageAddRoom.Controls.Add(this.rbAddYes);
            this.tabPageAddRoom.Controls.Add(this.label8);
            this.tabPageAddRoom.Controls.Add(this.comboBoxaddtype);
            this.tabPageAddRoom.Controls.Add(this.label2);
            this.tabPageAddRoom.Controls.Add(this.btnaddroom);
            this.tabPageAddRoom.Controls.Add(this.label3);
            this.tabPageAddRoom.Controls.Add(this.lblusername);
            this.tabPageAddRoom.Controls.Add(this.txtaddphone);
            this.tabPageAddRoom.Controls.Add(this.txtaddroom);
            this.tabPageAddRoom.Controls.Add(this.label1);
            this.tabPageAddRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddRoom.Name = "tabPageAddRoom";
            this.tabPageAddRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddRoom.Size = new System.Drawing.Size(992, 367);
            this.tabPageAddRoom.TabIndex = 0;
            this.tabPageAddRoom.Text = "Xona Qo\'shish";
            this.tabPageAddRoom.UseVisualStyleBackColor = true;
            this.tabPageAddRoom.Click += new System.EventHandler(this.tabPageAddRoom_Click);
            this.tabPageAddRoom.Enter += new System.EventHandler(this.tabPageAddRoom_Enter);
            this.tabPageAddRoom.Leave += new System.EventHandler(this.tabPageAddRoom_Leave);
            // 
            // rbAddNo
            // 
            this.rbAddNo.AutoSize = true;
            this.rbAddNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAddNo.Location = new System.Drawing.Point(597, 193);
            this.rbAddNo.Name = "rbAddNo";
            this.rbAddNo.Size = new System.Drawing.Size(56, 24);
            this.rbAddNo.TabIndex = 0;
            this.rbAddNo.Text = "Yo\'q";
            this.rbAddNo.UseVisualStyleBackColor = true;
            // 
            // rbAddYes
            // 
            this.rbAddYes.AutoSize = true;
            this.rbAddYes.Checked = true;
            this.rbAddYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rbAddYes.Location = new System.Drawing.Point(597, 162);
            this.rbAddYes.Name = "rbAddYes";
            this.rbAddYes.Size = new System.Drawing.Size(46, 24);
            this.rbAddYes.TabIndex = 0;
            this.rbAddYes.TabStop = true;
            this.rbAddYes.Text = "Ha";
            this.rbAddYes.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(500, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Bo\'shmi";
            // 
            // comboBoxaddtype
            // 
            this.comboBoxaddtype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxaddtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxaddtype.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.comboBoxaddtype.FormattingEnabled = true;
            this.comboBoxaddtype.Items.AddRange(new object[] {
            "Bir kishilik",
            "Ikki kishilik",
            "Uch kishilik",
            "To\'rt kishilik",
            "Oilaviy"});
            this.comboBoxaddtype.Location = new System.Drawing.Point(183, 189);
            this.comboBoxaddtype.Name = "comboBoxaddtype";
            this.comboBoxaddtype.Size = new System.Drawing.Size(276, 28);
            this.comboBoxaddtype.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label2.Location = new System.Drawing.Point(179, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Toyifasi";
            // 
            // btnaddroom
            // 
            this.btnaddroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnaddroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddroom.FlatAppearance.BorderSize = 0;
            this.btnaddroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddroom.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddroom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnaddroom.Location = new System.Drawing.Point(183, 277);
            this.btnaddroom.Name = "btnaddroom";
            this.btnaddroom.Size = new System.Drawing.Size(120, 40);
            this.btnaddroom.TabIndex = 6;
            this.btnaddroom.Text = "Add";
            this.btnaddroom.UseVisualStyleBackColor = false;
            this.btnaddroom.Click += new System.EventHandler(this.btnaddroom_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(500, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Telefon №";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lblusername.Location = new System.Drawing.Point(179, 66);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(67, 20);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Xona №";
            // 
            // txtaddphone
            // 
            this.txtaddphone.Location = new System.Drawing.Point(504, 89);
            this.txtaddphone.Name = "txtaddphone";
            this.txtaddphone.Size = new System.Drawing.Size(276, 27);
            this.txtaddphone.TabIndex = 2;
            // 
            // txtaddroom
            // 
            this.txtaddroom.Location = new System.Drawing.Point(183, 89);
            this.txtaddroom.Name = "txtaddroom";
            this.txtaddroom.Size = new System.Drawing.Size(276, 27);
            this.txtaddroom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xona Qo\'shish:";
            // 
            // tabPageSearchRoom
            // 
            this.tabPageSearchRoom.Controls.Add(this.comboBoxSearchRoom);
            this.tabPageSearchRoom.Controls.Add(this.dataGridView);
            this.tabPageSearchRoom.Controls.Add(this.txtsearchRoom);
            this.tabPageSearchRoom.Controls.Add(this.label4);
            this.tabPageSearchRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchRoom.Name = "tabPageSearchRoom";
            this.tabPageSearchRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchRoom.Size = new System.Drawing.Size(992, 367);
            this.tabPageSearchRoom.TabIndex = 1;
            this.tabPageSearchRoom.Text = "Search User";
            this.tabPageSearchRoom.UseVisualStyleBackColor = true;
            this.tabPageSearchRoom.Enter += new System.EventHandler(this.tabPageSearchRoom_Enter);
            this.tabPageSearchRoom.Leave += new System.EventHandler(this.tabPageSearchRoom_Leave);
            // 
            // comboBoxSearchRoom
            // 
            this.comboBoxSearchRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSearchRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.comboBoxSearchRoom.FormattingEnabled = true;
            this.comboBoxSearchRoom.Items.AddRange(new object[] {
            "Ism",
            "Familya",
            "Pasport №",
            "Manzil"});
            this.comboBoxSearchRoom.Location = new System.Drawing.Point(277, 61);
            this.comboBoxSearchRoom.Name = "comboBoxSearchRoom";
            this.comboBoxSearchRoom.Size = new System.Drawing.Size(200, 28);
            this.comboBoxSearchRoom.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView.Location = new System.Drawing.Point(50, 131);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(900, 205);
            this.dataGridView.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "rm_number";
            this.Column1.FillWeight = 50.1661F;
            this.Column1.HeaderText = "Xona №";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "rm_phone";
            this.Column2.FillWeight = 106.599F;
            this.Column2.HeaderText = "Telefon №";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "rm_type";
            this.Column3.FillWeight = 105.6738F;
            this.Column3.HeaderText = "Toyifasi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "rm_free";
            this.Column4.FillWeight = 91.04388F;
            this.Column4.HeaderText = "Bo\'shmi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // txtsearchRoom
            // 
            this.txtsearchRoom.Location = new System.Drawing.Point(510, 61);
            this.txtsearchRoom.Name = "txtsearchRoom";
            this.txtsearchRoom.Size = new System.Drawing.Size(200, 27);
            this.txtsearchRoom.TabIndex = 0;
            this.txtsearchRoom.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mijoz Qidiish";
            // 
            // tabPageUpdateRoom
            // 
            this.tabPageUpdateRoom.Controls.Add(this.radioButtonUpdateNo);
            this.tabPageUpdateRoom.Controls.Add(this.radioButtonUpdateYes);
            this.tabPageUpdateRoom.Controls.Add(this.label9);
            this.tabPageUpdateRoom.Controls.Add(this.comboBoxupdate);
            this.tabPageUpdateRoom.Controls.Add(this.label10);
            this.tabPageUpdateRoom.Controls.Add(this.label11);
            this.tabPageUpdateRoom.Controls.Add(this.label12);
            this.tabPageUpdateRoom.Controls.Add(this.txtupdatephone);
            this.tabPageUpdateRoom.Controls.Add(this.txtupdatenumber);
            this.tabPageUpdateRoom.Controls.Add(this.label16);
            this.tabPageUpdateRoom.Controls.Add(this.btndeleteroom);
            this.tabPageUpdateRoom.Controls.Add(this.btnupdateroom);
            this.tabPageUpdateRoom.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdateRoom.Name = "tabPageUpdateRoom";
            this.tabPageUpdateRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdateRoom.Size = new System.Drawing.Size(992, 367);
            this.tabPageUpdateRoom.TabIndex = 2;
            this.tabPageUpdateRoom.Text = "Update, Delete";
            this.tabPageUpdateRoom.UseVisualStyleBackColor = true;
            this.tabPageUpdateRoom.Leave += new System.EventHandler(this.tabPageUpdateRoom_Leave);
            // 
            // radioButtonUpdateNo
            // 
            this.radioButtonUpdateNo.AutoSize = true;
            this.radioButtonUpdateNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonUpdateNo.Location = new System.Drawing.Point(594, 178);
            this.radioButtonUpdateNo.Name = "radioButtonUpdateNo";
            this.radioButtonUpdateNo.Size = new System.Drawing.Size(56, 24);
            this.radioButtonUpdateNo.TabIndex = 10;
            this.radioButtonUpdateNo.Text = "Yo\'q";
            this.radioButtonUpdateNo.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpdateYes
            // 
            this.radioButtonUpdateYes.AutoSize = true;
            this.radioButtonUpdateYes.Checked = true;
            this.radioButtonUpdateYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButtonUpdateYes.Location = new System.Drawing.Point(594, 147);
            this.radioButtonUpdateYes.Name = "radioButtonUpdateYes";
            this.radioButtonUpdateYes.Size = new System.Drawing.Size(46, 24);
            this.radioButtonUpdateYes.TabIndex = 11;
            this.radioButtonUpdateYes.TabStop = true;
            this.radioButtonUpdateYes.Text = "Ha";
            this.radioButtonUpdateYes.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label9.Location = new System.Drawing.Point(497, 151);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Bo\'shmi";
            // 
            // comboBoxupdate
            // 
            this.comboBoxupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxupdate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.comboBoxupdate.FormattingEnabled = true;
            this.comboBoxupdate.Location = new System.Drawing.Point(180, 174);
            this.comboBoxupdate.Name = "comboBoxupdate";
            this.comboBoxupdate.Size = new System.Drawing.Size(276, 28);
            this.comboBoxupdate.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label10.Location = new System.Drawing.Point(176, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "Toyifasi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label11.Location = new System.Drawing.Point(493, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Telefon №";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label12.Location = new System.Drawing.Point(172, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Xona №";
            // 
            // txtupdatephone
            // 
            this.txtupdatephone.Location = new System.Drawing.Point(497, 76);
            this.txtupdatephone.Name = "txtupdatephone";
            this.txtupdatephone.Size = new System.Drawing.Size(276, 27);
            this.txtupdatephone.TabIndex = 16;
            // 
            // txtupdatenumber
            // 
            this.txtupdatenumber.Location = new System.Drawing.Point(176, 76);
            this.txtupdatenumber.Name = "txtupdatenumber";
            this.txtupdatenumber.Size = new System.Drawing.Size(276, 27);
            this.txtupdatenumber.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label16.Location = new System.Drawing.Point(6, 3);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 20);
            this.label16.TabIndex = 14;
            this.label16.Text = "Xona Qo\'shish:";
            // 
            // btndeleteroom
            // 
            this.btndeleteroom.BackColor = System.Drawing.Color.Red;
            this.btndeleteroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeleteroom.FlatAppearance.BorderSize = 0;
            this.btndeleteroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteroom.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteroom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeleteroom.Location = new System.Drawing.Point(315, 251);
            this.btndeleteroom.Name = "btndeleteroom";
            this.btndeleteroom.Size = new System.Drawing.Size(120, 40);
            this.btndeleteroom.TabIndex = 7;
            this.btndeleteroom.TabStop = false;
            this.btndeleteroom.Text = "Delete";
            this.btndeleteroom.UseVisualStyleBackColor = false;
            // 
            // btnupdateroom
            // 
            this.btnupdateroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnupdateroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdateroom.FlatAppearance.BorderSize = 0;
            this.btnupdateroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateroom.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateroom.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdateroom.Location = new System.Drawing.Point(176, 251);
            this.btnupdateroom.Name = "btnupdateroom";
            this.btnupdateroom.Size = new System.Drawing.Size(120, 40);
            this.btnupdateroom.TabIndex = 6;
            this.btnupdateroom.TabStop = false;
            this.btnupdateroom.Text = "Update";
            this.btnupdateroom.UseVisualStyleBackColor = false;
            // 
            // UserControlRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlRoom);
            this.Name = "UserControlRoom";
            this.Size = new System.Drawing.Size(1050, 450);
            this.tabControlRoom.ResumeLayout(false);
            this.tabPageAddRoom.ResumeLayout(false);
            this.tabPageAddRoom.PerformLayout();
            this.tabPageSearchRoom.ResumeLayout(false);
            this.tabPageSearchRoom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPageUpdateRoom.ResumeLayout(false);
            this.tabPageUpdateRoom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlRoom;
        private System.Windows.Forms.TabPage tabPageAddRoom;
        private System.Windows.Forms.Button btnaddroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtaddphone;
        private System.Windows.Forms.TextBox txtaddroom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchRoom;
        private System.Windows.Forms.ComboBox comboBoxSearchRoom;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox txtsearchRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpdateRoom;
        private System.Windows.Forms.Button btndeleteroom;
        private System.Windows.Forms.Button btnupdateroom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbAddNo;
        private System.Windows.Forms.RadioButton rbAddYes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxaddtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.RadioButton radioButtonUpdateNo;
        private System.Windows.Forms.RadioButton radioButtonUpdateYes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxupdate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtupdatephone;
        private System.Windows.Forms.TextBox txtupdatenumber;
        private System.Windows.Forms.Label label16;
    }
}

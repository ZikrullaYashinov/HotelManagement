namespace HotelManagment.UserControlSetting
{
    partial class UserControlClient
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
            this.tabControlClient = new System.Windows.Forms.TabControl();
            this.tabPageAddClient = new System.Windows.Forms.TabPage();
            this.btnaddclient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.txtadress = new System.Windows.Forms.TextBox();
            this.txtpasportnumber = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageSearchClient = new System.Windows.Forms.TabPage();
            this.comboBoxData = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.btndeleteclient = new System.Windows.Forms.Button();
            this.btnupdateclient = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtupdatelastname = new System.Windows.Forms.TextBox();
            this.txtupdatephone = new System.Windows.Forms.TextBox();
            this.txtupdateadress = new System.Windows.Forms.TextBox();
            this.txtupdatepasport = new System.Windows.Forms.TextBox();
            this.txtupdatefirstname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControlClient.SuspendLayout();
            this.tabPageAddClient.SuspendLayout();
            this.tabPageSearchClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabPageUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlClient
            // 
            this.tabControlClient.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControlClient.Controls.Add(this.tabPageAddClient);
            this.tabControlClient.Controls.Add(this.tabPageSearchClient);
            this.tabControlClient.Controls.Add(this.tabPageUpdate);
            this.tabControlClient.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControlClient.Location = new System.Drawing.Point(25, 25);
            this.tabControlClient.Multiline = true;
            this.tabControlClient.Name = "tabControlClient";
            this.tabControlClient.SelectedIndex = 0;
            this.tabControlClient.Size = new System.Drawing.Size(1000, 400);
            this.tabControlClient.TabIndex = 1;
            // 
            // tabPageAddClient
            // 
            this.tabPageAddClient.Controls.Add(this.btnaddclient);
            this.tabPageAddClient.Controls.Add(this.label3);
            this.tabPageAddClient.Controls.Add(this.label9);
            this.tabPageAddClient.Controls.Add(this.label10);
            this.tabPageAddClient.Controls.Add(this.label8);
            this.tabPageAddClient.Controls.Add(this.lblusername);
            this.tabPageAddClient.Controls.Add(this.txtlastname);
            this.tabPageAddClient.Controls.Add(this.txtphonenumber);
            this.tabPageAddClient.Controls.Add(this.txtadress);
            this.tabPageAddClient.Controls.Add(this.txtpasportnumber);
            this.tabPageAddClient.Controls.Add(this.txtfirstname);
            this.tabPageAddClient.Controls.Add(this.label1);
            this.tabPageAddClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageAddClient.Name = "tabPageAddClient";
            this.tabPageAddClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAddClient.Size = new System.Drawing.Size(992, 367);
            this.tabPageAddClient.TabIndex = 0;
            this.tabPageAddClient.Text = "Mijoz Qo\'shish";
            this.tabPageAddClient.UseVisualStyleBackColor = true;
            this.tabPageAddClient.Leave += new System.EventHandler(this.tabPageAddClient_Leave);
            // 
            // btnaddclient
            // 
            this.btnaddclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnaddclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnaddclient.FlatAppearance.BorderSize = 0;
            this.btnaddclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddclient.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnaddclient.Location = new System.Drawing.Point(183, 303);
            this.btnaddclient.Name = "btnaddclient";
            this.btnaddclient.Size = new System.Drawing.Size(120, 40);
            this.btnaddclient.TabIndex = 6;
            this.btnaddclient.Text = "Add";
            this.btnaddclient.UseVisualStyleBackColor = false;
            this.btnaddclient.Click += new System.EventHandler(this.btnaddclient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label3.Location = new System.Drawing.Point(500, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Familya";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label9.Location = new System.Drawing.Point(500, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Telefon raqam";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label10.Location = new System.Drawing.Point(179, 169);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Manzil";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label8.Location = new System.Drawing.Point(179, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Pasport raqam";
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.lblusername.Location = new System.Drawing.Point(179, 35);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(35, 20);
            this.lblusername.TabIndex = 0;
            this.lblusername.Text = "Ism";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(504, 58);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(276, 27);
            this.txtlastname.TabIndex = 2;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(504, 124);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(276, 27);
            this.txtphonenumber.TabIndex = 4;
            // 
            // txtadress
            // 
            this.txtadress.Location = new System.Drawing.Point(183, 192);
            this.txtadress.Multiline = true;
            this.txtadress.Name = "txtadress";
            this.txtadress.Size = new System.Drawing.Size(597, 99);
            this.txtadress.TabIndex = 5;
            // 
            // txtpasportnumber
            // 
            this.txtpasportnumber.Location = new System.Drawing.Point(183, 124);
            this.txtpasportnumber.Name = "txtpasportnumber";
            this.txtpasportnumber.Size = new System.Drawing.Size(276, 27);
            this.txtpasportnumber.TabIndex = 3;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(183, 58);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(276, 27);
            this.txtfirstname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mijoz Qo\'shish:";
            // 
            // tabPageSearchClient
            // 
            this.tabPageSearchClient.Controls.Add(this.comboBoxData);
            this.tabPageSearchClient.Controls.Add(this.dataGridView);
            this.tabPageSearchClient.Controls.Add(this.txtsearch);
            this.tabPageSearchClient.Controls.Add(this.label4);
            this.tabPageSearchClient.Location = new System.Drawing.Point(4, 4);
            this.tabPageSearchClient.Name = "tabPageSearchClient";
            this.tabPageSearchClient.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearchClient.Size = new System.Drawing.Size(992, 367);
            this.tabPageSearchClient.TabIndex = 1;
            this.tabPageSearchClient.Text = "Search User";
            this.tabPageSearchClient.UseVisualStyleBackColor = true;
            this.tabPageSearchClient.Enter += new System.EventHandler(this.tabPageSearchClient_Enter);
            this.tabPageSearchClient.Leave += new System.EventHandler(this.tabPageSearchClient_Leave);
            // 
            // comboBoxData
            // 
            this.comboBoxData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.comboBoxData.FormattingEnabled = true;
            this.comboBoxData.Items.AddRange(new object[] {
            "Ism",
            "Familya",
            "Pasport №",
            "Manzil"});
            this.comboBoxData.Location = new System.Drawing.Point(277, 61);
            this.comboBoxData.Name = "comboBoxData";
            this.comboBoxData.Size = new System.Drawing.Size(200, 28);
            this.comboBoxData.TabIndex = 0;
            this.comboBoxData.SelectedIndexChanged += new System.EventHandler(this.comboBoxData_SelectedIndexChanged);
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
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView.Location = new System.Drawing.Point(50, 131);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(900, 205);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "cl_id";
            this.Column1.FillWeight = 50.1661F;
            this.Column1.HeaderText = "Id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "cl_firstname";
            this.Column2.FillWeight = 106.599F;
            this.Column2.HeaderText = "Ism";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "cl_lastname";
            this.Column3.FillWeight = 105.6738F;
            this.Column3.HeaderText = "Familya";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "cl_pasport";
            this.Column4.FillWeight = 91.04388F;
            this.Column4.HeaderText = "Pasport №";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "cl_phone";
            this.Column5.FillWeight = 90.45503F;
            this.Column5.HeaderText = "Telefon №";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "cl_adress";
            this.Column6.FillWeight = 156.0622F;
            this.Column6.HeaderText = "Manzil";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(510, 61);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(200, 27);
            this.txtsearch.TabIndex = 0;
            this.txtsearch.TabStop = false;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
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
            // tabPageUpdate
            // 
            this.tabPageUpdate.Controls.Add(this.btndeleteclient);
            this.tabPageUpdate.Controls.Add(this.btnupdateclient);
            this.tabPageUpdate.Controls.Add(this.label5);
            this.tabPageUpdate.Controls.Add(this.label6);
            this.tabPageUpdate.Controls.Add(this.label13);
            this.tabPageUpdate.Controls.Add(this.label14);
            this.tabPageUpdate.Controls.Add(this.label15);
            this.tabPageUpdate.Controls.Add(this.txtupdatelastname);
            this.tabPageUpdate.Controls.Add(this.txtupdatephone);
            this.tabPageUpdate.Controls.Add(this.txtupdateadress);
            this.tabPageUpdate.Controls.Add(this.txtupdatepasport);
            this.tabPageUpdate.Controls.Add(this.txtupdatefirstname);
            this.tabPageUpdate.Controls.Add(this.label7);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 4);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUpdate.Size = new System.Drawing.Size(992, 367);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update, Delete";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            this.tabPageUpdate.Leave += new System.EventHandler(this.tabPageUpdate_Leave);
            // 
            // btndeleteclient
            // 
            this.btndeleteclient.BackColor = System.Drawing.Color.Red;
            this.btndeleteclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndeleteclient.FlatAppearance.BorderSize = 0;
            this.btndeleteclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndeleteclient.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndeleteclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndeleteclient.Location = new System.Drawing.Point(377, 306);
            this.btndeleteclient.Name = "btndeleteclient";
            this.btndeleteclient.Size = new System.Drawing.Size(120, 40);
            this.btndeleteclient.TabIndex = 7;
            this.btndeleteclient.TabStop = false;
            this.btndeleteclient.Text = "Delete";
            this.btndeleteclient.UseVisualStyleBackColor = false;
            this.btndeleteclient.Click += new System.EventHandler(this.btndeleteclient_Click);
            // 
            // btnupdateclient
            // 
            this.btnupdateclient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.btnupdateclient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnupdateclient.FlatAppearance.BorderSize = 0;
            this.btnupdateclient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdateclient.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdateclient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdateclient.Location = new System.Drawing.Point(221, 306);
            this.btnupdateclient.Name = "btnupdateclient";
            this.btnupdateclient.Size = new System.Drawing.Size(120, 40);
            this.btnupdateclient.TabIndex = 6;
            this.btnupdateclient.TabStop = false;
            this.btnupdateclient.Text = "Update";
            this.btnupdateclient.UseVisualStyleBackColor = false;
            this.btnupdateclient.Click += new System.EventHandler(this.btnupdateclient_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label5.Location = new System.Drawing.Point(538, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Familya";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label6.Location = new System.Drawing.Point(538, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Telefon raqam";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label13.Location = new System.Drawing.Point(217, 157);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Manzil";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label14.Location = new System.Drawing.Point(217, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Paspor raqam";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label15.Location = new System.Drawing.Point(217, 23);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Ism";
            // 
            // txtupdatelastname
            // 
            this.txtupdatelastname.Location = new System.Drawing.Point(542, 46);
            this.txtupdatelastname.Name = "txtupdatelastname";
            this.txtupdatelastname.Size = new System.Drawing.Size(276, 27);
            this.txtupdatelastname.TabIndex = 2;
            // 
            // txtupdatephone
            // 
            this.txtupdatephone.Location = new System.Drawing.Point(542, 112);
            this.txtupdatephone.Name = "txtupdatephone";
            this.txtupdatephone.Size = new System.Drawing.Size(276, 27);
            this.txtupdatephone.TabIndex = 4;
            // 
            // txtupdateadress
            // 
            this.txtupdateadress.Location = new System.Drawing.Point(221, 180);
            this.txtupdateadress.Multiline = true;
            this.txtupdateadress.Name = "txtupdateadress";
            this.txtupdateadress.Size = new System.Drawing.Size(597, 99);
            this.txtupdateadress.TabIndex = 5;
            // 
            // txtupdatepasport
            // 
            this.txtupdatepasport.Location = new System.Drawing.Point(221, 112);
            this.txtupdatepasport.Name = "txtupdatepasport";
            this.txtupdatepasport.Size = new System.Drawing.Size(276, 27);
            this.txtupdatepasport.TabIndex = 3;
            // 
            // txtupdatefirstname
            // 
            this.txtupdatefirstname.Location = new System.Drawing.Point(221, 46);
            this.txtupdatefirstname.Name = "txtupdatefirstname";
            this.txtupdatefirstname.Size = new System.Drawing.Size(276, 27);
            this.txtupdatefirstname.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(198)))), ((int)(((byte)(218)))));
            this.label7.Location = new System.Drawing.Point(10, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Foydalanuvchi O\'chirish";
            // 
            // UserControlClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlClient);
            this.Name = "UserControlClient";
            this.Size = new System.Drawing.Size(1050, 450);
            this.tabControlClient.ResumeLayout(false);
            this.tabPageAddClient.ResumeLayout(false);
            this.tabPageAddClient.PerformLayout();
            this.tabPageSearchClient.ResumeLayout(false);
            this.tabPageSearchClient.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabPageUpdate.ResumeLayout(false);
            this.tabPageUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlClient;
        private System.Windows.Forms.TabPage tabPageAddClient;
        private System.Windows.Forms.Button btnaddclient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.TextBox txtadress;
        private System.Windows.Forms.TextBox txtpasportnumber;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageSearchClient;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtupdatelastname;
        private System.Windows.Forms.TextBox txtupdatephone;
        private System.Windows.Forms.TextBox txtupdateadress;
        private System.Windows.Forms.TextBox txtupdatepasport;
        private System.Windows.Forms.TextBox txtupdatefirstname;
        private System.Windows.Forms.Button btndeleteclient;
        private System.Windows.Forms.Button btnupdateclient;
        private System.Windows.Forms.ComboBox comboBoxData;
    }
}

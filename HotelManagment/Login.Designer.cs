namespace HotelManagment
{
    partial class Login
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbopen = new System.Windows.Forms.PictureBox();
            this.pbclose = new System.Windows.Forms.PictureBox();
            this.lblhomename = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pblogin = new System.Windows.Forms.PictureBox();
            this.txtlogin = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbopen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 700);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox2.Image = global::HotelManagment.Properties.Resources.receptionist1;
            this.pictureBox2.Location = new System.Drawing.Point(850, 200);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(300, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.pbopen);
            this.panel2.Controls.Add(this.pbclose);
            this.panel2.Controls.Add(this.lblhomename);
            this.panel2.Controls.Add(this.btnlogin);
            this.panel2.Controls.Add(this.pblogin);
            this.panel2.Controls.Add(this.txtlogin);
            this.panel2.Controls.Add(this.txtpassword);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(150, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 500);
            this.panel2.TabIndex = 6;
            // 
            // pbopen
            // 
            this.pbopen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbopen.Image = global::HotelManagment.Properties.Resources.eye;
            this.pbopen.Location = new System.Drawing.Point(423, 273);
            this.pbopen.Name = "pbopen";
            this.pbopen.Size = new System.Drawing.Size(33, 33);
            this.pbopen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbopen.TabIndex = 6;
            this.pbopen.TabStop = false;
            this.pbopen.Click += new System.EventHandler(this.pbopen_Click);
            // 
            // pbclose
            // 
            this.pbclose.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pbclose.Image = global::HotelManagment.Properties.Resources.eyeclose;
            this.pbclose.Location = new System.Drawing.Point(423, 273);
            this.pbclose.Name = "pbclose";
            this.pbclose.Size = new System.Drawing.Size(33, 33);
            this.pbclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbclose.TabIndex = 7;
            this.pbclose.TabStop = false;
            this.pbclose.Click += new System.EventHandler(this.pbclose_Click);
            // 
            // lblhomename
            // 
            this.lblhomename.AutoSize = true;
            this.lblhomename.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblhomename.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhomename.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(88)))), ((int)(((byte)(249)))));
            this.lblhomename.Location = new System.Drawing.Point(124, 118);
            this.lblhomename.Name = "lblhomename";
            this.lblhomename.Size = new System.Drawing.Size(202, 31);
            this.lblhomename.TabIndex = 5;
            this.lblhomename.Text = "TIZIMGA KIRISH\r\n";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(88)))), ((int)(((byte)(249)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlogin.Location = new System.Drawing.Point(124, 353);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(120, 40);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Kirish";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // pblogin
            // 
            this.pblogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pblogin.Image = global::HotelManagment.Properties.Resources.user1;
            this.pblogin.Location = new System.Drawing.Point(54, 188);
            this.pblogin.Name = "pblogin";
            this.pblogin.Size = new System.Drawing.Size(50, 50);
            this.pblogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogin.TabIndex = 1;
            this.pblogin.TabStop = false;
            // 
            // txtlogin
            // 
            this.txtlogin.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtlogin.Location = new System.Drawing.Point(124, 193);
            this.txtlogin.Name = "txtlogin";
            this.txtlogin.Size = new System.Drawing.Size(332, 33);
            this.txtlogin.TabIndex = 0;
            this.txtlogin.Text = "Login";
            // 
            // txtpassword
            // 
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtpassword.Location = new System.Drawing.Point(124, 273);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(299, 33);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.Text = "Parol";
            this.txtpassword.TextChanged += new System.EventHandler(this.txtpassword_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.Image = global::HotelManagment.Properties.Resources.lock1;
            this.pictureBox1.Location = new System.Drawing.Point(54, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 700);
            this.Controls.Add(this.panel1);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Managment | Login";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbopen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtlogin;
        private System.Windows.Forms.PictureBox pblogin;
        private System.Windows.Forms.Label lblhomename;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbopen;
        private System.Windows.Forms.PictureBox pbclose;
    }
}
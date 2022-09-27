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
            this.phome = new System.Windows.Forms.Panel();
            this.pblogin = new System.Windows.Forms.PictureBox();
            this.combohome = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // phome
            // 
            this.phome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.phome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.phome.Location = new System.Drawing.Point(0, 50);
            this.phome.Name = "phome";
            this.phome.Size = new System.Drawing.Size(850, 500);
            this.phome.TabIndex = 0;
            // 
            // pblogin
            // 
            this.pblogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(244)))));
            this.pblogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pblogin.Image = global::HotelManagment.Properties.Resources.neighbor;
            this.pblogin.Location = new System.Drawing.Point(800, 1);
            this.pblogin.Name = "pblogin";
            this.pblogin.Size = new System.Drawing.Size(48, 48);
            this.pblogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pblogin.TabIndex = 2;
            this.pblogin.TabStop = false;
            this.pblogin.Click += new System.EventHandler(this.pblogin_Click_1);
            // 
            // combohome
            // 
            this.combohome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(244)))));
            this.combohome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.combohome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combohome.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.combohome.ForeColor = System.Drawing.Color.White;
            this.combohome.FormattingEnabled = true;
            this.combohome.Items.AddRange(new object[] {
            "Home",
            "Chiqish"});
            this.combohome.Location = new System.Drawing.Point(6, 6);
            this.combohome.Name = "combohome";
            this.combohome.Size = new System.Drawing.Size(160, 38);
            this.combohome.TabIndex = 3;
            this.combohome.TabStop = false;
            this.combohome.SelectedIndexChanged += new System.EventHandler(this.combohome_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(144)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.combohome);
            this.panel1.Controls.Add(this.pblogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 50);
            this.panel1.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 550);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.phome);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pblogin)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pblogin;
        private System.Windows.Forms.ComboBox combohome;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel phome;
    }
}
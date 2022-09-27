namespace HotelManagment
{
    partial class FirstForm
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
            this.btnroyhatdanotish = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnroyhatdanotish
            // 
            this.btnroyhatdanotish.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(88)))), ((int)(((byte)(249)))));
            this.btnroyhatdanotish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnroyhatdanotish.FlatAppearance.BorderSize = 0;
            this.btnroyhatdanotish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnroyhatdanotish.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnroyhatdanotish.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnroyhatdanotish.Location = new System.Drawing.Point(438, 386);
            this.btnroyhatdanotish.Name = "btnroyhatdanotish";
            this.btnroyhatdanotish.Size = new System.Drawing.Size(204, 49);
            this.btnroyhatdanotish.TabIndex = 10;
            this.btnroyhatdanotish.TabStop = false;
            this.btnroyhatdanotish.Text = "Ro\'yhatdan o\'tish";
            this.btnroyhatdanotish.UseVisualStyleBackColor = false;
            this.btnroyhatdanotish.Click += new System.EventHandler(this.btnroyhatdanotish_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(202, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 62);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dasturdan to\'liq foydalanish uchun \r\n      iltimos ro\'yhatdan o\'ting";
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(88)))), ((int)(((byte)(249)))));
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnlogin.Location = new System.Drawing.Point(659, 386);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(141, 49);
            this.btnlogin.TabIndex = 8;
            this.btnlogin.TabStop = false;
            this.btnlogin.Text = "Kirish";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // FirstForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(194)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.btnroyhatdanotish);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnlogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FirstForm";
            this.Text = "FirstForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnroyhatdanotish;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnlogin;
    }
}
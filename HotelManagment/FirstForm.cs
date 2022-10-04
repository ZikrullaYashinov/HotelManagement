using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment
{
    public partial class FirstForm : Form
    {
        public Form activeForm;
        public Panel phome;
        Home home;
        public FirstForm(Panel phome, Form activeForm)
        {
            InitializeComponent();
            this.phome = phome;
            this.activeForm = activeForm;
        }
        public void ChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            activeForm.TopLevel = false;
            activeForm.Dock = DockStyle.Fill;
            activeForm.FormBorderStyle = FormBorderStyle.None;
            this.phome.Controls.Add(activeForm);
            this.phome.Tag = childForm;
            childForm.BringToFront();
            activeForm.Show();
        }
        private void btnlogin_Click(object sender, EventArgs e)
        {
            ChildForm(new Login());
        }

        private void btnroyhatdanotish_Click(object sender, EventArgs e)
        {
            ChildForm(new Registration(phome, activeForm));
        }
    }
}

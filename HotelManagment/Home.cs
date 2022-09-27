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
    public partial class Home : Form
    {
        public Form activeForm;
        public Home()
        {
            InitializeComponent();
            combobox();
        }
        public void ChildForm(Form childForm)
        {
            if (activeForm!=null)
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

        private void combohome_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox();
        }
        private void combobox()
        {
            if (combohome.Text == "Home" && Login.haslogin)
            {
                ChildForm(new HomeYesLogin(phome, activeForm));
            }
            else if (combohome.Text == "Home" && !(Login.haslogin))
            {
                ChildForm(new FirstForm(phome, activeForm));
            }
            else if (combohome.Text == "Chiqish")
            {
                Login.haslogin = false;
                ChildForm(new FirstForm(phome, activeForm));
            }
        }

        private void pblogin_Click_1(object sender, EventArgs e)
        {
            if (Login.haslogin)
            {
                ChildForm(new HomeYesLogin(phome, activeForm));
            }
            else
            {
                ChildForm(new Login(phome, activeForm));
            }
        }


    }
}

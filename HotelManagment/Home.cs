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
        //public Form activeForm;
        public string username;
        public Home()
        {
            InitializeComponent();
        }

        private void MovePanel(Control btn)
        {
            PanelMove.Top = btn.Top;
            PanelMove.Height = btn.Height;
        }

        private void btnboshsahifa_Click(object sender, EventArgs e)
        {
            MovePanel(btnboshsahifa);
            userControlSetting2.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            userControlSetting2.Hide();
            userControlRoom1.Hide();
            userControlClient1.Show();
            MovePanel(btnclient);
        }

        private void btnroom_Click(object sender, EventArgs e)
        {
            userControlClient1.Hide();
            userControlSetting2.Hide();
            userControlRoom1.Show();
            MovePanel(btnroom);
        }

        private void btnbuyurtma_Click(object sender, EventArgs e)
        {
            userControlSetting2.Hide();
            userControlClient1.Hide();
            userControlRoom1.Hide();
            MovePanel(btnbuyurtma);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            MovePanel(btnsettings);
            userControlClient1.Hide();
            userControlRoom1.Hide();
            userControlSetting2.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbltime.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
        }

        private void Home_Load(object sender, EventArgs e)
        {
            
            timer1.Start();
            lblwelcome.Text = "Xush Kelibsiz: " + username;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DialogResult r = MessageBox.Show("Rostdan ham tizimdan chiqmoqchimisiz?", "Chiqish", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(DialogResult.Yes == r)
            {
                timer1.Stop();
                this.Close();
                Login login = new Login();
                login.Visible = true;
            }
        }






        //public void ChildForm(Form childForm)
        //{
        //    if (activeForm!=null)
        //    {
        //        activeForm.Close();
        //    }
        //    activeForm = childForm;
        //    activeForm.TopLevel = false;
        //    activeForm.Dock = DockStyle.Fill;
        //    activeForm.FormBorderStyle = FormBorderStyle.None;
        //    this.phome.Controls.Add(activeForm);
        //    this.phome.Tag = childForm;
        //    childForm.BringToFront();
        //    activeForm.Show();
        //}

        //private void combohome_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    combobox();
        //}
        //private void combobox()
        //{
        //    if (combohome.Text == "Home" && Login.haslogin)
        //    {
        //        ChildForm(new HomeYesLogin(phome, activeForm));
        //    }
        //    else if (combohome.Text == "Home" && !(Login.haslogin))
        //    {
        //        ChildForm(new Login(phome, activeForm));
        //    }
        //    else if (combohome.Text == "Chiqish")
        //    {
        //        Login.haslogin = false;
        //        ChildForm(new Login(phome, activeForm));
        //    }
        //}

        //private void pblogin_Click_1(object sender, EventArgs e)
        //{
        //    combohome.Text = "Home";
        //}

        //private void Home_Load(object sender, EventArgs e)
        //{
        //    combohome.Text = "Home";
        //}
    }
}

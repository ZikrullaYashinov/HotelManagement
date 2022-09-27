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
    public partial class Login : Form
    {
        public static bool haslogin = false;
        DB db;
        public Form activeForm;
        public Panel phome;
        Home home;
        public Login(Panel phome, Form activeForm)
        {
            InitializeComponent();
            db=new DB();
            this.activeForm = activeForm;
            this.phome= phome;
            this.home = new Home();
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
            DataRow row = db.getUsernsmePassword(txtlogin.Text);
            string login = row[0].ToString();
            string password = row[1].ToString();

            if (txtlogin.Text == login && txtpassword.Text == password)
            {
                haslogin = true;
                ChildForm(new HomeYesLogin(phome, activeForm));
            }
            else
            {
                lblhomename.Text = "Login yoki parolingiz xato!";
                lblhomename.ForeColor = Color.Red;
            }
        }
    }
}

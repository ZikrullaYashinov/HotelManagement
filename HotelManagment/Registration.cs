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
    public partial class Registration : Form
    {
        public Form activeForm;
        public Panel phome;
        DB db;
        bool key = true;
        string[] sdate;
        string username, email, phone, date, password1, password2;
        string dbusername, dbpassword;
        public Registration(Panel phome, Form activeForm)
        {
            InitializeComponent();
            this.phome = phome;
            this.activeForm = activeForm;
            db = new DB();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kalkulyator k = new Kalkulyator();
            k.Show();
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

        private void btnreistration_Click(object sender, EventArgs e)
        {
            lblhomename.ForeColor = Color.White;
            lblhomename.Text = ">>> ";
            key = true;
            username = txtusername.Text;
            email = txtemail.Text;
            phone = txtphone.Text;
            sdate = datebirthday.Value.Date.ToString().Split()[0].Split('.');
            date = $"{sdate[0]}-{sdate[1]}-{sdate[2]}";
            password1 = txtpass1.Text;
            password2 = txtpass2.Text;
            lblhomename.Text = date;

            if (username == null || username.Length <= 2)
            {
                key = key && false;
                lblusername.ForeColor = Color.Red;
            }
            else
            {
                lblusername.ForeColor = Color.White;
            }

            if (phome == null || phone.Length <= 8)
            {
                key = key && false;
                lblphone.ForeColor = Color.Red;
            }
            else
            {
                lblusername.ForeColor = Color.White;
            }

            if (email == null || email.Length <= 3)
            {
                key = key && false;
                lblemail.ForeColor = Color.Red;
            }
            else
            {
                lblemail.ForeColor = Color.White;
            }

            if (password1 != password2 || password1 == null || password2 == null || password1.Length < 8)
            {
                key = key && false;
                lblpass1.ForeColor = Color.Red;
                lblpass2.ForeColor = Color.Red;
            }
            else
            {
                lblpass1.ForeColor = Color.White;
                lblpass2.ForeColor = Color.White;
            }

            if (key)
            {
                try
                {
                    DataRow row = db.getUsernsmePassword(username);
                    dbusername = $"{row[0].ToString()}";
                    dbpassword = $"{row[1].ToString()}";
                }
                catch (Exception)
                {
                    dbusername = $"";
                    dbpassword = $"";
                }


                if (dbusername == "" || dbusername != username)
                {
                    db.addUser(username, email, phone, date, password1);
                    ChildForm(new Login(phome, activeForm));
                }
                else
                {
                    MessageBox.Show("Tasdiqlanmadi!", $"{username} ismli foydalanuvchi tizimdan allaqachon ro'yhatdan o'tgan mavjud!\n" +
                        $"Iltimos boshqa username orqali harakat qiling", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                lblhomename.Text = "Iltimos quyidagi kamchiliklarni to'g'irlang";
                lblhomename.ForeColor = Color.Red;
            }


        }
    }
}

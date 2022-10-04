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
    public partial class HomeYesLogin : Form
    {
        //public Form activeForm;
        //public Panel phome;
        //Home home;
        DB db;
        public HomeYesLogin()
        {
            InitializeComponent();
            //this.activeForm = activeForm;
            //this.phome = phome;
            //this.home = new Home();
            this.db = new DB();
        }

        //public void ChildForm(Form childForm)
        //{
        //    if (activeForm != null)
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

        private void btnselect_Click(object sender, EventArgs e)
        {
            //dataGridView.DataSource = db.getUsers();
        }
    }
}

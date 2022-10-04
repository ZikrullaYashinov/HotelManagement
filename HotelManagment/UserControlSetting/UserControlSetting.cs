using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagment.UserControlSetting
{
    public partial class UserControlSetting : UserControl
    {
        // O'zgaruvchilar 
        DB db;
        string ID;
        string usernameupdate;
        string passwordupdate;
        //^^^^^^^^^^^^^

        public UserControlSetting()
        {
            InitializeComponent();
            db = new DB();
        }

        // Clear funksiyalari
        private void ClearAdd()
        {
            txtpassword.Clear();
            txtusername.Clear();
            tabControl1.SelectedTab = tabPageAdd;
        }
        private void ClearUpdate()
        {
            txtusernameUpdate.Clear();
            txtpasswordupdate.Clear();
            ID = "";
        }
        //^^^^^^^^^^^^^^^^^^^^

        // Tab Add uchun metodlar
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool check;
            if (txtusername.Text.Trim() == String.Empty || txtpassword.Text.Trim() == String.Empty)
                MessageBox.Show("Iltimos Username va Passwordlarni to'ldirganingizga ishonch hosil qiling!", "Username va Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (db.getUsernsmePassword(txtusername.Text)[0] != "")
            {
                MessageBox.Show($"Bunday foydalanuvchi tizimda allaqachon mavjud.\n" +
                    $"Iltimos boshqa username kiriting.", "Bunday foydalanuvchi mavjud", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                check = db.addUser(txtusername.Text, "null", "null", "30-09-2022", txtpassword.Text);
                if (check)
                {
                    ClearAdd();
                    MessageBox.Show("Tizimga muvofaqiyatli qo'shildi!", "Bajarildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Noma'lum xatolik yuz berdi!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tabPageAdd_Leave(object sender, EventArgs e)
        {
            ClearAdd();
        }
        //^^^^^^^^^^^^^^^^^^^


        // Tab Search uchun metodlar
        private void tabPage2_Enter(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.getUsers();
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.getUsers();
        }
        private void tabPage2_Leave(object sender, EventArgs e)
        {
            txtusernamesearch.Clear();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                passwordupdate = row.Cells[5].Value.ToString();
                usernameupdate = row.Cells[1].Value.ToString();
                txtpasswordupdate.Text = passwordupdate;
                txtusernameUpdate.Text = usernameupdate;
            }
        }
        private void txtusernamesearch_TextChanged(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.getData($"SELECT * FROM users WHERE username LIKE '%{txtusernamesearch.Text}%'");
        }
        //^^^^^^^^^^^^^^^^^^^

        // Tab Update uchun metodlar
        private void btnupdate_Click(object sender, EventArgs e)
        {
            bool check;
            if (txtusernameUpdate.Text.Trim() == String.Empty || txtpasswordupdate.Text.Trim() == String.Empty)
                MessageBox.Show("Iltimos Username va Passwordlarni to'ldirganingizga ishonch hosil qiling!", "Username va Password", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (db.getUsernsmePassword(txtusername.Text)[0] != string.Empty)
            {
                MessageBox.Show($"Bunday foydalanuvchi tizimda allaqachon mavjud.\n" +
                    $"Iltimos boshqa username kiriting.", "Bunday foydalanuvchi mavjud", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                check = db.updateUser(usernameupdate, txtusernameUpdate.Text, txtpasswordupdate.Text);
                MessageBox.Show($"{usernameupdate}\n{txtusernameUpdate.Text}\n{txtpasswordupdate.Text}");
                if (check)
                {
                    ClearUpdate();
                    MessageBox.Show("Tizimga muvofaqiyatli qo'shildi!", "Bajarildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Noma'lum xatolik yuz berdi!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btndelete_Click(object sender, EventArgs e)
        {
            bool check;
            if (txtusernameUpdate.Text.Trim() == String.Empty)
                MessageBox.Show("Iltimos Usernameni to'ldirganingizga ishonch hosil qiling!", "Username!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else if (db.getUsernsmePassword(txtusername.Text)[0] != string.Empty)
            {
                MessageBox.Show($"Bunday foydalanuvchi tizimda allaqachon mavjud.\n" +
                    $"Iltimos boshqa username kiriting.", "Bunday foydalanuvchi mavjud", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                DialogResult result = MessageBox.Show($"Rostdan ham {txtusernameUpdate}ni o'chirmoqchimisiz?", "Diqqat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == result)
                {
                    check = db.deleteUser(txtusernameUpdate.Text);
                    if (check)
                    {
                        ClearUpdate();
                        MessageBox.Show("Tizimdan muvofaqiyatli o'chirildi!", "Bajarildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void tabPageUpdate_Leave(object sender, EventArgs e)
        {
            ClearUpdate();
        }
        //^^^^^^^^^^^^^^^^^^^

    }
}

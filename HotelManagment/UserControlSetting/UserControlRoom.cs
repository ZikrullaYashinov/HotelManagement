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
    public partial class UserControlRoom : UserControl
    {
        // O'zgaruvchilar uchun metodlar
        DB db;
        //^^^^^^^^^^^^^^^^^^^^^^^^

        public UserControlRoom()
        {
            InitializeComponent();
            db = new DB();
        }

        // Add uchun metodlar
        void ClearAdd()
        {
            txtaddphone.Clear();
            txtaddroom.Clear();
            comboBoxaddtype.SelectedIndex = 0;
            rbAddYes.Checked = true;
            rbAddNo.Checked = false;
        }
        // ---------------------------
        private void tabPageAddRoom_Leave(object sender, EventArgs e)
        {
            ClearAdd();
        }
        private void tabPageAddRoom_Enter(object sender, EventArgs e)
        {
            comboBoxaddtype.SelectedIndex = 0;
        }
        private void btnaddroom_Click(object sender, EventArgs e)
        {
            bool check;
            if (txtaddroom.Text.Trim() == String.Empty || txtaddphone.Text.Trim() == String.Empty)
                MessageBox.Show("Iltimos barcha ustunlarni to'ldirganingizga ishonch hosil qiling!", "To'ldirilmagan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {

                if (db.getRoom(txtaddroom.Text)[0] != string.Empty)
                {
                    MessageBox.Show($"Bunday foydalanuvchi tizimda allaqachon mavjud.\n" +
                        $"Iltimos boshqa username kiriting. ", "Bunday foydalanuvchi mavjud", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    string free="";
                    if (rbAddYes.Checked)
                        free = "Ha";
                    if (rbAddNo.Checked)
                        free = "Yo'q";
                    check = db.addRoom(txtaddroom.Text, txtaddphone.Text, comboBoxaddtype.Text, free);
                    if (check)
                    {
                        ClearAdd();
                        MessageBox.Show("Tizimga muvofaqiyatli qo'shildi!", "Bajarildi ✔️", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Noma'lum xatolik yuz berdi!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //^^^^^^^^^^^^^^^^^^^^^^^^

        // Search uchun metodlar
        void ClearSearch()
        {
            txtsearchRoom.Clear();
            comboBoxSearchRoom.SelectedIndex = 0;
        }
        // ---------------------------
        private void tabPageSearchRoom_Leave(object sender, EventArgs e)
        {
            ClearSearch();
        }
        private void tabPageSearchRoom_Enter(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.getData($"SELECT * FROM room WHERE {comboBoxaddtype.Text} LIKE '%{txtsearchRoom.Text}%'");
        }
        //^^^^^^^^^^^^^^^^^^^^^^^^

        // Update uchun metodlar
        // ---------------------------
        private void tabPageUpdateRoom_Leave(object sender, EventArgs e)
        {

        }

        private void tabPageAddRoom_Click(object sender, EventArgs e)
        {

        }

        




        //^^^^^^^^^^^^^^^^^^^^^^^^

    }
}

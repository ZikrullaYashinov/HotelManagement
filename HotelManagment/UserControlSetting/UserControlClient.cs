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
    public partial class UserControlClient : UserControl
    {

        // O'zgaruvchilar 
        DB db;
        string firstname, lastname, pasport, phone, adress;
        
        //^^^^^^^^^^^^^

        public UserControlClient()
        {
            InitializeComponent();
            db = new DB();
        }

        // TabPage Add uchun metodlar
        void ClearAdd()
        {
            txtfirstname.Clear();
            txtlastname.Clear();
            txtphonenumber.Clear();
            txtpasportnumber.Clear();
            txtadress.Clear();
        }
        //--------------------------
        private void btnaddclient_Click(object sender, EventArgs e)
        {
            bool check;
            if (txtfirstname.Text.Trim() == String.Empty || txtlastname.Text.Trim() == String.Empty ||
                txtadress.Text.Trim() == String.Empty || txtpasportnumber.Text.Trim() == String.Empty || txtphonenumber.Text.Trim() == String.Empty) 
                MessageBox.Show("Iltimos barcha ustunlarni to'ldirganingizga ishonch hosil qiling!", "To'ldirilmagan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
            {
                
                if (db.getClient(txtpasportnumber.Text)[3] != string.Empty)
                {
                    MessageBox.Show($"Bunday foydalanuvchi tizimda allaqachon mavjud.\n" +
                        $"Iltimos boshqa username kiriting. ", "Bunday foydalanuvchi mavjud", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
                else
                {
                    check = db.addClient(txtfirstname.Text, txtlastname.Text, txtpasportnumber.Text, txtphonenumber.Text, txtadress.Text);
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
        private void tabPageAddClient_Leave(object sender, EventArgs e)
        {
            ClearAdd();
        }
        //^^^^^^^^^^

        // Tab Search uchun metodlar
        void combobox()
        {
            if (comboBoxData.Text == "Ism")
            {
                dataGridView.DataSource = db.getData($"SELECT * FROM client WHERE cl_firstname LIKE '%{txtsearch.Text}%'");
            }
            else if (comboBoxData.Text == "Familya")
            {
                dataGridView.DataSource = db.getData($"SELECT * FROM client WHERE cl_lastname LIKE '%{txtsearch.Text}%'");
            }
            else if (comboBoxData.Text == "Pasport №")
            {
                dataGridView.DataSource = db.getData($"SELECT * FROM client WHERE cl_pasport LIKE '%{txtsearch.Text}%'");
            }
            else
            {
                dataGridView.DataSource = db.getData($"SELECT * FROM client WHERE cl_adress LIKE '%{txtsearch.Text}%'");
            }
        }
        void ClearSearch()
        {
            txtsearch.Clear();
        }
        //--------------------------
        private void tabPageSearchClient_Leave(object sender, EventArgs e)
        {
            ClearSearch();
        }
        private void tabPageSearchClient_Enter(object sender, EventArgs e)
        {
            dataGridView.DataSource = db.getClients();
            comboBoxData.SelectedIndex = 0;
        }
        private void comboBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox();
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView.Rows[e.RowIndex];
                firstname = row.Cells[1].Value.ToString();
                lastname = row.Cells[2].Value.ToString();
                pasport = row.Cells[3].Value.ToString();
                phone = row.Cells[4].Value.ToString();
                adress = row.Cells[5].Value.ToString();
                txtupdatefirstname.Text = firstname;
                txtupdatelastname.Text = lastname;
                txtupdatepasport.Text = pasport;
                txtupdatephone.Text = phone;
                txtupdateadress.Text = adress;
            }
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            combobox();
        }
        //^^^^^^^^^^

        // Tab Update uchun metodlar
        void ClearUpdate()
        {
            txtupdateadress.Clear();
            txtupdatefirstname.Clear();
            txtupdatelastname.Clear();
            txtupdatepasport.Clear();
            txtupdatephone.Clear();
        }
        //--------------------------
        private void tabPageUpdate_Leave(object sender, EventArgs e)
        {
            ClearUpdate();
        }
        private void btnupdateclient_Click(object sender, EventArgs e)
        {
            bool check, key = false;
            if (txtupdatefirstname.Text.Trim() == String.Empty || txtupdatelastname.Text.Trim() == String.Empty ||
                txtupdateadress.Text.Trim() == String.Empty || txtupdatepasport.Text.Trim() == String.Empty || txtupdatephone.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Iltimos barcha ustunlarni to'ldirganingizga ishonch hosil qiling!", "To'ldirilmagan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                key = false;
            }
            else if (txtupdatepasport.Text == pasport)
            {
                key = true;
            }
            else if (db.getClient(txtupdatepasport.Text)[0] != string.Empty)
            {
                MessageBox.Show($"Bunday foydalanuvchi tizimda allaqachon mavjud.\n" +
                    $"Iltimos boshqa username kiriting.", "Bunday foydalanuvchi mavjud", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                key = false;
            }
            if (key)
            {
                check = db.updateClient(pasport, txtupdatefirstname.Text, txtupdatelastname.Text, txtupdatepasport.Text, txtupdatephone.Text, txtupdateadress.Text);
                if (check)
                {
                    ClearUpdate();
                    MessageBox.Show("Tizimga muvofaqiyatli qo'shildi!", "Bajarildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Noma'lum xatolik yuz berdi!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btndeleteclient_Click(object sender, EventArgs e)
        {
            bool check, key = false;
            if (txtupdatefirstname.Text.Trim() == String.Empty || txtupdatelastname.Text.Trim() == String.Empty ||
                txtupdateadress.Text.Trim() == String.Empty || txtupdatepasport.Text.Trim() == String.Empty || txtupdatephone.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Iltimos barcha ustunlarni to'ldirganingizga ishonch hosil qiling!", "To'ldirilmagan", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                key = false;
            }
            else if (txtupdatepasport.Text == pasport)
            {
                key = true;
            }
            else if (db.getClient(txtupdatepasport.Text)[0] == string.Empty)
            {
                MessageBox.Show($"Bunday foydalanuvchi tizimda mavjud emas.\n" +
                    $"Iltimos boshqa username kiriting.", "Bunday foydalanuvchi mavjud emas", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                key = false;
            }
            if (key)
            {
                check = db.deleteClient(pasport);
                if (check)
                {
                    ClearUpdate();
                    MessageBox.Show("Tizimdan muvofaqiyatli o'chirildi!", "Bajarildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Noma'lum xatolik yuz berdi!", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //^^^^^^^^^^

    }
}

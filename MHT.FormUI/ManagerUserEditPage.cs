using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZrfMusteriTakip.FormUI
{
    public partial class ManagerUserEditPageUI : Form
    {
        
        public ManagerUserEditPageUI()
        {
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxIsim.Text != "" && tbxSoyisim.Text != "" && tbxUsername.Text != "" && tbxPassword.Text != "")
            {
                if (ManagerOpeartionsPageUI.addOpen == true)
                {
                    //ekleme metodu
                }
                if (ManagerOpeartionsPageUI.editOpen == true)
                {
                    //güncelleme metodu
                    ManagerOpeartionsPageUI.selectedData = -1;
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
        }
        

        private void EkleUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            ManagerOpeartionsPageUI.editOpen = false;
            ManagerOpeartionsPageUI.detailOpen = false;
            ManagerOpeartionsPageUI.selectedData = -1;
        }

        public void ClrTbx()
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void ManagerEditPageUI_Load(object sender, EventArgs e)
        {
            if(ManagerOpeartionsPageUI.addOpen != true)
            {
                //seçili veriyi basma
            }
            if(ManagerOpeartionsPageUI.detailOpen == true)
            {
                tbxIsim.Enabled = false;
                tbxSoyisim.Enabled = false;
                tbxUsername.Enabled = false;
                tbxPassword.Enabled = false;
                cbxIsManager.Enabled = false;
            }
            if (ManagerOpeartionsPageUI.selectedData != -1)
            {
                //selectedData ile verileri getirip erkana basıcaz
            }
        }
    }
}

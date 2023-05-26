using MHT.Business.Abstract;
using MHT.Entity.Entities;
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
        private readonly IKullaniciService _userService;
        private readonly ManagerOpeartionsPageUI _operationsPage;
        public ManagerUserEditPageUI(IKullaniciService userService, ManagerOpeartionsPageUI opeartionsPage)
        {
            _userService = userService;
            _operationsPage = opeartionsPage;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxIsim.Text != "" && tbxSoyisim.Text != "" && tbxUsername.Text != "" && tbxPassword.Text != "")
            {
                var entity = new Kullanici();
                entity.KullaniciAdi = tbxUsername.Text;
                entity.IsDeleted = false;
                entity.Isim = tbxIsim.Text;
                entity.Sifre = tbxPassword.Text;
                entity.Soyisim = tbxSoyisim.Text;
                entity.YoneticiMi = cbxIsManager.Checked;
                if (ManagerOpeartionsPageUI.addOpen == true)
                {
                    //ekleme metodu
                    await _userService.AddAsync(entity);
                    MessageBox.Show("Başarıyla eklendi!");
                    ClrTbx();
                }
                if (ManagerOpeartionsPageUI.editOpen == true)
                {
                    //güncelleme metodu
                    entity.Id = ManagerOpeartionsPageUI.selectedData;
                    var kullanici = await _userService.GetAsync(entity.Id);
                    kullanici.KullaniciAdi = tbxUsername.Text;
                    kullanici.IsDeleted = false;
                    kullanici.Isim = tbxIsim.Text;
                    kullanici.Sifre = tbxPassword.Text;
                    kullanici.Soyisim = tbxSoyisim.Text;
                    kullanici.YoneticiMi = cbxIsManager.Checked;
                    await _userService.UpdateAsync(kullanici);
                    ManagerOpeartionsPageUI.selectedData = -1;
                    MessageBox.Show("Başarıyla güncellendi!");
                }
                _operationsPage.GetDatasToGrid();
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

        private async void ManagerEditPageUI_Load(object sender, EventArgs e)
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
               var user = await _userService.GetAsync(ManagerOpeartionsPageUI.selectedData);
                tbxIsim.Text = user.Isim;
                tbxSoyisim.Text = user.Soyisim;
                tbxUsername.Text = user.KullaniciAdi;
                cbxIsManager.Checked = user.YoneticiMi;
            }
        }
    }
}

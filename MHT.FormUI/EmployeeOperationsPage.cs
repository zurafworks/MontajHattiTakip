using MHT.Business.Abstract;
using MHT.DataAccess.Abstract;
using MHT.Entity.Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ZrfMusteriTakip.FormUI
{
    public partial class EmployeeOperationsPageUI : Form
    {
        private static int employeeId;
        private static int selectedMachine;
        private static int selectedUsing;
        private static string selectedMachineText;

        private readonly IIslemService _islemService;
        private readonly IKullanimService _kullanimService;
        private readonly IVardiyaService _vardiyaService;
        private readonly IKullaniciService _kullaniciService;
        private readonly IMakineService _makineService;
        public EmployeeOperationsPageUI(IIslemService islemService, IKullanimService kullanimService,IVardiyaService vardiyaService, IKullaniciService kullaniciService, IMakineService makineService)
        {
            _islemService = islemService;
            _kullanimService = kullanimService;
            _vardiyaService = vardiyaService;
            _kullaniciService = kullaniciService;
            _makineService = makineService;
            InitializeComponent();
        }

        private async void HomePage_onload(object sender, EventArgs e)
        {
            //Sayfanın boyut ve konum ayarlamaları
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new Size(1280, 720);

            GetDatasToGrid();

            //Tüm makineler dropdown'a eklenmeli
            var makineler =  _makineService.GetAllAsync();
            for(int i = 0; i < makineler.Count; i++)
            {
                drpdwnSelectedVeri.Items.Add(makineler[i].MakineAdi);
            }

            //kullanıcı isim soyismi labellara basılmalı
            employeeId = LoginUI.currentId;
            var currentEmployee = await _kullaniciService.GetAsync(employeeId);
            lblEmployeeName.Text = currentEmployee.Isim;
            lblSurname.Text = currentEmployee.Soyisim;

        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Kaydetmediğiniz değişiklikler kaybolacak! Emin misiniz?", "Programı kapatılıyor!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            Environment.Exit(0);
        }

        private async void drpdwnSelectedVeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçim değiştiğinde ilgili makinenin idsini almalıyız muhtemelen getbyname ile iyi olabilir.

            selectedMachineText = drpdwnSelectedVeri.Text;
        }

        private void drpdwnSelectedVeri_MouseClick(object sender, MouseEventArgs e)
        {
            drpdwnSelectedVeri.SelectionLength = 0;
            if (e.Button == MouseButtons.Left)
            {
                if (!drpdwnSelectedVeri.DroppedDown)
                {
                    drpdwnSelectedVeri.DroppedDown = true;
                }
            }
            drpdwnSelectedVeri.SelectionLength = 0;
        }

        private void drpdwnSelectedVeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private async void btnShiftStart_Click(object sender, EventArgs e)
        {
            //daha önce o kullanıcıya ait başlama tipinde aktif vardiya var mı kontrol edilecek.
            //Yoksa
            //datetime now ile saat alınacak kullanıcının idsi alınacak ve başlama tipinde vardiya eklenecek

            var checkStart = await _vardiyaService.CheckActive(employeeId, 1);

            if (checkStart == null)
            {
                var newVardiya = new Vardiya();
                newVardiya.KullaniciId = employeeId;
                newVardiya.IslemId = 1;
                newVardiya.IslemSaati = DateTime.Now;
                newVardiya.IsActive = true;

                await _vardiyaService.AddAsync(newVardiya);
                MessageBox.Show("Vardiya başladı!");
            }
            else
            {
                MessageBox.Show("Bir vardiya bitmeden bir diğerine başlanamaz! \n Vardiyaya:" + checkStart.IslemSaati + "Saatinde çoktan başladınız.");
            }

        }

        private async void btnShiftEnd_Click(object sender, EventArgs e)
        {
            //daha önce o kullanıcıya ait bitirme tipinde aktif vardiya var mı kontrol edilecek. Varsa
            //datetime now ile saat alınacak kullanıcının idsi alınacak ve bitirme tipinde vardiya eklenecek
            //ayrıca bulunan aktif vardiya pasif hale getirilecek

            var checkStart = await _vardiyaService.CheckActive(employeeId, 1);

            if (checkStart == null)
            {
                MessageBox.Show("Başlamış olduğunuz bir vardiya yok!");
            }
            else
            {
                
                checkStart.IsActive = false;
                _vardiyaService.UpdateAsync(checkStart);

                var newVardiya = new Vardiya();
                newVardiya.KullaniciId = employeeId;
                newVardiya.IslemId = 2;
                newVardiya.IslemSaati = DateTime.Now;
                newVardiya.IsActive = false;
                await _vardiyaService.AddAsync(newVardiya);

                MessageBox.Show("Vardiya tamamlandı!");
            }

        }

        private async void btnBreakStart_Click(object sender, EventArgs e)
        {
            ////daha önce o kullanıcıya ait mola başlangıç tipinde aktif vardiya var mı kontrol edilecek. yoksa
            //datetime now ile saat alınacak kullanıcının idsi alınacak ve mola başlangıç tipinde vardiya eklenecek
            var checkStart = await _vardiyaService.CheckActive(employeeId, 3);

            if (checkStart == null)
            {
                var newVardiya = new Vardiya();
                newVardiya.KullaniciId = employeeId;
                newVardiya.IslemId = 3;
                newVardiya.IslemSaati = DateTime.Now;
                newVardiya.IsActive = true;
                await _vardiyaService.AddAsync(newVardiya);


                MessageBox.Show("Mola başladı!");
            }
            else
            {
                MessageBox.Show("Bir mola bitmeden bir diğerine başlanamaz! \n Molaya:" + checkStart.IslemSaati + "Saatinde çoktan başladınız.");
            }
        }

        private async void btnBreakEnd_Click(object sender, EventArgs e)
        {
            ////daha önce o kullanıcıya ait mola başlangıç tipinde aktif vardiya var mı kontrol edilecek. varsa
            //datetime now ile saat alınacak kullanıcının idsi alınacak ve mola bitiş tipinde vardiya eklenecek
            //ayrıca bulunan aktif mola pasif hale getirilecek
            var checkStart = await _vardiyaService.CheckActive(employeeId, 3);

            if (checkStart == null)
            {
                MessageBox.Show("Başlamış olduğunuz bir mola yok!");
            }
            else
            {
                checkStart.IsActive = false;
                _vardiyaService.UpdateAsync(checkStart);

                var newVardiya = new Vardiya();
                newVardiya.KullaniciId = employeeId;
                newVardiya.IslemId = 4;
                newVardiya.IslemSaati = DateTime.Now;
                newVardiya.IsActive = false;
                await _vardiyaService.AddAsync(newVardiya);

                MessageBox.Show("Mola tamamlandı!");
            }
        }

        private async void btnUseStart_Click(object sender, EventArgs e)
        {
            //dropdowndan seçili makine alınacak. seçili makineye ait aktif kullanım yoksa yeni bir kullanım eklenecek

            selectedMachine = await _makineService.GetByName(selectedMachineText);
            var isUsed = await _kullanimService.CheckActive(selectedMachine , true);

            if(isUsed == null)
            {
                var newKullanim = new Kullanim();
                newKullanim.KullaniciId = employeeId;
                newKullanim.MakineId = selectedMachine;
                newKullanim.Aciklama = rtbxAciklama.Text;
                newKullanim.Baslangic = DateTime.Now;
                newKullanim.IsActive = true;

                _kullanimService.AddAsync(newKullanim);

                GetDatasToGrid();

                MessageBox.Show("Kullanım Başladı!");
            }
            else
            {
                var currentUser = await _kullaniciService.GetAsync(isUsed.KullaniciId);
                MessageBox.Show(drpdwnSelectedVeri.Text + " zaten " + currentUser.Isim + " " + currentUser.Soyisim + " tarafından kullanılıyor. Lütfen bitmesini bekleyin!");
            }
        }

        private async void btnUseEnd_Click(object sender, EventArgs e)
        {
            //datagridde seçili bir kullanım olup olmadığı kontrol edilecek. eğer seçilmişse bitiş saati eklenip aktifliği false yapılacak
            if (dgwVeriler.SelectedRows.Count == 1)
            {
                int selectedrowindex = dgwVeriler.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgwVeriler.Rows[selectedrowindex];
                selectedUsing = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                var updateUse = await _kullanimService.GetAsync(selectedUsing);
                updateUse.Bitis = DateTime.Now;
                updateUse.IsActive = false;

                await _kullanimService.UpdateAsync(updateUse);
                MessageBox.Show("Kullanım Tamamlandı!");
                GetDatasToGrid();
            }
            else
            {
                MessageBox.Show("Lütfen bitirmek istediğiniz kullanımı seçiniz");
            }
        }

        public async void GetDatasToGrid()
        {
            var data = await _kullanimService.GetAllAsync();
            dgwVeriler.DataSource = data;
        }
    }
}

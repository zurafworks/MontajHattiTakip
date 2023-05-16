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
        public EmployeeOperationsPageUI()
        {
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
            //drpdwnSelectedVeri.Items.Add("Araç");

            //kullanıcı isim soyismi labellara basılmalı
            employeeId = LoginUI.currentId;
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Kaydetmediğiniz değişiklikler kaybolacak! Emin misiniz?", "Programı kapatılıyor!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                e.Cancel = true;
                //Application.Exit();
                return;
            }

            Environment.Exit(0);
        }

        private void drpdwnSelectedVeri_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçim değiştiğinde ilgili makinenin idsini almalıyız muhtemelen getbyname ile iyi olabilir.
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

        private void drpdwnSelectedVeri_Enter(object sender, EventArgs e)
        {
            //drpdwnSelectedVeri.Select(0, 0);
        }

        private void btnShiftStart_Click(object sender, EventArgs e)
        {
            //daha önce o kullanıcıya ait başlama tipinde aktif vardiya var mı kontrol edilecek. Yoksa
            //datetime now ile saat alınacak kullanıcının idsi alınacak ve başlama tipinde vardiya eklenecek
        }

        private void btnShiftEnd_Click(object sender, EventArgs e)
        {
            //daha önce o kullanıcıya ait bitirme tipinde aktif vardiya var mı kontrol edilecek. Varsa
            //datetime now ile saat alınacak kullanıcının idsi alınacak ve bitirme tipinde vardiya eklenecek
            //ayrıca bulunan aktif vardiya pasif hale getirilecek
        }

        private void btnBreakStart_Click(object sender, EventArgs e)
        {
            ////daha önce o kullanıcıya ait mola başlangıç tipinde aktif vardiya var mı kontrol edilecek. yoksa
            //datetime now ile saat alınacak kullanıcının idsi alınacak ve mola başlangıç tipinde vardiya eklenecek
        }

        private void btnBreakEnd_Click(object sender, EventArgs e)
        {
            ////daha önce o kullanıcıya ait mola başlangıç tipinde aktif vardiya var mı kontrol edilecek. varsa
            //datetime now ile saat alınacak kullanıcının idsi alınacak ve mola bitiş tipinde vardiya eklenecek
            //ayrıca bulunan aktif mola pasif hale getirilecek
        }

        private void btnUseStart_Click(object sender, EventArgs e)
        {
            //dropdowndan seçili makine alınacak. seçili makineye ait aktif kullanım yoksa yeni bir kullanım eklenecek
        }

        private void btnUseEnd_Click(object sender, EventArgs e)
        {
            //datagridde seçili bir kullanım olup olmadığı kontrol edilecek. eğer seçilmişse bitiş saati eklenip aktifliği false yapılacak
        }

        public async void GetDatasToGrid()
        {
            //datagridview'a sadece kullanımdaki makineler eklenmeli
        }
    }
}

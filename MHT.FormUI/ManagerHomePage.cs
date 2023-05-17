//using Autofac;
//using Microsoft.AspNetCore.Mvc.Rendering;
using MHT.Business.Abstract;
using MHT.Entity.DTOs;
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

using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace ZrfMusteriTakip.FormUI
{
    public partial class ManagerHomePageUI : Form
    {
        //Sayfaların açık olup olmamasının kontrolü
        public static bool userOpen = false;
        public static bool machineOpen = false;
        public static bool logOpen = false;

        //sayfanın kullanıcı ile ilgili mi yoksa makine ile ilgili mi açıldığının kontrolü
        public static bool IsUser;

        private readonly IKullaniciService _kullaniciService;
        private readonly IMakineService _makineService;
        private readonly IKullanimService _kullanimService;
        private readonly IVardiyaService _vardiyaService;
        public ManagerHomePageUI(IKullaniciService kullaniciService,IMakineService makineService, IKullanimService kullanimService, IVardiyaService vardiyaService)
        {
            _kullaniciService = kullaniciService;
            _makineService = makineService;
            _kullanimService = kullanimService;
            _vardiyaService = vardiyaService;

            InitializeComponent();
        }

        private async void HomePage_onload(object sender, EventArgs e)
        {
            //sayfa boyut ve konum ayarları
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new Size(1280, 720);

            //grafiğe makine kullanım verileri basılacak makine - toplam saat

            // Grafiği oluştur
            IList<MakineKullanimDto> makineKullanimListesi = await _kullanimService.GetMakineKullanimListesi();

            var xLabels = makineKullanimListesi.Select(m => m.MakineAdi).ToArray();
            var yValues = makineKullanimListesi.Select(m => m.KullanımSuresi).ToArray();

            var xValues = Enumerable.Range(0, xLabels.Length).Select(i => (double)i).ToArray();

            fpGraphicView.plt.PlotBar(xValues, yValues);

            // x ekseni etiketlerini ayarla
            fpGraphicView.plt.XTicks(xValues, xLabels);

            // Grafiği güncelle
            fpGraphicView.Render();


        }

        private void btnEmployeeOperations_Click(object sender, EventArgs e)
        {
            if (userOpen == false)
            {
                IsUser = true;
                ManagerOpeartionsPageUI employeeOpeartionsUI = new ManagerOpeartionsPageUI(_kullaniciService, _makineService);
                employeeOpeartionsUI.Show();
                userOpen = true;
            }
        }



        private void btnMachineOperations_Click(object sender, EventArgs e)
        {
            if (machineOpen == false)
            {
                IsUser = false;
                ManagerOpeartionsPageUI machineOpeartionsUI = new ManagerOpeartionsPageUI(_kullaniciService, _makineService);
                machineOpeartionsUI.Show();
                machineOpen = true;
            }
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

        private void btnLogs_Click(object sender, EventArgs e)
        {
            if(logOpen== false)
            {
                ManagerLogsPageUI managerLogsPageUI = new ManagerLogsPageUI(_kullanimService, _vardiyaService);
                managerLogsPageUI.Show();
            }
        }
    }
}

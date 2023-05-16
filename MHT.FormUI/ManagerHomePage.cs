//using Autofac;
//using Microsoft.AspNetCore.Mvc.Rendering;
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

        //sayfanın kullanıcı ile ilgili mi yoksa makine ile ilgili mi açıldığının kontrolü
        public static bool IsUser;
       
        public ManagerHomePageUI()
        {
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
        }

        private void btnEmployeeOperations_Click(object sender, EventArgs e)
        {
            if (userOpen == false)
            {
                IsUser = true;
                ManagerOpeartionsPageUI employeeOpeartionsUI = new ManagerOpeartionsPageUI();
                employeeOpeartionsUI.Show();
                userOpen = true;
            }
        }



        private void btnMachineOperations_Click(object sender, EventArgs e)
        {
            if (machineOpen == false)
            {
                IsUser = false;
                ManagerOpeartionsPageUI machineOpeartionsUI = new ManagerOpeartionsPageUI();
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
    }
}

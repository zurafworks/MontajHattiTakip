//using Autofac;
using MHT.Business.Abstract;
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
    public partial class ManagerLogsPageUI : Form
    {
        
        private readonly IKullanimService _kullanimService;
        private readonly IVardiyaService _vardiyaService;
        public ManagerLogsPageUI(IKullanimService kullanimService, IVardiyaService vardiyaService)
        {
            _kullanimService = kullanimService;
            _vardiyaService = vardiyaService;
            InitializeComponent();
        }

        private async void HomePage_onload(object sender, EventArgs e)
        {
            //Sayfa boyut ve konum ayarları
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new System.Drawing.Point(x, y);
            this.Size = new Size(1280, 720);


            GetDatasToGrid();

            
        }

        
        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerHomePageUI.logOpen = false;
        }

       

        public async void GetDatasToGrid()
        {
            var vardiyaData = await _vardiyaService.GetAllAsync();
            dgwVardiyaVeriler.DataSource = vardiyaData;
            dgwVardiyaVeriler.Columns["id"].Visible = false;
            dgwVardiyaVeriler.Columns["IsActive"].Visible = false;
            dgwVardiyaVeriler.RowHeadersVisible = false;

            var kullanimData = await _kullanimService.GetCompAllAsync();
            dgwKullanımVeriler.DataSource = kullanimData;
            dgwKullanımVeriler.Columns["id"].Visible = false;
            dgwKullanımVeriler.Columns["IsActive"].Visible = false;
            dgwKullanımVeriler.RowHeadersVisible = false;
        }

        
    }
}

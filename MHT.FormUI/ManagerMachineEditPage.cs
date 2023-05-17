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
    public partial class ManagerMachineEditPageUI : Form
    {
        private readonly IMakineService _makineService;
        public ManagerMachineEditPageUI(IMakineService makineService)
        {
            _makineService = makineService;
            InitializeComponent();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxMakineIsim.Text != "")
            {
                var entity = new Makine();
                entity.MakineAdi = tbxMakineIsim.Text;
                if(ManagerOpeartionsPageUI.addOpen == true)
                {
                    await _makineService.AddAsync(entity);
                    //ekleme metodu
                }
                if(ManagerOpeartionsPageUI.editOpen == true)
                {
                    //güncelleme metodu
                    entity.Id = ManagerOpeartionsPageUI.selectedData;
                    await _makineService.UpdateAsync(entity);
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
            ManagerOpeartionsPageUI.addOpen = false;
            ManagerOpeartionsPageUI.editOpen = false;
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
            if (ManagerOpeartionsPageUI.addOpen != true)
            {
                //seçili veriyi basma
            }
            if (ManagerOpeartionsPageUI.detailOpen == true)
            {
                tbxMakineIsim.Enabled = false;
            }
            if(ManagerOpeartionsPageUI.selectedData != -1)
            {
                var machine = await _makineService.GetAsync(ManagerOpeartionsPageUI.selectedData);
                tbxMakineIsim.Text = machine.MakineAdi;
            }
        }
    }
}

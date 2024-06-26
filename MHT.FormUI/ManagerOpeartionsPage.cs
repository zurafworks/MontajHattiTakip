﻿//using Autofac;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ZrfMusteriTakip.FormUI
{
    public partial class ManagerOpeartionsPageUI : Form
    {
        //edit ve detail sayfalarının açık olmadığının kontrolü
        public static bool editOpen = false;
        public static bool detailOpen = false;
        public static bool addOpen = false;

        //seçili verilerin kontrolü
        public static int selectedData = -1;

        private readonly IKullaniciService _userService;
        private readonly IMakineService _makineService;
        public ManagerOpeartionsPageUI(IKullaniciService userService, IMakineService makineService)
        {
            _userService = userService;
            _makineService = makineService;
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

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (addOpen == false)
            {
                addOpen = true;
                if (ManagerHomePageUI.IsUser == true)
                {
                    ManagerUserEditPageUI managerUserEditPageUI = new ManagerUserEditPageUI(_userService, this);
                    managerUserEditPageUI.Show();
                }
                if (ManagerHomePageUI.IsUser == false)
                {
                    ManagerMachineEditPageUI managerMachineEditPageUI = new ManagerMachineEditPageUI(_makineService,this);
                    managerMachineEditPageUI.Show();
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgwVeriler.SelectedRows.Count == 1)
            {
                int selectedrowindex = dgwVeriler.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgwVeriler.Rows[selectedrowindex];
                selectedData = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (editOpen == false)
                {

                    editOpen = true;
                    if (ManagerHomePageUI.IsUser == true)
                    {
                        //güncelleme için seçilen veriler de ekrana yansıyacak
                        ManagerUserEditPageUI managerUserEditPageUI = new ManagerUserEditPageUI(_userService, this);
                        managerUserEditPageUI.Show();

                    }
                    if (ManagerHomePageUI.IsUser == false)
                    {
                        ManagerMachineEditPageUI managerMachineEditPageUI = new ManagerMachineEditPageUI(_makineService,this);
                        managerMachineEditPageUI.Show();
                    }
                    dgwVeriler.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçiniz");
            }

        }

        private void btnDetay_Click(object sender, EventArgs e)
        {
            if (dgwVeriler.SelectedRows.Count == 1)
            {
                int selectedrowindex = dgwVeriler.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgwVeriler.Rows[selectedrowindex];
                selectedData = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (detailOpen == false)
                {
                    detailOpen = true;
                    if (ManagerHomePageUI.IsUser == true)
                    {
                        //detay için seçilen veriler operasyon türüne göre ekrana yansıyacak
                        ManagerUserEditPageUI managerDetailPageUI = new ManagerUserEditPageUI(_userService, this);
                        managerDetailPageUI.Show();

                    }
                    if (ManagerHomePageUI.IsUser == false)
                    {
                        //detay için seçilen veriler operasyon türüne göre ekrana yansıyacak
                        ManagerMachineEditPageUI managerDetailPageUI = new ManagerMachineEditPageUI(_makineService, this);
                        managerDetailPageUI.Show();
                    }
                    dgwVeriler.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Lütfen görüntülemek istediğiniz satırı seçiniz");
            }
        }

        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerHomePageUI.userOpen = false;
            ManagerHomePageUI.machineOpen = false;
        }

        private async void btnSil_Click(object sender, EventArgs e)
        {
            if (dgwVeriler.SelectedRows.Count == 1)
            {
                int selectedrowindex = dgwVeriler.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgwVeriler.Rows[selectedrowindex];
                selectedData = Convert.ToInt32(selectedRow.Cells["Id"].Value);

                if (editOpen == false)
                {
                    if (ManagerHomePageUI.IsUser == true)
                    {
                        //user silme metodu çalışacak
                        var user = await _userService.GetAsync(selectedData);
                        if (user != null)
                        {
                            user.IsDeleted = true;
                            await _userService.UpdateAsync(user);
                        }
                        else
                        {
                            MessageBox.Show("Bir hata oluştu.");
                        }

                    }
                    if (ManagerHomePageUI.IsUser == false)
                    {
                        var makine = await _makineService.GetAsync(selectedData);
                        if (makine != null)
                        {
                            makine.Isdeleted = true;
                            await _makineService.UpdateAsync(makine);
                        }
                        else
                        {
                            MessageBox.Show("Bir hata oluştu.");
                        }
                        //makine silme metodu çalışacak
                    }
                    selectedData = -1;
                    dgwVeriler.ClearSelection();
                    MessageBox.Show("Başarıyla Silindi");
                    GetDatasToGrid();
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz satırı seçiniz");
            }
            GetDatasToGrid();
        }

        public async void GetDatasToGrid()
        {
            if (ManagerHomePageUI.IsUser == true)
            {
                //datagridwiev'a user dataları basılacak
                var data = _userService.GetAllAsync();
                dgwVeriler.DataSource = data;
            }
            if (ManagerHomePageUI.IsUser == false)
            {
                var data =  _makineService.GetAllAsync();
                dgwVeriler.DataSource = data;
                //datagridview'a machine dataları basılacak
            }
        }

        private async void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            if (ManagerHomePageUI.IsUser == true)
            {
                //userSearch
                var list = _userService.GetAllAsync();
                var filteredUsers = list.Where(u =>
                    u.KullaniciAdi.Contains(tbxSearch.Text, StringComparison.OrdinalIgnoreCase) ||
                    u.Isim.Trim().ToLower().Contains(tbxSearch.Text.Trim().ToLower()) ||
                    u.Soyisim.Trim().ToLower().Contains(tbxSearch.Text.Trim().ToLower())
                ).Take(50).ToList();

                dgwVeriler.DataSource = filteredUsers;

            }
            if (ManagerHomePageUI.IsUser == false)
            {
                var list =  _makineService.GetAllAsync();
                list = list.Where(m=>m.MakineAdi.Trim().ToLower()
                .Contains(tbxSearch.Text.Trim().ToLower())).Take(50).ToList();

                dgwVeriler.DataSource = list;
                //machineSearch
            }

            //var list = _userService.GetAllActives().Result.Data.Userlar.ToList();
            //var filteredUserlar = list.Where(u => u.Isim.Contains(tbxSearch.Text, StringComparison.OrdinalIgnoreCase) ||
            //    u.Soyisim.Contains(tbxSearch.Text, StringComparison.OrdinalIgnoreCase) ||
            //    u.UserName.Contains(tbxSearch.Text, StringComparison.OrdinalIgnoreCase)).Take(50).ToList();
            //dgwVeriler.DataSource = filteredUserlar;
        }

        private void tbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

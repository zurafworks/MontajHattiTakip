

using MHT.Business.Abstract;

namespace ZrfMusteriTakip.FormUI
{
    public partial class LoginUI : Form
    {
        private readonly IIslemService _islemService;
        private readonly IKullaniciService _kullaniciService;
        private readonly IKullanimService _kullanimService;
        private readonly IMakineService _makineService;
        private readonly IVardiyaService _vardiyaService;

        public static int currentId;
        public LoginUI(IIslemService islemService,IKullaniciService kullaniciService, IKullanimService kullanimService, IMakineService makineService, IVardiyaService vardiyaService)
        {
            _islemService = islemService;
            _kullaniciService = kullaniciService;
            _kullanimService = kullanimService;
            _makineService = makineService;
            _vardiyaService = vardiyaService;

            InitializeComponent();
        }

        private async void onClick_girisYap(object sender, EventArgs e)
        {
            var userName = tbxUsername.Text;
            var password = tbxPassword.Text;

            var girisYapan = await _kullaniciService.CheckPassword(userName, password);
            //Kontroller YöneticiMi ile yapýlacak current id de deðiþtirilecek gelen veriye göre
            if(girisYapan.Id != null)
            {
                currentId = girisYapan.Id;
                if (girisYapan.YoneticiMi == true)
                {
                    ManagerHomePageUI managerHomePageUI = new ManagerHomePageUI();
                    managerHomePageUI.Show();
                    this.Hide();
                }
                else if (girisYapan.YoneticiMi == false)
                {
                    EmployeeOperationsPageUI employeeOperationsPageUI = new EmployeeOperationsPageUI(_islemService, _kullanimService, _vardiyaService, _kullaniciService, _makineService);
                    employeeOperationsPageUI.Show();
                    this.Hide();
                }
            }
            else
            {
                ClrTbx();
                MessageBox.Show("Giriþ baþarýsýz, lütfen tekrar deneyin.", "Yetkisiz Eriþim");
            }
            
        }

        private void GirisYapForm_Load(object sender, EventArgs e)
        {
            int x = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int y = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;
            this.Location = new Point(x, y);
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
    }
}
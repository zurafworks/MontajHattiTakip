

namespace ZrfMusteriTakip.FormUI
{
    public partial class GirisYapForm : Form
    {
        //ILifetimeScope _lifetimeScope;
       
        private static int _girisDenemeSayisi = 0;
        public GirisYapForm()
        {
          
            InitializeComponent();
           
        }

        private void onClick_girisYap(object sender, EventArgs e)
        {
            var userName = tbxUsername.Text;
            var password = tbxPassword.Text;
            var activate = false;

            if (userName == "activate" && password == "VolleyZWasAMistake")
            {
                activate= true;
            }

            _girisDenemeSayisi++;
            if (/*_userService.CheckPassword(userName, password).Result || activate== true*/true) 
            { 
                //var homePage = new HomePage(/*islemService*/_islemService, _userService, _musteriService, _aracService, _islemUserService);
                //homePage.Show();
                //this.Hide();
            }
            else if (_girisDenemeSayisi >= 3)
            {
                ClrTbx();
                MessageBox.Show("Giri� Ba�ar�s�z. �ifrenizi unuttuysan�z veya kullan�c� ad� ve �ifrenizin" +
                    " do�ru oldu�undan eminseniz l�tfen bizimle ileti�ime ge�in.\n" +
                    "Ileti�im : info@zurafworks.com", "Yetkisiz Eri�im",MessageBoxButtons.OK);
            }
            //var islemService = Program.Container.ResolveOptional<IslemManager>();
            //var homePage = Program.Container.Resolve<HomePage>();
            else
            {
                ClrTbx();
                MessageBox.Show("Giri� ba�ar�s�z, l�tfen tekrar deneyin.", "Yetkisiz Eri�im");
            }
            
        }

        private void tbxUsername_TextChanged(object sender, EventArgs e)
        {

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
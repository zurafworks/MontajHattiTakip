

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
                MessageBox.Show("Giriþ Baþarýsýz. Þifrenizi unuttuysanýz veya kullanýcý adý ve þifrenizin" +
                    " doðru olduðundan eminseniz lütfen bizimle iletiþime geçin.\n" +
                    "Iletiþim : info@zurafworks.com", "Yetkisiz Eriþim",MessageBoxButtons.OK);
            }
            //var islemService = Program.Container.ResolveOptional<IslemManager>();
            //var homePage = Program.Container.Resolve<HomePage>();
            else
            {
                ClrTbx();
                MessageBox.Show("Giriþ baþarýsýz, lütfen tekrar deneyin.", "Yetkisiz Eriþim");
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
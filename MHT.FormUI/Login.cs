

namespace ZrfMusteriTakip.FormUI
{
    public partial class LoginUI : Form
    {

        public static int currentId;
        public LoginUI()
        {
          
            InitializeComponent();
           
        }

        private void onClick_girisYap(object sender, EventArgs e)
        {
            var userName = tbxUsername.Text;
            var password = tbxPassword.Text;

            //Kontroller Y�neticiMi ile yap�lacak current id de de�i�tirilecek gelen veriye g�re
            if (userName == "1")
            {
                ManagerHomePageUI managerHomePageUI = new ManagerHomePageUI();
                managerHomePageUI.Show();
                this.Hide();
            }
            else if(userName == "2")
            {
                EmployeeOperationsPageUI employeeOperationsPageUI = new EmployeeOperationsPageUI();
                employeeOperationsPageUI.Show();
                this.Hide();
            }
            else
            {
                ClrTbx();
                MessageBox.Show("Giri� ba�ar�s�z, l�tfen tekrar deneyin.", "Yetkisiz Eri�im");
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
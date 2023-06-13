using HW_Hidreletrica.Telas;

namespace HW_Hidreletrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
			this.Hide();
		}
    }
}
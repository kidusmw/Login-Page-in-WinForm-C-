namespace WinFormsDemo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = "kd";
            string password = "123";

            if (username == UsrTxtBx.Text.Trim() && password == PwdTxtBx.Text.Trim())
            {
                LblMsg.Text = "Login Successful";
                LblMsg.ForeColor = Color.Green;
                LblMsg.Visible = true;

            }
            else
            {
                LblMsg.Text = "Login Unsuccessful";
                LblMsg.ForeColor = Color.Red;
                LblMsg.Visible = true;
            }
        }

        private void UsrTxtBx_TextChanged(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
        }

        private void PwdTxtBx_TextChanged(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
            LblMsg.Text = ""; 
        }
    }
}

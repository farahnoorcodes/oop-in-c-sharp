namespace login_page_assignment
{
    public partial class login_page : Form
    {
        string captchaCode = "";
        Random rnd = new Random();

        public login_page()
        {
            InitializeComponent();
            refresh_button.Text = "\uE72C";
            GenerateCaptcha();
        }

        private void GenerateCaptcha()
        {
            string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            captchaCode = "";

            for (int i = 0; i < 5; i++)
            {
                captchaCode += chars[rnd.Next(chars.Length)];
            }

            CAPTCHA.Text = captchaCode;   // box that shows the code
            entered_captcha.Clear();             // box the user types in
        }

        private void login_page_Load(object sender, EventArgs e)
        {
            refresh_button.Text = "\uE72C";

            GenerateCaptcha();
        }



        private void login_buttion_Click(object sender, EventArgs e)
        {
            if (entered_captcha.Text.ToUpper() != captchaCode)
            {
                MessageBox.Show("Incorrect captcha. Please try again.");
                GenerateCaptcha();
                return;
            }

            if ((entered_username_or_email.Text == "admin" || entered_username_or_email.Text == "admin@gmail.com")
                && entered_password.Text == "12345678")
            {
                MessageBox.Show("Login successful!");
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                GenerateCaptcha();
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            GenerateCaptcha();
        }
    }
}
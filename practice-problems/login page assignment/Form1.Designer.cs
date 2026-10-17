namespace login_page_assignment
{
    partial class login_page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username_or_email = new Label();
            letsstarted = new Label();
            PASSWORD = new Label();
            entered_username_or_email = new TextBox();
            entered_password = new TextBox();
            login_buttion = new Button();
            CAPTCHA = new TextBox();
            entered_captcha = new TextBox();
            refresh_button = new Button();
            SuspendLayout();
            // 
            // username_or_email
            // 
            username_or_email.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            username_or_email.AutoSize = true;
            username_or_email.BackColor = Color.Transparent;
            username_or_email.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            username_or_email.ForeColor = SystemColors.Info;
            username_or_email.Location = new Point(399, 141);
            username_or_email.Name = "username_or_email";
            username_or_email.Size = new Size(199, 26);
            username_or_email.TabIndex = 0;
            username_or_email.Text = "Username or email";
            // 
            // letsstarted
            // 
            letsstarted.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            letsstarted.AutoSize = true;
            letsstarted.BackColor = Color.Transparent;
            letsstarted.Font = new Font("Arial Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            letsstarted.ForeColor = SystemColors.Info;
            letsstarted.Location = new Point(623, 69);
            letsstarted.Name = "letsstarted";
            letsstarted.Size = new Size(185, 33);
            letsstarted.TabIndex = 1;
            letsstarted.Text = "Let's started";
            // 
            // PASSWORD
            // 
            PASSWORD.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PASSWORD.AutoSize = true;
            PASSWORD.BackColor = Color.Transparent;
            PASSWORD.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            PASSWORD.ForeColor = SystemColors.Info;
            PASSWORD.Location = new Point(399, 193);
            PASSWORD.Name = "PASSWORD";
            PASSWORD.Size = new Size(108, 26);
            PASSWORD.TabIndex = 2;
            PASSWORD.Text = "Password";
            // 
            // entered_username_or_email
            // 
            entered_username_or_email.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            entered_username_or_email.BackColor = SystemColors.Info;
            entered_username_or_email.Font = new Font("Arial", 9F);
            entered_username_or_email.Location = new Point(623, 133);
            entered_username_or_email.Name = "entered_username_or_email";
            entered_username_or_email.PlaceholderText = "Enter username or email";
            entered_username_or_email.Size = new Size(326, 28);
            entered_username_or_email.TabIndex = 3;
            // 
            // entered_password
            // 
            entered_password.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            entered_password.BackColor = SystemColors.Info;
            entered_password.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entered_password.Location = new Point(623, 185);
            entered_password.Name = "entered_password";
            entered_password.PlaceholderText = "Enter password";
            entered_password.Size = new Size(326, 28);
            entered_password.TabIndex = 4;
            entered_password.UseSystemPasswordChar = true;
            // 
            // login_buttion
            // 
            login_buttion.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            login_buttion.BackColor = SystemColors.Info;
            login_buttion.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            login_buttion.ForeColor = SystemColors.ControlDarkDark;
            login_buttion.Location = new Point(826, 375);
            login_buttion.Name = "login_buttion";
            login_buttion.Size = new Size(123, 51);
            login_buttion.TabIndex = 5;
            login_buttion.Text = "Login";
            login_buttion.UseVisualStyleBackColor = false;
            login_buttion.Click += login_buttion_Click;
            // 
            // CAPTCHA
            // 
            CAPTCHA.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CAPTCHA.BackColor = SystemColors.Info;
            CAPTCHA.ForeColor = SystemColors.WindowText;
            CAPTCHA.Location = new Point(623, 234);
            CAPTCHA.Name = "CAPTCHA";
            CAPTCHA.ReadOnly = true;
            CAPTCHA.Size = new Size(150, 31);
            CAPTCHA.TabIndex = 6;
            CAPTCHA.TabStop = false;
            // 
            // entered_captcha
            // 
            entered_captcha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            entered_captcha.BackColor = SystemColors.Info;
            entered_captcha.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            entered_captcha.Location = new Point(621, 287);
            entered_captcha.Name = "entered_captcha";
            entered_captcha.PlaceholderText = "Enter CAPTCHA";
            entered_captcha.Size = new Size(150, 28);
            entered_captcha.TabIndex = 7;
            // 
            // refresh_button
            // 
            refresh_button.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            refresh_button.BackColor = SystemColors.Info;
            refresh_button.Font = new Font("Segoe MDL2 Assets", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refresh_button.Location = new Point(779, 234);
            refresh_button.Margin = new Padding(0);
            refresh_button.Name = "refresh_button";
            refresh_button.Size = new Size(30, 30);
            refresh_button.TabIndex = 8;
            refresh_button.Text = "⟳";
            refresh_button.UseVisualStyleBackColor = false;
            refresh_button.Click += refresh_button_Click;
            // 
            // login_page
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            BackgroundImage = Properties.Resources.form_pic;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(986, 491);
            Controls.Add(refresh_button);
            Controls.Add(entered_captcha);
            Controls.Add(CAPTCHA);
            Controls.Add(login_buttion);
            Controls.Add(entered_password);
            Controls.Add(entered_username_or_email);
            Controls.Add(PASSWORD);
            Controls.Add(letsstarted);
            Controls.Add(username_or_email);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "login_page";
            Text = "My Login Page";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username_or_email;
        private Label letsstarted;
        private Label PASSWORD;
        private TextBox entered_username_or_email;
        private TextBox entered_password;
        private Button login_buttion;
        private TextBox CAPTCHA;
        private TextBox entered_captcha;
        private Button refresh_button;
    }
}

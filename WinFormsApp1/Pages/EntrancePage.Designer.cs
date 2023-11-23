namespace DemoVar2023.Pages
{
    partial class EntrancePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEntrance = new Button();
            lblLogin = new Label();
            txtBoxLogin = new TextBox();
            txtBoxPassword = new TextBox();
            lblPassword = new Label();
            SuspendLayout();
            // 
            // btnEntrance
            // 
            btnEntrance.Enabled = false;
            btnEntrance.Location = new Point(32, 208);
            btnEntrance.Margin = new Padding(5);
            btnEntrance.Name = "btnEntrance";
            btnEntrance.Size = new Size(118, 38);
            btnEntrance.TabIndex = 0;
            btnEntrance.Text = "Войти";
            btnEntrance.UseVisualStyleBackColor = true;
            btnEntrance.Click += btnEntrance_Click;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Location = new Point(14, 18);
            lblLogin.Margin = new Padding(5, 0, 5, 0);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(65, 25);
            lblLogin.TabIndex = 1;
            lblLogin.Text = "Логин";
            // 
            // txtBoxLogin
            // 
            txtBoxLogin.Location = new Point(14, 48);
            txtBoxLogin.Margin = new Padding(5);
            txtBoxLogin.Name = "txtBoxLogin";
            txtBoxLogin.Size = new Size(155, 33);
            txtBoxLogin.TabIndex = 2;
            txtBoxLogin.TextChanged += txtBoxChanged;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(14, 128);
            txtBoxPassword.Margin = new Padding(5);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.PasswordChar = '*';
            txtBoxPassword.Size = new Size(155, 33);
            txtBoxPassword.TabIndex = 4;
            txtBoxPassword.TextChanged += txtBoxChanged;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(14, 98);
            lblPassword.Margin = new Padding(5, 0, 5, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(78, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Пароль";
            // 
            // EntrancePage
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(197, 283);
            Controls.Add(txtBoxPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtBoxLogin);
            Controls.Add(lblLogin);
            Controls.Add(btnEntrance);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "EntrancePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вход";
            SizeChanged += EntrancePage_SizeChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrance;
        private Label lblLogin;
        private TextBox txtBoxLogin;
        private TextBox txtBoxPassword;
        private Label lblPassword;
    }
}
namespace Ezzen
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TitleBar = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.BigLogo = new System.Windows.Forms.PictureBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.SignIn = new System.Windows.Forms.Button();
            this.RegButton = new System.Windows.Forms.Button();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.PWForget = new System.Windows.Forms.Label();
            this.ErrorMessage = new System.Windows.Forms.Label();
            this.TitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TitleBar.Controls.Add(this.Logo);
            this.TitleBar.Controls.Add(this.Title);
            this.TitleBar.Controls.Add(this.MinimizeButton);
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(400, 30);
            this.TitleBar.TabIndex = 1;
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            this.TitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseMove);
            this.TitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseUp);
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Location = new System.Drawing.Point(5, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(30, 30);
            this.Logo.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Rockwell", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(40, 5);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(56, 20);
            this.Title.TabIndex = 2;
            this.Title.Text = "Ezzen";
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.MinimizeButton.Location = new System.Drawing.Point(340, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 30);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.CloseButton.Location = new System.Drawing.Point(370, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "X";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // BigLogo
            // 
            this.BigLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BigLogo.BackgroundImage")));
            this.BigLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BigLogo.Location = new System.Drawing.Point(125, 65);
            this.BigLogo.Name = "BigLogo";
            this.BigLogo.Size = new System.Drawing.Size(150, 150);
            this.BigLogo.TabIndex = 2;
            this.BigLogo.TabStop = false;
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Username.Location = new System.Drawing.Point(100, 250);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(200, 30);
            this.Username.TabIndex = 3;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Password.Location = new System.Drawing.Point(100, 290);
            this.Password.Name = "Password";
            this.Password.PasswordChar = '*';
            this.Password.Size = new System.Drawing.Size(200, 30);
            this.Password.TabIndex = 4;
            this.Password.Text = "Password";
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.Enter += new System.EventHandler(this.Password_Enter);
            // 
            // SignIn
            // 
            this.SignIn.BackColor = System.Drawing.Color.LimeGreen;
            this.SignIn.FlatAppearance.BorderSize = 0;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.Location = new System.Drawing.Point(140, 390);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(120, 40);
            this.SignIn.TabIndex = 5;
            this.SignIn.Text = "Sign in";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.Navy;
            this.RegButton.FlatAppearance.BorderSize = 0;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButton.ForeColor = System.Drawing.Color.White;
            this.RegButton.Location = new System.Drawing.Point(140, 435);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(120, 40);
            this.RegButton.TabIndex = 6;
            this.RegButton.Text = "Register";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.FlatAppearance.BorderSize = 0;
            this.RememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RememberMe.Location = new System.Drawing.Point(141, 345);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(118, 21);
            this.RememberMe.TabIndex = 7;
            this.RememberMe.Text = "Remember Me";
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // PWForget
            // 
            this.PWForget.AutoSize = true;
            this.PWForget.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PWForget.Location = new System.Drawing.Point(140, 500);
            this.PWForget.Name = "PWForget";
            this.PWForget.Size = new System.Drawing.Size(121, 17);
            this.PWForget.TabIndex = 8;
            this.PWForget.Text = "Forget password?";
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(93, 325);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(214, 17);
            this.ErrorMessage.TabIndex = 9;
            this.ErrorMessage.Text = "Username or Password incorrect";
            this.ErrorMessage.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.PWForget);
            this.Controls.Add(this.RememberMe);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.BigLogo);
            this.Controls.Add(this.TitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.Shown += new System.EventHandler(this.LoginForm_Shown);
            this.TitleBar.ResumeLayout(false);
            this.TitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BigLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox BigLogo;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Button SignIn;
        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.CheckBox RememberMe;
        private System.Windows.Forms.Label PWForget;
        private System.Windows.Forms.Label ErrorMessage;
    }
}
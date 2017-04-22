namespace Ezzen
{
    partial class RegForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.RegButton = new System.Windows.Forms.Button();
            this.Username = new System.Windows.Forms.TextBox();
            this.PW = new System.Windows.Forms.TextBox();
            this.PWRe = new System.Windows.Forms.TextBox();
            this.UNLabel = new System.Windows.Forms.Label();
            this.PWLabel = new System.Windows.Forms.Label();
            this.PWReLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegButton
            // 
            this.RegButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.RegButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RegButton.FlatAppearance.BorderSize = 0;
            this.RegButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegButton.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegButton.ForeColor = System.Drawing.Color.White;
            this.RegButton.Location = new System.Drawing.Point(0, 261);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(420, 40);
            this.RegButton.TabIndex = 7;
            this.RegButton.Text = "Register";
            this.RegButton.UseVisualStyleBackColor = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // Username
            // 
            this.Username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Username.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Username.Location = new System.Drawing.Point(60, 50);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(300, 30);
            this.Username.TabIndex = 8;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Username.Enter += new System.EventHandler(this.Username_Enter);
            // 
            // PW
            // 
            this.PW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PW.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PW.Location = new System.Drawing.Point(60, 120);
            this.PW.Name = "PW";
            this.PW.PasswordChar = '*';
            this.PW.Size = new System.Drawing.Size(300, 30);
            this.PW.TabIndex = 9;
            this.PW.Text = "*****";
            this.PW.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PW.Enter += new System.EventHandler(this.PW_Enter);
            // 
            // PWRe
            // 
            this.PWRe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PWRe.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWRe.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.PWRe.Location = new System.Drawing.Point(60, 190);
            this.PWRe.Name = "PWRe";
            this.PWRe.PasswordChar = '*';
            this.PWRe.Size = new System.Drawing.Size(300, 30);
            this.PWRe.TabIndex = 10;
            this.PWRe.Text = "*****";
            this.PWRe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PWRe.Enter += new System.EventHandler(this.PWRe_Enter);
            // 
            // UNLabel
            // 
            this.UNLabel.AutoSize = true;
            this.UNLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UNLabel.Location = new System.Drawing.Point(60, 22);
            this.UNLabel.Name = "UNLabel";
            this.UNLabel.Size = new System.Drawing.Size(102, 25);
            this.UNLabel.TabIndex = 11;
            this.UNLabel.Text = "Username";
            // 
            // PWLabel
            // 
            this.PWLabel.AutoSize = true;
            this.PWLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWLabel.Location = new System.Drawing.Point(60, 92);
            this.PWLabel.Name = "PWLabel";
            this.PWLabel.Size = new System.Drawing.Size(98, 25);
            this.PWLabel.TabIndex = 12;
            this.PWLabel.Text = "Password";
            // 
            // PWReLabel
            // 
            this.PWReLabel.AutoSize = true;
            this.PWReLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PWReLabel.Location = new System.Drawing.Point(60, 162);
            this.PWReLabel.Name = "PWReLabel";
            this.PWReLabel.Size = new System.Drawing.Size(178, 25);
            this.PWReLabel.TabIndex = 13;
            this.PWReLabel.Text = "Re-Enter password";
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Maroon;
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.Location = new System.Drawing.Point(0, 300);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(420, 40);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = false;
            this.CancelButton.Click += new System.EventHandler(this.Close_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 340);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PWReLabel);
            this.Controls.Add(this.PWLabel);
            this.Controls.Add(this.UNLabel);
            this.Controls.Add(this.PWRe);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.RegButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegButton;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox PW;
        private System.Windows.Forms.TextBox PWRe;
        private System.Windows.Forms.Label UNLabel;
        private System.Windows.Forms.Label PWLabel;
        private System.Windows.Forms.Label PWReLabel;
        private System.Windows.Forms.Button CancelButton;
    }
}
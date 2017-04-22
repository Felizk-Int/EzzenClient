namespace Ezzen
{
    partial class JoinGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinGroupForm));
            this.GroupID = new System.Windows.Forms.TextBox();
            this.GIDLabel = new System.Windows.Forms.Label();
            this.Cancel = new System.Windows.Forms.Button();
            this.Join = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GroupID
            // 
            this.GroupID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupID.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.GroupID.Location = new System.Drawing.Point(165, 68);
            this.GroupID.Name = "GroupID";
            this.GroupID.Size = new System.Drawing.Size(250, 22);
            this.GroupID.TabIndex = 7;
            // 
            // GIDLabel
            // 
            this.GIDLabel.AutoSize = true;
            this.GIDLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GIDLabel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.GIDLabel.Location = new System.Drawing.Point(70, 67);
            this.GIDLabel.Name = "GIDLabel";
            this.GIDLabel.Size = new System.Drawing.Size(91, 23);
            this.GIDLabel.TabIndex = 6;
            this.GIDLabel.Text = "Group ID:";
            // 
            // Cancel
            // 
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold);
            this.Cancel.Location = new System.Drawing.Point(252, 150);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(84, 30);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Join
            // 
            this.Join.BackColor = System.Drawing.Color.PaleGreen;
            this.Join.FlatAppearance.BorderSize = 0;
            this.Join.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Join.Font = new System.Drawing.Font("Tw Cen MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Join.Location = new System.Drawing.Point(168, 150);
            this.Join.Name = "Join";
            this.Join.Size = new System.Drawing.Size(80, 30);
            this.Join.TabIndex = 4;
            this.Join.Text = "Join";
            this.Join.UseVisualStyleBackColor = false;
            this.Join.Click += new System.EventHandler(this.Join_Click);
            // 
            // JoinGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 200);
            this.Controls.Add(this.GroupID);
            this.Controls.Add(this.GIDLabel);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Join);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JoinGroupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JoinGroupForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GroupID;
        private System.Windows.Forms.Label GIDLabel;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Join;
    }
}
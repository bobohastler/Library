using LibraryWinForm.Forms;

namespace LibraryWinForm
{
    partial class MainForm
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
            btnUser = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // btnUser
            // 
            btnUser.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnUser.ForeColor = Color.Sienna;
            btnUser.Location = new Point(253, 224);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(284, 50);
            btnUser.TabIndex = 3;
            btnUser.Text = "Зареєструватись";
            btnUser.Click += btnUser_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnLogin.ForeColor = Color.DarkBlue;
            btnLogin.Location = new Point(253, 137);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(284, 50);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Увійти";
            btnLogin.Click += btnOpenBook_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnUser);
            Controls.Add(btnLogin);
            Name = "MainForm";
            Text = "Бібліотека";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUser;
        private Button btnLogin;
    }
}

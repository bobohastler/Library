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
            btnOpenBook = new Button();
            
            btnUser.Click += btnUser_Click;
            btnUser.Font = FontSettings.Bold;
            btnUser.ForeColor = Color.Sienna;
            btnUser.Location = new Point(640, 10);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(150, 50);
            btnUser.TabIndex = 3;
            btnUser.Text = "Профіль";
            
            btnOpenBook.Click += btnOpenBook_Click;
            btnOpenBook.Font = FontSettings.Bold;
            btnOpenBook.ForeColor = Color.DarkBlue;
            btnOpenBook.Location = new Point(10, 10);
            btnOpenBook.Name = "btnOpenBook";
            btnOpenBook.Size = new Size(250, 50);
            btnOpenBook.TabIndex = 2;
            btnOpenBook.Text = "Відкрити книгу";
            
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(btnUser);
            this.Controls.Add(btnOpenBook);
            this.Text = "Бібліотека";
        }

        #endregion
        
        private Button btnUser;
        private Button btnOpenBook;
    }
}

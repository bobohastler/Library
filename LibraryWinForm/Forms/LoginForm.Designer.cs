using System.ComponentModel;

namespace LibraryWinForm.Forms;

partial class LoginForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        txtEmail = new TextBox();
        txtPassword = new TextBox();
        btnConfirm = new Button();
        lbl1 = new Label();
        
        SuspendLayout();
        
        
        txtEmail.Font = FontSettings.Regular;
        txtEmail.Location = new Point(75, 80);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(250, 35);
        txtEmail.PlaceholderText = "email";
        txtEmail.TabIndex = 0;
        
        
        txtPassword.Font = FontSettings.Regular;
        txtPassword.Location = new Point(75, 120);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(250, 30);
        txtPassword.PlaceholderText = "Пароль";
        txtPassword.PasswordChar = '*';
        txtPassword.TabIndex = 1;
        
        
        btnConfirm.Click += btnConfirm_Click;
        btnConfirm.Font = FontSettings.Bold;
        btnConfirm.ForeColor = Color.Sienna;
        btnConfirm.Location = new Point(125, 160);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new Size(150, 50);
        btnConfirm.TabIndex = 3;
        btnConfirm.Text = "Увійти";
        
        
        lbl1.AutoSize = true;
        lbl1.Font = FontSettings.LargeBold;
        lbl1.ForeColor = Color.DarkBlue;
        lbl1.Location = new Point(100, 15);
        lbl1.Name = "lbl1";
        lbl1.Text = "Авторизація";
        
        
        AcceptButton = btnConfirm;
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(txtEmail);
        Controls.Add(txtPassword);
        Controls.Add(btnConfirm);
        Controls.Add(lbl1);
        // Controls.Add();
        // Controls.Add();
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        MaximumSize = ClientSize = MinimumSize = new Size(400, 270);
        Name = "LoginForm";
        Text = "Авторизація";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(true);
    }

    #endregion

    private TextBox txtEmail;
    private TextBox txtPassword;
    private Button btnConfirm;
    private Label lbl1;
}
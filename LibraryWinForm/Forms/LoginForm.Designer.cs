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
        // 
        // txtEmail
        // 
        txtEmail.Location = new Point(75, 80);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "email";
        txtEmail.Size = new Size(250, 23);
        txtEmail.TabIndex = 0;
        // 
        // txtPassword
        // 
        txtPassword.Location = new Point(75, 120);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.PlaceholderText = "Пароль";
        txtPassword.Size = new Size(250, 23);
        txtPassword.TabIndex = 1;
        // 
        // btnConfirm
        // 
        btnConfirm.ForeColor = Color.Sienna;
        btnConfirm.Location = new Point(125, 160);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new Size(150, 50);
        btnConfirm.TabIndex = 3;
        btnConfirm.Text = "Увійти";
        btnConfirm.Click += btnConfirm_Click;
        // 
        // lbl1
        // 
        lbl1.AutoSize = true;
        lbl1.ForeColor = Color.DarkBlue;
        lbl1.Location = new Point(163, 44);
        lbl1.Name = "lbl1";
        lbl1.Size = new Size(74, 15);
        lbl1.TabIndex = 4;
        lbl1.Text = "Авторизація";
        // 
        // LoginForm
        // 
        AcceptButton = btnConfirm;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(400, 261);
        Controls.Add(txtEmail);
        Controls.Add(txtPassword);
        Controls.Add(btnConfirm);
        Controls.Add(lbl1);
        Name = "LoginForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Авторизація";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtEmail;
    private TextBox txtPassword;
    private Button btnConfirm;
    private Label lbl1;
}
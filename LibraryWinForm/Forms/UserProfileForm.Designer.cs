using System.ComponentModel;
using LibraryWinForm.Data.Entities;

namespace LibraryWinForm.Forms;

partial class UserProfileForm
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
        lblUserFirstName = new Label();
        lblUserLastName = new Label();
        lblUserEmail = new Label();
        lblUserPassword = new Label();
        lblUserPhone = new Label();
        btnChangeUserFirstName = new Button();
        btnChangeUserLastName = new Button();
        btnChangeUserEmail = new Button();
        btnChangeUserPassword = new Button();
        btnChangeUserPhone = new Button();
        btnLoginLogout = new Button();
        btnRegister = new Button();
        toolTip = new ToolTip();
        
        SuspendLayout();
        
        lblUserFirstName.AutoSize = true;
        lblUserFirstName.Font = FontSettings.Bold;
        lblUserFirstName.ForeColor = Color.DarkBlue;
        lblUserFirstName.Location = new Point(100, 60);
        lblUserFirstName.Name = "lblUserFirstName";
        lblUserFirstName.Text = "Ім'я";
        
        lblUserLastName.AutoSize = true;
        lblUserLastName.Font = FontSettings.Bold;
        lblUserLastName.ForeColor = Color.DarkBlue;
        lblUserLastName.Location = new Point(100, 120);
        lblUserLastName.Name = "lblUserLastName";
        lblUserLastName.Text = "Прізвище";
        
        lblUserEmail.AutoSize = true;
        lblUserEmail.Font = FontSettings.Bold;
        lblUserEmail.ForeColor = Color.DarkBlue;
        lblUserEmail.Location = new Point(100, 180);
        lblUserEmail.Name = "lblUserEmail";
        lblUserEmail.Text = "email";
        
        lblUserPassword.AutoSize = true;
        lblUserPassword.Font = FontSettings.Bold;
        lblUserPassword.ForeColor = Color.DarkBlue;
        lblUserPassword.Location = new Point(100, 240);
        lblUserPassword.Name = "lblUserPassword";
        lblUserPassword.Text = "Пароль";
        
        lblUserPhone.AutoSize = true;
        lblUserPhone.Font = FontSettings.Bold;
        lblUserPhone.ForeColor = Color.DarkBlue;
        lblUserPhone.Location = new Point(100, 300);
        lblUserPhone.Name = "lblUserPhone";
        lblUserPhone.Text = "Телефон";
        
        btnChangeUserFirstName.Click += btnChangeUserFirstName_Click;
        btnChangeUserFirstName.Font = FontSettings.Bold;
        btnChangeUserFirstName.ForeColor = Color.DimGray;
        btnChangeUserFirstName.Location = new Point(50, 50);
        btnChangeUserFirstName.Name = "btnChangeUserFirstName";
        btnChangeUserFirstName.Size = new Size(40, 40);
        btnChangeUserFirstName.TabIndex = 0;
        btnChangeUserFirstName.Text = "⚙️";
        
        btnChangeUserLastName.Click += btnChangeUserLastName_Click;
        btnChangeUserLastName.Font = FontSettings.Bold;
        btnChangeUserLastName.ForeColor = Color.DimGray;
        btnChangeUserLastName.Location = new Point(50, 110);
        btnChangeUserLastName.Name = "btnChangeUserLastName";
        btnChangeUserLastName.Size = new Size(40, 40);
        btnChangeUserLastName.TabIndex = 1;
        btnChangeUserLastName.Text = "⚙️";
        
        btnChangeUserEmail.Click += btnChangeUserEmail_Click;
        btnChangeUserEmail.Font = FontSettings.Bold;
        btnChangeUserEmail.ForeColor = Color.DarkRed;
        btnChangeUserEmail.Location = new Point(50, 170);
        btnChangeUserEmail.Name = "btnChangeUserEmail";
        btnChangeUserEmail.Size = new Size(40, 40);
        btnChangeUserEmail.TabIndex = 2;
        btnChangeUserEmail.Text = "⚙️";
        
        btnChangeUserPassword.Click += btnChangeUserPassword_Click;
        btnChangeUserPassword.Font = FontSettings.Bold;
        btnChangeUserPassword.ForeColor = Color.DimGray;
        btnChangeUserPassword.Location = new Point(50, 230);
        btnChangeUserPassword.Name = "btnChangeUserPassword";
        btnChangeUserPassword.Size = new Size(40, 40);
        btnChangeUserPassword.TabIndex = 3;
        btnChangeUserPassword.Text = "⚙️";
        
        btnChangeUserPhone.Click += btnChangeUserPhone_Click;
        btnChangeUserPhone.Font = FontSettings.Bold;
        btnChangeUserPhone.ForeColor = Color.DimGray;
        btnChangeUserPhone.Location = new Point(50, 290);
        btnChangeUserPhone.Name = "btnChangeUserPhone";
        btnChangeUserPhone.Size = new Size(40, 40);
        btnChangeUserPhone.TabIndex = 4;
        btnChangeUserPhone.Text = "⚙️";

        btnLoginLogout.Click += btnLoginLogout_Click;
        btnLoginLogout.Font = FontSettings.Bold;
        btnLoginLogout.ForeColor = Color.DimGray;
        btnLoginLogout.Location = new Point(550, 60);
        btnLoginLogout.Name = "btnLoginLogout";
        btnLoginLogout.Size = new Size(200, 40);
        btnLoginLogout.TabIndex = 5;
        btnLoginLogout.Text = "Увійти";
        
        
        btnRegister.Click += btnRegister_Click;
        btnRegister.Font = FontSettings.Bold;
        btnRegister.ForeColor = Color.DimGray;
        btnRegister.Location = new Point(550, 120);
        btnRegister.Name = "btnRegister";
        btnRegister.Size = new Size(200, 40);
        btnRegister.TabIndex = 6;
        btnRegister.Text = "Зареєструватися";

        
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        MinimumSize = MaximumSize = ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(lblUserFirstName);
        Controls.Add(lblUserLastName);
        Controls.Add(lblUserEmail);
        Controls.Add(lblUserPassword);
        Controls.Add(lblUserPhone);
        Controls.Add(btnChangeUserFirstName);
        Controls.Add(btnChangeUserLastName);
        Controls.Add(btnChangeUserEmail);
        Controls.Add(btnChangeUserPassword);
        Controls.Add(btnChangeUserPhone);
        Controls.Add(btnLoginLogout);
        Controls.Add(btnRegister);
        Load += UserProfileForm_Load;
        Text = "Профіль";
        
        ResumeLayout(true);
    }

    #endregion

    private Label lblUserFirstName;
    private Label lblUserLastName;
    private Label lblUserEmail;
    private Label lblUserPassword;
    private Label lblUserPhone;
    private Button btnChangeUserFirstName;
    private Button btnChangeUserLastName;
    private Button btnChangeUserEmail;
    private Button btnChangeUserPassword;
    private Button btnChangeUserPhone;
    private Button btnLoginLogout;
    private Button btnRegister;
    private ToolTip toolTip;

}
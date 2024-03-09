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
        components = new Container();
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
        toolTip = new ToolTip(components);
        SuspendLayout();
        // 
        // lblUserFirstName
        // 
        lblUserFirstName.AutoSize = true;
        lblUserFirstName.ForeColor = Color.DarkBlue;
        lblUserFirstName.Location = new Point(100, 60);
        lblUserFirstName.Name = "lblUserFirstName";
        lblUserFirstName.Size = new Size(28, 15);
        lblUserFirstName.TabIndex = 0;
        lblUserFirstName.Text = "Ім'я";
        // 
        // lblUserLastName
        // 
        lblUserLastName.AutoSize = true;
        lblUserLastName.ForeColor = Color.DarkBlue;
        lblUserLastName.Location = new Point(100, 120);
        lblUserLastName.Name = "lblUserLastName";
        lblUserLastName.Size = new Size(61, 15);
        lblUserLastName.TabIndex = 1;
        lblUserLastName.Text = "Прізвище";
        // 
        // lblUserEmail
        // 
        lblUserEmail.AutoSize = true;
        lblUserEmail.ForeColor = Color.DarkBlue;
        lblUserEmail.Location = new Point(100, 180);
        lblUserEmail.Name = "lblUserEmail";
        lblUserEmail.Size = new Size(36, 15);
        lblUserEmail.TabIndex = 2;
        lblUserEmail.Text = "email";
        // 
        // lblUserPassword
        // 
        lblUserPassword.AutoSize = true;
        lblUserPassword.ForeColor = Color.DarkBlue;
        lblUserPassword.Location = new Point(100, 240);
        lblUserPassword.Name = "lblUserPassword";
        lblUserPassword.Size = new Size(49, 15);
        lblUserPassword.TabIndex = 3;
        lblUserPassword.Text = "Пароль";
        // 
        // lblUserPhone
        // 
        lblUserPhone.AutoSize = true;
        lblUserPhone.ForeColor = Color.DarkBlue;
        lblUserPhone.Location = new Point(100, 300);
        lblUserPhone.Name = "lblUserPhone";
        lblUserPhone.Size = new Size(56, 15);
        lblUserPhone.TabIndex = 4;
        lblUserPhone.Text = "Телефон";
        // 
        // btnChangeUserFirstName
        // 
        btnChangeUserFirstName.ForeColor = Color.DimGray;
        btnChangeUserFirstName.Location = new Point(50, 50);
        btnChangeUserFirstName.Name = "btnChangeUserFirstName";
        btnChangeUserFirstName.Size = new Size(40, 40);
        btnChangeUserFirstName.TabIndex = 0;
        btnChangeUserFirstName.Text = "⚙️";
        btnChangeUserFirstName.Click += btnChangeUserFirstName_Click;
        // 
        // btnChangeUserLastName
        // 
        btnChangeUserLastName.ForeColor = Color.DimGray;
        btnChangeUserLastName.Location = new Point(50, 110);
        btnChangeUserLastName.Name = "btnChangeUserLastName";
        btnChangeUserLastName.Size = new Size(40, 40);
        btnChangeUserLastName.TabIndex = 1;
        btnChangeUserLastName.Text = "⚙️";
        btnChangeUserLastName.Click += btnChangeUserLastName_Click;
        // 
        // btnChangeUserEmail
        // 
        btnChangeUserEmail.ForeColor = Color.DarkRed;
        btnChangeUserEmail.Location = new Point(50, 170);
        btnChangeUserEmail.Name = "btnChangeUserEmail";
        btnChangeUserEmail.Size = new Size(40, 40);
        btnChangeUserEmail.TabIndex = 2;
        btnChangeUserEmail.Text = "⚙️";
        btnChangeUserEmail.Click += btnChangeUserEmail_Click;
        // 
        // btnChangeUserPassword
        // 
        btnChangeUserPassword.ForeColor = Color.DimGray;
        btnChangeUserPassword.Location = new Point(50, 230);
        btnChangeUserPassword.Name = "btnChangeUserPassword";
        btnChangeUserPassword.Size = new Size(40, 40);
        btnChangeUserPassword.TabIndex = 3;
        btnChangeUserPassword.Text = "⚙️";
        btnChangeUserPassword.Click += btnChangeUserPassword_Click;
        // 
        // btnChangeUserPhone
        // 
        btnChangeUserPhone.ForeColor = Color.DimGray;
        btnChangeUserPhone.Location = new Point(50, 290);
        btnChangeUserPhone.Name = "btnChangeUserPhone";
        btnChangeUserPhone.Size = new Size(40, 40);
        btnChangeUserPhone.TabIndex = 4;
        btnChangeUserPhone.Text = "⚙️";
        btnChangeUserPhone.Click += btnChangeUserPhone_Click;
        // 
        // UserProfileForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(793, 376);
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
        Name = "UserProfileForm";
        Text = "Профіль";
        Load += UserProfileForm_Load;
        ResumeLayout(false);
        PerformLayout();
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
    private ToolTip toolTip;

}
using System.ComponentModel;

namespace LibraryWinForm.Forms;

partial class RegistrationForm
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
        txtFirstName = new TextBox();
        txtLastName = new TextBox();
        txtEmail = new TextBox();
        txtPhone = new TextBox();
        txtPassword = new TextBox();
        txtPasswordRepeat = new TextBox();
        lbl1 = new Label();
        lblStar1 = new Label();
        lblStar2 = new Label();
        lblStar3 = new Label();
        lblStar4 = new Label();
        lblStar5 = new Label();
        lblStar6 = new Label();
        lblStarExplanation = new Label();
        lblStarExplanationStar = new Label();
        btnConfirm = new Button();
        btnShowPassword = new Button();
        SuspendLayout();
        // 
        // txtFirstName
        // 
        txtFirstName.Font = new Font("Segoe UI", 14F);
        txtFirstName.Location = new Point(175, 80);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.PlaceholderText = "Ім'я";
        txtFirstName.Size = new Size(250, 32);
        txtFirstName.TabIndex = 0;
        // 
        // txtLastName
        // 
        txtLastName.Font = new Font("Segoe UI", 14F);
        txtLastName.Location = new Point(175, 120);
        txtLastName.Name = "txtLastName";
        txtLastName.PlaceholderText = "Прізвище";
        txtLastName.Size = new Size(250, 32);
        txtLastName.TabIndex = 1;
        // 
        // txtEmail
        // 
        txtEmail.Font = new Font("Segoe UI", 14F);
        txtEmail.Location = new Point(175, 160);
        txtEmail.Name = "txtEmail";
        txtEmail.PlaceholderText = "email";
        txtEmail.Size = new Size(250, 32);
        txtEmail.TabIndex = 2;
        // 
        // txtPhone
        // 
        txtPhone.Font = new Font("Segoe UI", 14F);
        txtPhone.Location = new Point(175, 200);
        txtPhone.Name = "txtPhone";
        txtPhone.PlaceholderText = "Номер телефона";
        txtPhone.Size = new Size(250, 32);
        txtPhone.TabIndex = 3;
        // 
        // txtPassword
        // 
        txtPassword.Font = new Font("Segoe UI", 14F);
        txtPassword.Location = new Point(175, 240);
        txtPassword.Name = "txtPassword";
        txtPassword.PasswordChar = '*';
        txtPassword.PlaceholderText = "Пароль";
        txtPassword.Size = new Size(250, 32);
        txtPassword.TabIndex = 4;
        // 
        // txtPasswordRepeat
        // 
        txtPasswordRepeat.Font = new Font("Segoe UI", 14F);
        txtPasswordRepeat.Location = new Point(175, 280);
        txtPasswordRepeat.Name = "txtPasswordRepeat";
        txtPasswordRepeat.PasswordChar = '*';
        txtPasswordRepeat.PlaceholderText = "Повторіть пароль";
        txtPasswordRepeat.Size = new Size(250, 32);
        txtPasswordRepeat.TabIndex = 6;
        // 
        // lbl1
        // 
        lbl1.AutoSize = true;
        lbl1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
        lbl1.ForeColor = Color.DarkBlue;
        lbl1.Location = new Point(205, 15);
        lbl1.Name = "lbl1";
        lbl1.Size = new Size(186, 45);
        lbl1.TabIndex = 7;
        lbl1.Text = "Реєстрація";
        // 
        // lblStar1
        // 
        lblStar1.AutoSize = true;
        lblStar1.Font = new Font("Segoe UI", 14F);
        lblStar1.ForeColor = Color.Red;
        lblStar1.Location = new Point(425, 80);
        lblStar1.Name = "lblStar1";
        lblStar1.Size = new Size(20, 25);
        lblStar1.TabIndex = 8;
        lblStar1.Text = "*";
        // 
        // lblStar2
        // 
        lblStar2.AutoSize = true;
        lblStar2.Font = new Font("Segoe UI", 14F);
        lblStar2.ForeColor = Color.Red;
        lblStar2.Location = new Point(425, 120);
        lblStar2.Name = "lblStar2";
        lblStar2.Size = new Size(20, 25);
        lblStar2.TabIndex = 9;
        lblStar2.Text = "*";
        // 
        // lblStar3
        // 
        lblStar3.AutoSize = true;
        lblStar3.Font = new Font("Segoe UI", 14F);
        lblStar3.ForeColor = Color.Red;
        lblStar3.Location = new Point(425, 160);
        lblStar3.Name = "lblStar3";
        lblStar3.Size = new Size(20, 25);
        lblStar3.TabIndex = 10;
        lblStar3.Text = "*";
        // 
        // lblStar4
        // 
        lblStar4.AutoSize = true;
        lblStar4.Font = new Font("Segoe UI", 14F);
        lblStar4.ForeColor = Color.Red;
        lblStar4.Location = new Point(425, 200);
        lblStar4.Name = "lblStar4";
        lblStar4.Size = new Size(20, 25);
        lblStar4.TabIndex = 11;
        lblStar4.Text = "*";
        // 
        // lblStar5
        // 
        lblStar5.AutoSize = true;
        lblStar5.Font = new Font("Segoe UI", 14F);
        lblStar5.ForeColor = Color.Red;
        lblStar5.Location = new Point(425, 240);
        lblStar5.Name = "lblStar5";
        lblStar5.Size = new Size(20, 25);
        lblStar5.TabIndex = 12;
        lblStar5.Text = "*";
        // 
        // lblStar6
        // 
        lblStar6.AutoSize = true;
        lblStar6.Font = new Font("Segoe UI", 14F);
        lblStar6.ForeColor = Color.Red;
        lblStar6.Location = new Point(425, 280);
        lblStar6.Name = "lblStar6";
        lblStar6.Size = new Size(20, 25);
        lblStar6.TabIndex = 13;
        lblStar6.Text = "*";
        // 
        // lblStarExplanation
        // 
        lblStarExplanation.AutoSize = true;
        lblStarExplanation.Font = new Font("Segoe UI", 8F);
        lblStarExplanation.ForeColor = Color.Black;
        lblStarExplanation.Location = new Point(250, 330);
        lblStarExplanation.Name = "lblStarExplanation";
        lblStarExplanation.Size = new Size(93, 13);
        lblStarExplanation.TabIndex = 14;
        lblStarExplanation.Text = "обов'зкові поля";
        // 
        // lblStarExplanationStar
        // 
        lblStarExplanationStar.AutoSize = true;
        lblStarExplanationStar.Font = new Font("Segoe UI", 14F);
        lblStarExplanationStar.ForeColor = Color.Red;
        lblStarExplanationStar.Location = new Point(235, 325);
        lblStarExplanationStar.Name = "lblStarExplanationStar";
        lblStarExplanationStar.Size = new Size(20, 25);
        lblStarExplanationStar.TabIndex = 15;
        lblStarExplanationStar.Text = "*";
        // 
        // btnConfirm
        // 
        btnConfirm.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        btnConfirm.ForeColor = Color.Maroon;
        btnConfirm.Location = new Point(190, 360);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new Size(220, 50);
        btnConfirm.TabIndex = 7;
        btnConfirm.Text = "Зареєструватись";
        btnConfirm.Click += btnConfirm_Click;
        // 
        // btnShowPassword
        // 
        btnShowPassword.Font = new Font("Segoe UI", 14F);
        btnShowPassword.ForeColor = Color.Black;
        btnShowPassword.Location = new Point(445, 240);
        btnShowPassword.Name = "btnShowPassword";
        btnShowPassword.Size = new Size(30, 30);
        btnShowPassword.TabIndex = 5;
        btnShowPassword.Text = "👁️";
        btnShowPassword.MouseDown += btnShowPassword_MouseDown;
        btnShowPassword.MouseUp += btnShowPassword_MouseUp;
        // 
        // RegistrationForm
        // 
        AcceptButton = btnConfirm;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(653, 453);
        Controls.Add(txtFirstName);
        Controls.Add(txtLastName);
        Controls.Add(txtEmail);
        Controls.Add(txtPhone);
        Controls.Add(txtPassword);
        Controls.Add(txtPasswordRepeat);
        Controls.Add(lbl1);
        Controls.Add(lblStar1);
        Controls.Add(lblStar2);
        Controls.Add(lblStar3);
        Controls.Add(lblStar4);
        Controls.Add(lblStar5);
        Controls.Add(lblStar6);
        Controls.Add(lblStarExplanation);
        Controls.Add(lblStarExplanationStar);
        Controls.Add(btnConfirm);
        Controls.Add(btnShowPassword);
        Name = "RegistrationForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Реєстрація в бібліотеці";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtFirstName;
    private TextBox txtLastName;
    private TextBox txtEmail;
    private TextBox txtPhone;
    private TextBox txtPassword;
    private TextBox txtPasswordRepeat;

    private Label lbl1;

    private Label lblStar1;
    private Label lblStar2;
    private Label lblStar3;
    private Label lblStar4;
    private Label lblStar5;
    private Label lblStar6;
    private Label lblStarExplanationStar;
    private Label lblStarExplanation;
    

    private Button btnConfirm;
    private Button btnShowPassword;
}
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

        txtFirstName.Font = FontSettings.Regular;
        txtFirstName.Location = new Point(175, 80);
        txtFirstName.Name = "txtFirstName";
        txtFirstName.Size = new Size(250, 35);
        txtFirstName.PlaceholderText = "Ім'я";
        txtFirstName.TabIndex = 0;

        txtLastName.Font = FontSettings.Regular;
        txtLastName.Location = new Point(175, 120);
        txtLastName.Name = "txtLastName";
        txtLastName.Size = new Size(250, 35);
        txtLastName.PlaceholderText = "Прізвище";
        txtLastName.TabIndex = 1;

        txtEmail.Font = FontSettings.Regular;
        txtEmail.Location = new Point(175, 160);
        txtEmail.Name = "txtEmail";
        txtEmail.Size = new Size(250, 35);
        txtEmail.PlaceholderText = "email";
        txtEmail.TabIndex = 2;

        txtPhone.Font = FontSettings.Regular;
        txtPhone.Location = new Point(175, 200);
        txtPhone.Name = "txtPhone";
        txtPhone.Size = new Size(250, 30);
        txtPhone.PlaceholderText = "Номер телефона";
        txtPhone.TabIndex = 3;

        txtPassword.Font = FontSettings.Regular;
        txtPassword.Location = new Point(175, 240);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(250, 30);
        txtPassword.PlaceholderText = "Пароль";
        txtPassword.PasswordChar = '*';
        txtPassword.TabIndex = 4;

        txtPasswordRepeat.Font = FontSettings.Regular;
        txtPasswordRepeat.Location = new Point(175, 280);
        txtPasswordRepeat.Name = "txtPasswordRepeat";
        txtPasswordRepeat.Size = new Size(250, 30);
        txtPasswordRepeat.PlaceholderText = "Повторіть пароль";
        txtPasswordRepeat.PasswordChar = '*';
        txtPasswordRepeat.TabIndex = 6;
        

        lbl1.AutoSize = true;
        lbl1.Font = FontSettings.LargeBold;
        lbl1.ForeColor = Color.DarkBlue;
        lbl1.Location = new Point(205, 15);
        lbl1.Name = "lbl1";
        lbl1.Text = "Реєстрація";

        
        btnConfirm.Click += btnConfirm_Click;
        btnConfirm.Font = FontSettings.Bold;
        btnConfirm.ForeColor = Color.Maroon;
        btnConfirm.Location = new Point(190, 360);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new Size(220, 50);
        btnConfirm.TabIndex = 7;
        btnConfirm.Text = "Зареєструватись";
        
        
        btnShowPassword.MouseDown += btnShowPassword_MouseDown;
        btnShowPassword.MouseUp += btnShowPassword_MouseUp;
        btnShowPassword.Font = FontSettings.Regular;
        btnShowPassword.ForeColor = Color.Black;
        btnShowPassword.Location = new Point(445, 240);
        btnShowPassword.Name = "btnShowPassword";
        btnShowPassword.Size = new Size(30, 30);
        btnShowPassword.TabIndex = 5;
        btnShowPassword.Text = "👁️";


        lblStar1.AutoSize = true;
        lblStar1.Font = FontSettings.Regular;
        lblStar1.ForeColor = Color.Red;
        lblStar1.Location = new Point(425, 80);
        lblStar1.Name = "lblStar1";
        lblStar1.Text = "*";
        
        lblStar2.AutoSize = true;
        lblStar2.Font = FontSettings.Regular;
        lblStar2.ForeColor = Color.Red;
        lblStar2.Location = new Point(425, 120);
        lblStar2.Name = "lblStar2";
        lblStar2.Text = "*";
        
        lblStar3.AutoSize = true;
        lblStar3.Font = FontSettings.Regular;
        lblStar3.ForeColor = Color.Red;
        lblStar3.Location = new Point(425, 160);
        lblStar3.Name = "lblStar3";
        lblStar3.Text = "*";
        
        lblStar4.AutoSize = true;
        lblStar4.Font = FontSettings.Regular;
        lblStar4.ForeColor = Color.Red;
        lblStar4.Location = new Point(425, 200);
        lblStar4.Name = "lblStar4";
        lblStar4.Text = "*";
        
        lblStar5.AutoSize = true;
        lblStar5.Font = FontSettings.Regular;
        lblStar5.ForeColor = Color.Red;
        lblStar5.Location = new Point(425, 240);
        lblStar5.Name = "lblStar5";
        lblStar5.Text = "*";
        
        lblStar6.AutoSize = true;
        lblStar6.Font = FontSettings.Regular;
        lblStar6.ForeColor = Color.Red;
        lblStar6.Location = new Point(425, 280);
        lblStar6.Name = "lblStar6";
        lblStar6.Text = "*";
        
        lblStarExplanation.AutoSize = true;
        lblStarExplanation.Font = FontSettings.SmallRegular;
        lblStarExplanation.ForeColor = Color.Black;
        lblStarExplanation.Location = new Point(250, 330);
        lblStarExplanation.Name = "lblStarExplanation";
        lblStarExplanation.Text = "обов'зкові поля";
        
        lblStarExplanationStar.AutoSize = true;
        lblStarExplanationStar.Font = FontSettings.Regular;
        lblStarExplanationStar.ForeColor = Color.Red;
        lblStarExplanationStar.Location = new Point(235, 325);
        lblStarExplanationStar.Name = "lblStarExplanationStar";
        lblStarExplanationStar.Text = "*";
        
        
        AcceptButton = btnConfirm;
        AutoScaleMode = AutoScaleMode.Font;
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
        components = new Container();
        AutoScaleMode = AutoScaleMode.Font;
        MaximumSize = ClientSize = MinimumSize = new Size(600, 480);
        Text = "Реєстрація в бібліотеці";
        Name = "RegistrationForm";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(true);
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
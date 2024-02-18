using LibraryWinForm.Data.Entities;
using LibraryWinForm.Forms.ChangeProfileSettingsForms;

namespace LibraryWinForm.Forms;

public partial class UserProfileForm : Form
{
    public UserEntity? user;
    private bool isLoggedIn => user is not null;
    
    public UserProfileForm()
    {
        InitializeComponent();
    }

    private void UserProfileForm_Load(object sender, EventArgs e)
    {
        toolTip.AutoPopDelay = 5000;
        toolTip.InitialDelay = 1000;
        toolTip.ReshowDelay = 500;
        toolTip.SetToolTip(btnChangeUserEmail,
            "Не можна змінити email, бо він використовується для ідентифікації користувачів.");
        UpdateStateOnUserLogin();
    }

    private void btnChangeUserFirstName_Click(object sender, EventArgs e)
    {
        if (isLoggedIn)
        {
            ChangeFirstNameForm form = new() { user = user };
            form.ShowDialog();
            UpdateStateOnUserLogin();
        }
    }

    private void btnChangeUserLastName_Click(object sender, EventArgs e)
    {
        if (isLoggedIn)
        {
            ChangeLastNameForm form = new() { user = user };
            form.ShowDialog();
            UpdateStateOnUserLogin();
        }
    }

    private void btnChangeUserEmail_Click(object sender, EventArgs e)
    {
        MessageBox.Show("email не можна змінювати, бо він використовується для ідентифікації користувачів", "Увага");
    }

    private void btnChangeUserPassword_Click(object sender, EventArgs e)
    {
        if (isLoggedIn)
        {
            ChangePasswordForm form = new() { user = user };
            form.ShowDialog();
            UpdateStateOnUserLogin();
        }
    }

    private void btnChangeUserPhone_Click(object sender, EventArgs e)
    {
        if (isLoggedIn)
        {
            ChangePhoneForm form = new() { user = user };
            form.ShowDialog();
            UpdateStateOnUserLogin();
        }
    }

    private void btnLoginLogout_Click(object sender, EventArgs e)
    {
        if (!isLoggedIn)
        {
            LoginForm loginForm = new();
            loginForm.ShowDialog();
            user = loginForm.LoggedUser;
        }
        else
        {
            user = null;
        }
        UpdateStateOnUserLogin();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        if (!isLoggedIn)
        {
            RegistrationForm registrationForm = new();
            registrationForm.ShowDialog();
        }
    }

    private void UpdateStateOnUserLogin()
    {
        if (!isLoggedIn)
        {
            lblUserFirstName.Hide();
            lblUserLastName.Hide();
            lblUserEmail.Hide();
            lblUserPassword.Hide();
            lblUserPhone.Hide();
            btnChangeUserFirstName.Hide();
            btnChangeUserLastName.Hide();
            btnChangeUserEmail.Hide();
            btnChangeUserPassword.Hide();
            btnChangeUserPhone.Hide();
            btnLoginLogout.Text = "Увійти";
            btnRegister.Show();
        }
        else
        {
            lblUserFirstName.Text = $"Ім'я: {user.FirstName}";
            lblUserFirstName.Show();
            lblUserLastName.Text = $"Прізвище: {user.LastName}";
            lblUserLastName.Show();
            lblUserEmail.Text = $"email: {user.Email}";
            lblUserEmail.Show();
            lblUserPassword.Text = $"Пароль: ***";
            lblUserPassword.Show();
            lblUserPhone.Text = $"Телефон: {user.Phone}";
            lblUserPhone.Show();
            btnChangeUserFirstName.Show();
            btnChangeUserLastName.Show();
            btnChangeUserEmail.Show();
            btnChangeUserPassword.Show();
            btnChangeUserPhone.Show();
            btnLoginLogout.Text = "Вийти";
            btnRegister.Hide();
        }
    }
}
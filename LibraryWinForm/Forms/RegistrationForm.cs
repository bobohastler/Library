using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;

namespace LibraryWinForm.Forms;

public partial class RegistrationForm : Form
{
    public RegistrationForm()
    {
        InitializeComponent();
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        if (!txtPassword.Text.Equals(txtPasswordRepeat.Text))
        {
            MessageBox.Show("Паролі не співпадають", "Увага");
            return;
        }
        if (   string.IsNullOrWhiteSpace(txtFirstName.Text)
            || string.IsNullOrWhiteSpace(txtLastName.Text)
            || string.IsNullOrWhiteSpace(txtEmail.Text)
            || string.IsNullOrWhiteSpace(txtPhone.Text)
            || string.IsNullOrWhiteSpace(txtPassword.Text)
            || string.IsNullOrWhiteSpace(txtPasswordRepeat.Text))
        {
            MessageBox.Show("Всі поля повинні бути заповненими", "Увага");
            return;
        }
        using LibraryContext context = new ();

        var usersWithEmail = context.Users.Where(u => u.Email == txtEmail.Text).ToList();
        if (usersWithEmail.Count > 0)
        {
            MessageBox.Show("Користувач з таким email вже існує", "Увага");
            return;
        }
        
        var userTypes = context.UserTypes.Where(ut => ut.Name == "User").ToList();
        if (userTypes.Count == 0)
        {
            context.UserTypes.Add(new UserTypeEntity
            {
                Name = "User",
            });
        }
        
        var userType = context.UserTypes.First(ut => ut.Name == "User");

        var user = new UserEntity
        {
            FirstName = txtFirstName.Text,
            LastName = txtLastName.Text,
            Email = txtEmail.Text,
            Phone = txtPhone.Text,
            Password = txtPassword.Text,
            DateCreated = DateTime.Now,
            UserTypeEntity = userType,
        };

        context.Users.Add(user);
        
        context.SaveChanges();

        MessageBox.Show("Вас зареєстровано", "Успіх");
        
        txtFirstName.Text = "";
        txtLastName.Text = "";
        txtEmail.Text = "";
        txtPhone.Text = "";
        txtPassword.Text = "";
        txtPasswordRepeat.Text = "";

    }

    private void btnShowPassword_MouseDown(object sender, EventArgs e)
    {
        txtPassword.PasswordChar = '\u0000';
    }

    private void btnShowPassword_MouseUp(object sender, EventArgs e)
    {
        txtPassword.PasswordChar = '*';
    }
}
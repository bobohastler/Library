using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;

namespace LibraryWinForm.Forms;

public partial class LoginForm : Form
{
    public UserEntity LoggedUser { set; get; }
    
    public LoginForm()
    {
        InitializeComponent();
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text;

        using LibraryContext context = new();
        
        var usersWithEmail = context.Users.Where(u => u.Email == email).ToList();
        if (usersWithEmail.Count == 0)
        {
            MessageBox.Show("Користувача з таким email не існує", "Увага");
            return;
        }

        var user = usersWithEmail.SingleOrDefault();
        if (user.Password != txtPassword.Text)
        {
            MessageBox.Show("Пароль неправильний", "Увага");
            return;
        }
        LoggedUser = user;
        MessageBox.Show($"Ви увійшли як {user.FirstName} {user.LastName}", "Успіх");
    }
}
using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;

namespace LibraryWinForm.Forms.ChangeProfileSettingsForms;

public partial class ChangePasswordForm : ChangeUserFieldForm
{
    public ChangePasswordForm()
    {
        InitializeComponent();
        Controls.Add(lbl1);
        Controls.Add(txt1);
        Controls.Add(btnConfirm);
    }

    protected override void ChangeUserFieldForm_Load(object sender, EventArgs e)
    {
        btnConfirm.Text = this.Text = "Змінити пароль";
        lbl1.Text = $"Старий пароль: {user.Password}";
        AlignLbl1();
    }

    protected override void btnConfirm_Click(object sender, EventArgs e)
    {
        var newValue = txt1.Text;
        user.Password = newValue;
        context.Users.Update(user);
        context.SaveChanges();
        Close();
    }
}
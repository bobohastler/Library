using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;

namespace LibraryWinForm.Forms.ChangeProfileSettingsForms;

public partial class ChangeFirstNameForm : ChangeUserFieldForm
{
    public ChangeFirstNameForm()
    {
        InitializeComponent();
        Controls.Add(lbl1);
        Controls.Add(txt1);
        Controls.Add(btnConfirm);
    }

    protected override void ChangeUserFieldForm_Load(object sender, EventArgs e)
    {
        btnConfirm.Text = this.Text = "Змінити ім'я";
        lbl1.Text = $"Старе ім'я: {user.FirstName}";
        AlignLbl1();
    }

    protected override void btnConfirm_Click(object sender, EventArgs e)
    {
        var newValue = txt1.Text;
        user.FirstName = newValue;
        context.Users.Update(user);
        context.SaveChanges();
        Close();
    }
}
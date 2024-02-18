using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;

namespace LibraryWinForm.Forms.ChangeProfileSettingsForms;

public partial class ChangeLastNameForm : ChangeUserFieldForm
{
    public ChangeLastNameForm()
    {
        InitializeComponent();
        Controls.Add(lbl1);
        Controls.Add(txt1);
        Controls.Add(btnConfirm);
    }

    protected override void ChangeUserFieldForm_Load(object sender, EventArgs e)
    {
        btnConfirm.Text = this.Text = "Змінити прізвище";
        lbl1.Text = $"Старе прізвище: {user.LastName}";
        AlignLbl1();
    }

    protected override void btnConfirm_Click(object sender, EventArgs e)
    {
        var newValue = txt1.Text;
        user.LastName = newValue;
        context.Users.Update(user);
        context.SaveChanges();
        Close();
    }
}
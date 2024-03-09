using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;

namespace LibraryWinForm.Forms.ChangeProfileSettingsForms;

public abstract partial class ChangeUserFieldForm : Form
{
    public UserEntity user;
    protected LibraryContext context = new();

    protected abstract void ChangeUserFieldForm_Load(object sender, EventArgs e);
    
    protected abstract void btnConfirm_Click(object sender, EventArgs e);

    protected void AlignLbl1()
    {
        lbl1.Location = lbl1.Location with { X = (this.ClientSize.Width - lbl1.ClientSize.Width) / 2 };
    }
}
using System.ComponentModel;

namespace LibraryWinForm.Forms.ChangeProfileSettingsForms;

partial class ChangeUserFieldForm
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
    protected virtual void InitializeComponent()
    {
        lbl1 = new Label();
        txt1 = new TextBox();
        btnConfirm = new Button();
        
        SuspendLayout();
        
        lbl1.AutoSize = true;
        lbl1.Font = FontSettings.LargeBold;
        lbl1.ForeColor = Color.DarkBlue;
        lbl1.Location = new Point(150, 15);
        lbl1.Name = "lbl1";
        
        txt1.Font = FontSettings.Regular;
        txt1.Location = new Point(150, 70);
        txt1.Name = "txt1";
        txt1.Size = new Size(300, 35);
        txt1.TabIndex = 0;
        
        
        btnConfirm.Click += btnConfirm_Click;
        btnConfirm.Font = FontSettings.Bold;
        btnConfirm.ForeColor = Color.Green;
        btnConfirm.Location = new Point(190, 140);
        btnConfirm.Name = "btnConfirm";
        btnConfirm.Size = new Size(220, 50);
        btnConfirm.TabIndex = 1;
        btnConfirm.Text = "Змінити ім'я";
        
        AcceptButton = btnConfirm;
        components = new System.ComponentModel.Container();
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        // Controls.Add(lbl1);
        // Controls.Add(txt1);
        // Controls.Add(btnConfirm);
        MinimumSize = MaximumSize = ClientSize = new System.Drawing.Size(600, 270);
        Load += ChangeUserFieldForm_Load;
        
        ResumeLayout(true);
    }

    #endregion

    protected Label lbl1;
    protected TextBox txt1;
    protected Button btnConfirm;
}
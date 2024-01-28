using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;

namespace LibraryWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UserEntity kot = new UserEntity
            {
                FirstName = "Котик",
                LastName = "Рижик",
                Email = "kotyk@gmail.com",
                Password = "123456",
                DateCreated = DateTime.Now,
                Phone = "+380 97 638 87 34"
            };
            LibraryContext context = new();
            context.Users.Add(kot);
            context.SaveChanges();
        }
    }
}

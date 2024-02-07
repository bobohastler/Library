using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;

namespace LibraryWinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LibraryContext context = new();
            
            var userTypes = context.UserTypes.Where(ut => ut.Name == "User").ToList();
            if (userTypes.Count == 0)
            {
                context.UserTypes.Add(new UserTypeEntity
                {
                    Name = "User",
                });
            }
        
            var userType = context.UserTypes.First(ut => ut.Name == "User");
            
            UserEntity kot = new UserEntity
            {
                FirstName = "Котик",
                LastName = "Рижик",
                Email = "kotyk@gmail.com",
                Password = "123456",
                DateCreated = DateTime.Now,
                Phone = "+380 97 638 87 34",
                UserTypeEntity = userType,
            };
            context.Users.Add(kot);
            context.SaveChanges();
        }
    }
}

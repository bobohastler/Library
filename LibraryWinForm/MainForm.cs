using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;
using LibraryWinForm.Forms;

namespace LibraryWinForm
{
    public partial class MainForm : Form
    {
        public UserEntity? user;
        
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
        
            var userType = context.UserTypes.SingleOrDefault(ut => ut.Name == "User");
            
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

            var kots = context.Users.Where(u => u.Email == kot.Email).ToList();
            if (kots.Count == 0)
            {
                context.Users.Add(kot);
            }
            
            context.SaveChanges();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            RegistrationForm register = new();
            register.ShowDialog();
        }

        private void btnOpenBook_Click(object sender, EventArgs e)
        {
            LoginForm login = new();
            login.ShowDialog();
            user = login.LoggedUser;
        }
    }
}

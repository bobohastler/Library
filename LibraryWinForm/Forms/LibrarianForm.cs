using LibraryWinForm.Data;
using LibraryWinForm.Data.Entities;
using LibraryWinForm.Migrations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryWinForm.Forms
{
    public partial class LibrarianForm : Form
    {
        public UserEntity user;
        public LibrarianForm(UserEntity user)
        {
            this.user = user;
            InitializeComponent();
            var context = new LibraryContext();
            var entities = context.Books.ToList();
            foreach (var entity in entities)
            {
                dataGridView1.Rows.Add(entity.BookId.ToString(), entity.Name.ToString(), entity.Description.ToString(),
                   entity.AuthorName.ToString(), entity.Pages.ToString() ) ;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddBookForm add = new();
            add.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

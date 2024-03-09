using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWinForm.Data.Entities;


[Table("tblOrderedBooks")]
public class OrderedBooksEntity
{
    [Key]
    public int OrderId { get; set; }   

    public DateTime Date { get; set; }

    [ForeignKey("UserEntity")]
    public int UserId { get; set; }
    public UserEntity UserEntity { get; set; }

    [ForeignKey("BookEntity")]
    public int BookId { get; set; }
    public BookEntity BookEntity { get; set; }
}
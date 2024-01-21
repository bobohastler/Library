using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWinForm.Data.Entities;


[Table("tblBooks")]
public class BookEntity
{
    [Key]
    public int BookId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string AuthorName { get; set; }
    [Required]
    public int Pages { get; set; }
    [Required]
    public int Count { get; set; }
    
    public CategoryEntity CategoryEntity { get; set; }
}
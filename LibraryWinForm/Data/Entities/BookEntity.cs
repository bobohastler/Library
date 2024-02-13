using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWinForm.Data.Entities;


[Table("tblBooks")]
public class BookEntity
{
    [Key]
    public int BookId { get; set; }
    [Required, StringLength(200)]
    public string Name { get; set; }
    [Required, StringLength(4000)]
    public string Description { get; set; }
    [Required, StringLength(200)]
    public string AuthorName { get; set; }
    [Required]
    public int Pages { get; set; }
    [Required]
    public string PDFFile { get; set; }
    [Required]
    public int Count { get; set; }
    
    [ForeignKey("CategoryEntity")]
    public int CategoryId { get; set; }
    public CategoryEntity CategoryEntity { get; set; }
}
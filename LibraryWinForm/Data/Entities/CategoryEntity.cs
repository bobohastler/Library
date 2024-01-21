using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWinForm.Data.Entities;

[Table("tblCategories")]
public class CategoryEntity
{
    [Key]
    public int CategoryId { get; set; }
    [Required, StringLength(255)]
    public string Name { get; set; }
    [Required]
    public DateTime DateCreated { get; set; }
}
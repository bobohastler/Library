using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWinForm.Data.Entities;



[Table("tblUserTypes")]
public class UserTypeEntity
{
    [Key]
    public int UserTypeId { get; set; }
    [Required, StringLength(200)]
    public string Name { get; set; }

    public ICollection<UserEntity> Users { get; set; }
}
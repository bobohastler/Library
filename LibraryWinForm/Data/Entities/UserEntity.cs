using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryWinForm.Data.Entities;

[Table("tblUsers")]
public class UserEntity
{
    [Key]
    public int UserId { get; set; }
    [Required, StringLength(200)]
    public string FirstName { get; set; }
    [Required, StringLength(200)]
    public string LastName { get; set; }
    [Required, StringLength(200)]
    public string Email { get; set; }
    [Required, StringLength(255)]
    public string Password { get; set; }
    [Required, StringLength(20)]
    public string Phone { get; set; }
    [Required]
    public DateTime DateCreated { get; set; }
    [ForeignKey("UserTypeEntity")]
    public int UserTypeId { get; set; }
    public UserTypeEntity UserTypeEntity { get; set; }
}
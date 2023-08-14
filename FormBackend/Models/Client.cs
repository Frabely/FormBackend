namespace FormBackend.Models;

using System.ComponentModel.DataAnnotations;

public class Client
{
    [Key]
    [Required]
    [StringLength(50)]
    public string Username { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    [StringLength(50)]
    public string PrevName { get; set; }

    [Required]
    [StringLength(50)]
    public string Password { get; set; }

    [StringLength(50)]
    public string Email { get; set; }
}
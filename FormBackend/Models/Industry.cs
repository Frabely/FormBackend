using System.ComponentModel.DataAnnotations;

namespace FormBackend.Models;

public class Industry
{
    [Required]
    [Key]
    public int IndustryId { get; set; }
    [Required]
    public string Name { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FormBackend.Models;

public class Company
{
    [Required]
    [Key]
    public int Id { get; set; }
    
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    
    [ForeignKey("IndustryId")] 
    [Required]
    public int IndustryId { get; set; }
    
    // [ForeignKey("IndustryId")] 
    // public Industry Industry { get; set; } 
}
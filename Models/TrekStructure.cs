using System.ComponentModel.DataAnnotations;

namespace RazorDemo.Models;

public class TrekStructure
{
    public string? Id { get; set; }

    [Required]
    public string? TrekName { get; set; }
    public string? Description { get; set; }
    public string? Location { get; set; }
     public string? img { get; set; }
    
}

using System.ComponentModel.DataAnnotations;

namespace Listings.Models;

public class Book
{
    public int? Id { get; set; }

    [Required]
    public string? Title { get; set; }
    [Required]
    public string? Author { get; set; }
    public bool Completed { get; set; }
}
//public enum status {Todo,In_progress,coplete}
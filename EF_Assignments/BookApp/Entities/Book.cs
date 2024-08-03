using System.ComponentModel.DataAnnotations;


namespace BookApp.Entities;

public partial class Book
{
   [Required(ErrorMessage = "Please Enter BookId")]
    public int BookId { get; set; }

    [Required(ErrorMessage = "Please Enter BookName")]

    public string? BookName { get; set; }

    [Required(ErrorMessage = "Please Enter Price")]

    public int? Price { get; set; }

    [Required(ErrorMessage = "Please Enter Author")]

    public string? Author { get; set; }

    [Required(ErrorMessage = "Please Enter Lang")]


    public string? Lang { get; set; }

    [Required(ErrorMessage = "Please Enter ReleaseDate")]


    public DateTime? ReleaseDate { get; set; }
}

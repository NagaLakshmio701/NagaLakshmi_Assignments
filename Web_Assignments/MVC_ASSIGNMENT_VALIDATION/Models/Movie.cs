/*namespace HandsOnModels.Models;
*/using System.ComponentModel.DataAnnotations;

namespace HandsOnModels.Models

{
    public class Movie
    {
       
        [Required(ErrorMessage = "Please Enter MovieId")]
        public int MovieId { get; set; }

        [Required(ErrorMessage = "Plese Enter Title")]
        public string? Title { get; set; }

        [Required(ErrorMessage = "Plese Enter Actor")]

        public string? Actor { get; set; }
        public string? Lang { get; set; }
        public string? Director { get; set; }
    }
}


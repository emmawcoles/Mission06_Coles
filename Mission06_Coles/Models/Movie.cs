using System.ComponentModel.DataAnnotations;

namespace Mission06_Coles.Models
{
    // Movie class represents a movie in the collection and is used as an entity in the database
    // It includes properties for the movie's title, release year, director, rating, whether it has been edited,
    // who it is lent to, and any notes about the movie
    public class Movie
    {
        // MovieId is the primary key for the Movie entity and is auto-incremented by the database
        [Key]
        public int MovieId { get; set; }

        // Title is a required property that represents the name of the movie
        [Required]
        public string Title { get; set; } = string.Empty;

        // Year is a required property that represents the release year of the movie and must be 1888 or later
        [Required]
        [Range (1888, 9999, ErrorMessage = "Please enter a valid year, must be 1888 or later.")]
        public int Year { get; set; }

        // Director is an optional property that represents the director of the movie
        public string? Director { get; set; }

        // Rating is an optional property that represents the movie's rating (e.g., PG, R, etc.)
        public string? Rating { get; set; }

        // Edited is a required property that indicates whether the movie has been edited or not
        [Required]
        public bool Edited { get; set; }

        // LentTo is an optional property that represents the name of the person to whom the movie is lent
        public string? LentTo { get; set; }

        // Notes is an optional property that allows the user to add any additional notes about the movie,
        // with a maximum length of 25 characters
        [StringLength(25, ErrorMessage = "Notes cannot be longer than 25 characters.")]
        public string? Notes { get; set; }

        // CopiedToPlex is a required property that indicates whether the movie has been copied to Plex or not
        [Required]
        public bool CopiedToPlex { get; set; }
    }
}
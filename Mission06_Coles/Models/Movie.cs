using Humanizer;
using System.ComponentModel.DataAnnotations;

namespace Mission06_Coles.Models
{

    // Assignment-required ratings only
    // Enum restricts rating choices to those required by the assignment
    // and enables a dropdown menu in the Create/Edit views
    public enum Rating
    {
        G,
        PG,
        PG13,
        R
    }

    // Movie model represents a single film in Joel Hilton's collection
    // This class is used by Entity Framework to create the Movies table
    public class Movie
    {
        // Primary key for the Movies table
        [Key]
        public int MovieId { get; set; }

        // Spreadsheet: Category
        [Required]
        public string Category { get; set; } = string.Empty;

        // Spreadsheet: Title
        [Required]
        public string Title { get; set; } = string.Empty;

        // Spreadsheet: Year (single year, even if sheet has ranges)
        [Required]
        public int Year { get; set; }

        // Spreadsheet: Director
        [Required]
        public string Director { get; set; } = string.Empty;

        // Assignment: dropdown (G, PG, PG-13, R)
        [Required]
        public Rating Rating { get; set; }

        // Spreadsheet: Edited (Yes / blank)
        // Assignment: NOT required
        public bool? Edited { get; set; }

        // Spreadsheet: Lent To
        // Assignment: NOT required
        public string? LentTo { get; set; }

        // Spreadsheet: Notes
        // Assignment: max 25 characters
        [StringLength(25)]
        public string? Notes { get; set; }
    }
}

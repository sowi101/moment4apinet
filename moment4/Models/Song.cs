using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace moment4.Models
{
    public class Song
    {
        // Properties

        public int SongId { get; set; }
        public string? Artist { get; set;}
        public string? Title { get; set;}
        public int? Length { get; set;}

        // Relation to Genre
        public int GenreId { get; set; }
        public Genre? Genre { get; set; }
    }
}

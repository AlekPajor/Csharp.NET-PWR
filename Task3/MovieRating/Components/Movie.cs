using System.ComponentModel.DataAnnotations;

namespace MovieRating.Components
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        [DataType(DataType.Date)]

        public DateTime? RelaseDate { get; set; }
        public float? Rate { get; set; }
        public int? RateCount { get; set; }
        public string? Image {  get; set; }
    }
}

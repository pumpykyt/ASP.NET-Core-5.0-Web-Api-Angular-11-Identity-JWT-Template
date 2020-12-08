using System.ComponentModel.DataAnnotations;

namespace MovieProject.DAL.Entities
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int Mark { get; set; }
        public int MovieId { get; set; }
        public virtual Movie reviewMovie { get; set; }
        public string UserId { get; set; }
        public virtual User userReview { get; set; }
    }
}
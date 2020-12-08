using System.ComponentModel.DataAnnotations;

namespace MovieProject.DAL.Entities
{
    public class Announcement
    {
        [Key]
        public int Id { get; set; }
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
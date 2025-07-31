using System.ComponentModel.DataAnnotations;

namespace DiaryEntry.Models
{
    public class DiaryModel
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Content { get; set; } = string.Empty;

        [Required]
        public DateTime Created { get; set; } = DateTime.Now;
    }
}

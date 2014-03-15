using System;
using System.ComponentModel.DataAnnotations;

namespace LoadTestWebApp.Domain.Models
{
    public class Post : IAuditable
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }

        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }

        public DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}

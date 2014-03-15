using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LoadTestWebApp.Domain.Models
{
    public class Blog : IAuditable
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Blog Name")]
        public string Name { get; set; }

        public virtual List<Post> Posts { get; set; }

        public DateTime UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tccp.Models
{
    public class Post
    {
        public Guid? Id { get; set; }
        public DateTime? Created { get; set; }

        [Required]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required]
        public string Message { get; set; }
    }
}
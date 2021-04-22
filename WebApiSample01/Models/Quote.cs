using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiSample01.Models
{
    public class Quote
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Title { get; set; }

        [Required]
        [StringLength(10)]
        public string Author { get; set; }

        [Required]
        [StringLength(25)]
        public string Description { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }

    }
}
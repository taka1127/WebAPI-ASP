using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSample01.Models
{
    public class Quote
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public DateTime CreateAt { get; set; }

    }
}
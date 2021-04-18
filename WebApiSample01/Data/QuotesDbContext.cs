using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApiSample01.Models;

namespace WebApiSample01.Data
{
    public class QuotesDbContext : DbContext
    {
        public DbSet<Quote> Quotes { get; set; }
    }
}
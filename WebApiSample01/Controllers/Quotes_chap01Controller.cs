using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSample01.Data;
using WebApiSample01.Models;

namespace WebApiSample01.Controllers
{
    public class Quotes_chap01Controller_chap01 : ApiController
    {
        QuotesDbContext quotesDbContext = new QuotesDbContext();

        // GET: api/Quotes
        public IEnumerable<Quote> Get()
        {
            return quotesDbContext.Quotes;
        }

        // GET: api/Quotes/5
        public Quote Get(int id)
        {
            var quote = quotesDbContext.Quotes.Find(id);
            return quote;
        }

        // POST: api/Quotes
        public void Post([FromBody]Quote quote)
        {
            quotesDbContext.Quotes.Add(quote);
            quotesDbContext.SaveChanges();
        }

        // PUT: api/Quotes/5
        public void Put(int id, [FromBody]Quote quote)
        {
            var entity = quotesDbContext.Quotes.FirstOrDefault(data => data.Id == id);
            //var entity = quotesDbContext.Quotes.Find(data => data.Id == id);
            entity.Title = quote.Title;
            entity.Author = quote.Author;
            entity.Description = quote.Description;
            quotesDbContext.SaveChanges();
        }

        // DELETE: api/Quotes/5
        public void Delete(int id)
        {
            var quote = quotesDbContext.Quotes.Find(id);
            quotesDbContext.Quotes.Remove(quote);
            quotesDbContext.SaveChanges();
        }
    }
}

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
    public class Quotes_chap03Controller : ApiController
    {
        QuotesDbContext quotesDbContext = new QuotesDbContext();

        // GET: api/Quotes_chap03
        public IEnumerable<Quote> Get()
        {
            return quotesDbContext.Quotes;
        }

        // GET: api/Quotes_chap03/5
        public IHttpActionResult Get(int id)
        {
            var quote = quotesDbContext.Quotes.Find(id);
            if (quote == null)
            {
                NotFound();
            }
            return Ok(quote);
        }

        // POST: api/Quotes_chap03
        public IHttpActionResult Post([FromBody]Quote quote)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            quotesDbContext.Quotes.Add(quote);
            quotesDbContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }

        // PUT: api/Quotes_chap03/5
        public IHttpActionResult Put(int id, [FromBody]Quote quote)
        {
            var entity = quotesDbContext.Quotes.FirstOrDefault(data => data.Id == id);
            //var entity = quotesDbContext.Quotes.Find(data => data.Id == id);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (entity == null)
            {
                return BadRequest("リクエスト失敗。。。");
            }
            entity.Title = quote.Title;
            entity.Author = quote.Author;
            entity.Description = quote.Description;
            quotesDbContext.SaveChanges();
            return Ok("リクエスト成功！");
        }

        // DELETE: api/Quotes_chap03/5
        public IHttpActionResult Delete(int id)
        {
            var quote = quotesDbContext.Quotes.Find(id);
            if (quote == null)
            {
                return BadRequest("リクエスト失敗。。。");
            }
            quotesDbContext.Quotes.Remove(quote);
            quotesDbContext.SaveChanges();
            return Ok("リクエスト成功！");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiSample01.Models;

namespace WebApiSample01.Controllers
{
    public class bac_QuotesController : ApiController
    {
        static List<Quote> _quotes = new List<Quote>()
        {
            new Quote() {Id = 0 ,Author = "山本",Description = "えんぴつ", Title = "事務用品" },
            new Quote() {Id = 1 ,Author = "本田",Description = "消しゴム", Title = "事務用品" }
        };

        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }
        // [FromBody]:引数の値がHTTPリクエストのBodyの値であることを表す
        public void Post([FromBody] Quote quote)
        {
            _quotes.Add(quote);
        }

        public void Put(int id, [FromBody] Quote quote)
        {
            _quotes[id] = quote;
        }

        public void Delete(int id)
        {
            _quotes.RemoveAt(id);
        }
    }
}

using AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AspMVC.Controllers
{
    public class ArticleController : ApiController
    {
        // GET: api/Article
        public ICollection<Article> Get()
        {
            WikiDbContext context = new WikiDbContext();
            var articles = context.Articles.ToList();
            return articles;
        }

        // GET: api/Article/5
        public Article Get(int id)
        {
            WikiDbContext context = new WikiDbContext();
            var article = context.Articles.FirstOrDefault(c => c.Id == id);
            return article;
        }

        // POST: api/Article
        public void Post([FromBody]Article article)
        {
            WikiDbContext context = new WikiDbContext();
            context.Articles.Add(article);
        }

        // PUT: api/Article/5
        public void Put(int id, [FromBody]Article article)
        {
            WikiDbContext context = new WikiDbContext();
            var edit = context.Articles.FirstOrDefault(e => e.Id == article.Id);
            edit.Content = article.Content;
            edit.Created = article.Created;
            edit.Image = article.Image;
            edit.Theme = article.Theme;
            edit.Author = article.Author;
        }

        // DELETE: api/Article/5
        public void Delete(int id)
        {
            WikiDbContext context = new WikiDbContext();
            var delete = context.Articles.FirstOrDefault(d => d.Id == id);
            context.Articles.Remove(delete);
        }
    }
}

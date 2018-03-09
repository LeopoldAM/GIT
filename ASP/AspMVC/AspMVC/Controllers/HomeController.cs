using AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int page = 0)
        {
            int nbItems = 10;
            WikiDbContext context = new WikiDbContext();
            var articles = context.Articles.OrderBy(a => a.Created).Skip(page * nbItems).Take(nbItems).ToList(); // ordonner par date , skip le nombre de article selon la page 2 * nbr article
            var posts = context.Articles.Count(); //nombre d'articles
            ViewBag.nbPage = posts / 10;
            if (TempData["ResultSearch"] is null)
            {
                return View(articles);
            }
            else
            {
                ViewBag.display = "Le résultat de la recherche";
                return View(TempData["ResultSearch"]);
            }
        }

        [HttpPost]
        public ActionResult Search(string search)
        {
            WikiDbContext context = new WikiDbContext();
            var posts = context.Articles.Where(a => a.Content.Contains(search)).ToList();
            TempData["ResultSearch"] = posts;
            return RedirectToAction("Index");

        }

        public ActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Form(Article article)
        {
            if (!ModelState.IsValid)
            {
                return View(article);
            }
            WikiDbContext context = new WikiDbContext();
            context.Articles.Add(article);
            context.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Details(int id)
        {
            WikiDbContext context = new WikiDbContext();
            var article = context.Articles.FirstOrDefault(c => c.Id == id);
            return View(article);
        }


        [HttpPost]
        public ActionResult AjouterCom(Commentaire commentaire)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Content", "erreur format : ecrire seulement des lettres");
                return View(commentaire);
            }
            WikiDbContext context = new WikiDbContext();
            context.Comments.Add(commentaire);
            context.SaveChanges();
            //return RedirectToAction("Details",new { id = commentaire.ArticleId });
            return PartialView("_displayComments", context.Comments.Where(c => c.ArticleId == commentaire.ArticleId).ToList());
        }



        public ActionResult DeleteCom(int id)
        {
            WikiDbContext context = new WikiDbContext();
            var delete = context.Comments.FirstOrDefault(d => d.Id == id);
            context.Comments.Remove(delete);
            context.SaveChanges();
            return PartialView("_displayComments", context.Comments.Where(c => c.ArticleId == delete.ArticleId).ToList());
        }

        public ActionResult Edit(int id)
        {
            WikiDbContext context = new WikiDbContext();
            var edit = context.Articles.FirstOrDefault(e => e.Id == id);
            return View(edit);
        }

        [HttpPost]
        public ActionResult Edit(Article article)
        {
            if (!ModelState.IsValid)
            {
                return View(article);
            }
            WikiDbContext context = new WikiDbContext();
            var edit = context.Articles.FirstOrDefault(e => e.Id == article.Id);
            edit.Content = article.Content;
            edit.Created = article.Created;
            edit.Image = article.Image;
            edit.Theme = article.Theme;
            edit.Author = article.Author;
            context.SaveChanges();
            return View(edit);
        }
        public ActionResult Delete(int id)
        {
            WikiDbContext context = new WikiDbContext();
            var delete = context.Articles.FirstOrDefault(d => d.Id == id);
            context.Articles.Remove(delete);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

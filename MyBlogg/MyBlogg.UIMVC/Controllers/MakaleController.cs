using MyBlogg.DAL.Concrates.EF;
using MyBlogg.DAL.Concrates.EF.GenericRepositoryPattern.Units;
using MyBlogg.Model;
using MyBlogg.UIMVC.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI;

namespace MyBlogg.UIMVC.Controllers
{
    public class MakaleController : Controller
    {
        public ActionResult BlogList(int catID, string btnDetayGetir, int pageNum = 1)
        {
            IQueryable<Blog_Makale> liste = null; string seoBaslikk="";
            using (BasicProcessUnit worker = new BasicProcessUnit())
            {
                liste = worker.Blog_MakaleRepository.Select(p => p.b_MMKategoryID == catID);
                if (liste.FirstOrDefault() != null )
                {
                    ViewData["makaleKategori"] = liste.FirstOrDefault().Makale.m_Baslik;
                    seoBaslikk = liste.FirstOrDefault().b_MBaslik;
                    ViewData["anaKategori"] = liste.FirstOrDefault().Makale.m_AnaKategori;
                }       
            }
            
            ViewData["catID"] = catID;

            if (btnDetayGetir != null && btnDetayGetir != "")
            {
                int idd = Convert.ToInt32(btnDetayGetir);
                return RedirectToAction("BlogMakale", "Makale", new { id = idd.ToString(), seoBaslik = seoBaslikk, ustKategori = ViewData["anaKategori"] });
            }
            else
            {
                return View();
            }
        }

        public ActionResult MakaleListPartial(int catID, int pageNum = 1)
        {
            IQueryable<Blog_Makale> liste = null;
            using (BasicProcessUnit worker = new BasicProcessUnit())
            {
                liste = worker.Blog_MakaleRepository.Select(p => p.b_MMKategoryID == catID);
            }
            foreach (var item in liste)
            {
                ViewData["makaleKategori"] = item.Makale.m_Baslik;
                break;
            }
            var pagedData = new PagerData<Blog_Makale>();
            int PageSize = 6;
            pagedData.Data = liste.OrderBy(d => d.b_MakaleID).Skip(PageSize * (pageNum - 1)).Take(PageSize);
            pagedData.NumberOfPages = Convert.ToInt32(Math.Ceiling((double)liste.Count() / PageSize));
            pagedData.CurrentPage = pageNum;
            return PartialView("Partials/_MakaleListPartial", pagedData);
        }

        public ActionResult BlogMakale(int id, string seoBaslik, int ustKategori)
        {
            Blog_Makale makale;
            using (BasicProcessUnit worker = new BasicProcessUnit())
            {
                makale = worker.Blog_MakaleRepository.FindById(id);
            }
            return View(makale);
        }

        public ActionResult MakaleKategoriCountPartial(int ustKategori)
        {
            IEnumerable<Blog_Makale> liste;
            using (BasicProcessUnit worker = new BasicProcessUnit())
            {
                liste = worker.Blog_MakaleRepository.Select(d => d.Makale.m_AnaKategori == ustKategori);
                ViewData["anaKategori"] = worker.MakaleCategoryRepository.FindById(ustKategori).mk_Adi;
            }
            return PartialView("Partials/_MakaleKategoriCountPartial", liste);
        }


        /// <summary>
        /// 3 saniyede bir yenileniyor.BlogMakale.cs.html
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PartialViewResult MakaleCommentsPartial(int id)
        {
            IQueryable<MakaleYorumlar> liste;
            using (BasicProcessUnit worker = new BasicProcessUnit())
            {
                liste = worker.MakaleYorumlarRepository.Select(d => d.b_MakaleID == id).OrderByDescending(d=>d.y_Tarih);
            }
            return PartialView("Partials/_MakaleCommentsPartial", liste);
        }

        public PartialViewResult MakaleCommentFormPartial(string button, MakaleYorumlar my)
        {
            //switch (button)
            //{
            //    case "sendMessage":
            //        {
            //            using (BasicProcessUnit worker = new BasicProcessUnit())
            //            {
            //                worker.MakaleYorumlarRepository.Insert(my);
            //            }
            //        }
            //}
            return PartialView("Partials/_MakaleCommentFormPartial");
        }

        public PartialViewResult MakaleCommentAdd(MakaleYorumlar my)
        {
            return PartialView("Partials/_MakaleCommentFormPartial");
        }


    }
}

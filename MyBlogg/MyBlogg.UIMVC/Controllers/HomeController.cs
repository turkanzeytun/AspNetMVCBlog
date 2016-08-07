using MyBlogg.DAL.Concrates.EF;
using MyBlogg.DAL.Concrates.EF.GenericRepositoryPattern.Units;
using MyBlogg.Model;
using System.Collections;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MyBlogg.UIMVC.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Blog()
        {
            return View();
        }

        public ActionResult MakaleKategoriListPartial()
        {
            IEnumerable<MakaleKategori> liste;

            using (BasicProcessUnit worker = new BasicProcessUnit())
            {
                liste = worker.MakaleCategoryRepository.Select();
                #region 
                string a = "";
                foreach (var book in liste)
                {
                    a += " " + book.mk_Adi;
                } 
                #endregion
            }

            return View("Partials/_MakaleKategoriListPartial", liste);
        }

        

    }
}

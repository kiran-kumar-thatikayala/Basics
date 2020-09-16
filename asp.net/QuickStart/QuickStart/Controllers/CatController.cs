using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NHibernate;
using System.Web.Mvc;

namespace QuickStart.Controllers
{
    public class CatController : Controller
    {
        // GET: Cat
        public ActionResult Index()
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            IList<Cat> catList = new List<Cat>();
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    var cats = session.Query<Cat>();
                    catList = cats.ToList();
                    tx.Commit();
                }
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
            return View(catList);
        }

        // GET: Cat/Create
        public ActionResult Create()
        {
            ISession session = NHibernateHelper.GetCurrentSession();
            try
            {
                using (ITransaction tx = session.BeginTransaction())
                {
                    var princess = new Cat
                    {
                        Name = "Princess",
                        Sex = 'F',
                        Weight = 7.4f
                    };

                    session.Save(princess);
                    tx.Commit();
                }
            }
            catch(Exception exception)
            {
                throw exception;
            }
            finally
            {
                NHibernateHelper.CloseSession();
            }
            return View();
        }

        // POST: Cat/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

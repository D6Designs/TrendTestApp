using Autofac;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrendTestApp.EntityModel;
using TrendTestApp.Models;
using TrendTestApp.ModelServices.Interfaces;
using TrendTestApp.Web;
using TrendTestApp.WebApp.Models;

namespace TrendTestApp.WebApp.Controllers
{
    public class CompaniesController : Controller
    {
        TrendEntities db = new TrendEntities();

        protected List<CompanyViewModel> AllCompanies;

        protected CompanyViewModel FoundCompany;

        private ICompanyModelService _companyModelService;

        // GET: Companies
        public ActionResult Index()
        {
            _companyModelService = IoCInit.GetScope().Resolve<ICompanyModelService>();
            AllCompanies = _companyModelService.GetAllCompanies();
            return View(AllCompanies);
        }

        // GET: Companies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            _companyModelService = IoCInit.GetScope().Resolve<ICompanyModelService>();
            FoundCompany = _companyModelService.SearchByCompanyId(Convert.ToInt32(id));

            if (FoundCompany == null)
            {
                return HttpNotFound();
            }
            return View(FoundCompany);
        }

        // GET: Companies/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Companies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CompanyId,CompanyName,VATNumber")] CompanyViewModel companyViewModel)
        {
            if (ModelState.IsValid)
            {
             //   db.Companies.Add(Company);
              //  db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(companyViewModel);
        }

        // GET: Companies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            _companyModelService = IoCInit.GetScope().Resolve<ICompanyModelService>();
            FoundCompany = _companyModelService.SearchByCompanyId(Convert.ToInt32(id));

            if (FoundCompany == null)
            {
                return HttpNotFound();
            }
            return View(FoundCompany);
        }

        // POST: Companies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CompanyId,CompanyName,VATNumber")] CompanyViewModel companyViewModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(companyViewModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(companyViewModel);
        }

        // GET: Companies/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            _companyModelService = IoCInit.GetScope().Resolve<ICompanyModelService>();
            FoundCompany = _companyModelService.SearchByCompanyId(Convert.ToInt32(id));


            if (FoundCompany == null)
            {
                return HttpNotFound();
            }
            return View(FoundCompany);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            _companyModelService = IoCInit.GetScope().Resolve<ICompanyModelService>();
            FoundCompany = _companyModelService.SearchByCompanyId(Convert.ToInt32(id));

      //      db.Companies.Remove(FoundCompany);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

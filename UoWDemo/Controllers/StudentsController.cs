using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using UoWDemo.DAL;
using UoWDemo.Models;
using UoWDemo.UoW;

namespace UoWDemo.Controllers
{
    public class StudentsController : Controller
    {
        private InformationContext db = new InformationContext();
        private UnitOfWork uow;
        public StudentsController()
        {
            this.uow = new UnitOfWork();
        }
        // GET: Students
        public ActionResult Index()
        {
            return View(uow.StudentRepository.GetAll());
        }

        // GET: Students/Details/5
        public ActionResult Details(int id)
        {
            Student student = uow.StudentRepository.FindById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // GET: Students/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Age,Standard,Marks")] Student student)
        {
            if (ModelState.IsValid)
            {
                uow.StudentRepository.Add(student);
                uow.Save();
                return RedirectToAction("Index");
            }

            return View(student);
        }

        // GET: Students/Edit/5
        public ActionResult Edit(int id)
        {
            Student student = uow.StudentRepository.FindById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Age,Standard,Marks")] Student student)
        {
            if (ModelState.IsValid)
            {
                uow.StudentRepository.Edit(student);
                uow.Save();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int id)
        {
            Student student = uow.StudentRepository.FindById(id);
            if (student == null)
            {
                return HttpNotFound();
            }
            return View(student);
        }

        // POST: Students/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            uow.StudentRepository.DeleteById(id);
            uow.Save();
            return RedirectToAction("Index");
        }
    }
}

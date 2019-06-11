using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class ProblemController : Controller
    {
        private readonly IProblemService _problemService;
        private Problem problem;

        public ProblemController(IProblemService problemService)
        {
            _problemService = problemService;           
        }

        // GET: Problem
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> Get(int id)
        {
            var problem = await _problemService.Find(id);

            return PartialView(problem);
        }

        // GET: Problem/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Problem/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Problem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                problem = new Problem
                {
                    Name = collection["Name"],
                    Condition = collection["Condition"],
                    Example = collection["Example"],
                    Level = Convert.ToInt32(collection["Level"]),
                    Notation = collection["Notation"],
                    Template = collection["Template"]
                };

                _problemService.Create(problem);

                Problem createdProblem = _problemService.GetProblemName(problem.Name).Result.Cast<Problem>().First();               

                return RedirectToAction("Create", "Test", new { problemId = createdProblem.Id });
            }
            catch
            {
                return View();
            }
        }

        // GET: Problem/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Problem/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Problem/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Problem/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult FinishProblem(ICollection<Test> tests)
        {
            problem.Tests = tests;

            _problemService.Update(problem);

            return RedirectToAction("Index", "Home");
        }

        //TO FIX

        //public ActionResult AddTest()
        //{
        //    ViewBag.ToShowTest = 1;

        //    return Redirect("~/Problem/Create");
        //}
    }
}
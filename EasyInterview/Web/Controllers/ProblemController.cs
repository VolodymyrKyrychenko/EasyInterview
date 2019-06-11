using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System;
using System.Linq;
using System.Threading.Tasks;
using Web.Models;

namespace Web.Controllers
{
    public class ProblemController : Controller
    {
        private readonly IProblemService _problemService;

        private readonly ITestService _testService;

        public ProblemController(IProblemService problemService/*, ITestService testService*/)
        {
            _problemService = problemService;
            //_testService = testService;
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
            ViewBag.ToShowTest = 1;     //TO FIX

            return View();
        }

        // POST: Problem/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            //try
            //{
                // TODO: Add insert logic here

                Problem problem = new Problem
                {
                    Name = collection["Name"],
                    Condition = collection["Condition"],
                    Example = collection["Example"],
                    Level = Convert.ToInt32(collection["Level"]),
                    Notation = collection["Notation"],
                    Template = collection["Template"]
                };

                _problemService.Create(problem);

                //Problem createdProblem = _problemService.GetProblemName(problem.Name).Result.Cast<Problem>().First();

                //Test test = new Test
                //{
                //    Number = Convert.ToInt32(collection["Number"]),
                //    Hidden = Convert.ToBoolean(collection["Hidden"]),
                //    Input = collection["Input"],
                //    Output = collection["Output"],
                //    ProblemId = createdProblem.Id,
                //    Problem = createdProblem
                //};

                //_testService.Create(test);

                return RedirectToAction("Index", "Home");
            //}
            //catch
            //{
            //    return View();
            //}
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

        //TO FIX

        //public ActionResult AddTest()
        //{
        //    ViewBag.ToShowTest = 1;

        //    return View("Create");
        //}
    }
}
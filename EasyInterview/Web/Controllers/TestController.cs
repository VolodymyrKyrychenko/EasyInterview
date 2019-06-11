using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace Web.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestService _testService;
        private int _problemId;
        ICollection<Test> tests = new List<Test>();

        public TestController(ITestService testService)
        {
            _testService = testService;
            //tests = new List<Test>();
        }

        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        // GET: Test/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Test/Create
        public ActionResult Create(int problemId)
        {
            _problemId = problemId;
            return View();
        }

        // POST: Test/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                Test test = new Test
                {
                    Number = Convert.ToInt32(collection["Number"]),
                    Hidden = Convert.ToBoolean(collection["Hidden"]),
                    Input = collection["Input"],
                    Output = collection["Output"],
                    ProblemId = _problemId
                    //Problem = _problem
                };

                _testService.Create(test);

                tests.Add(test);

                return View(); //RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Test/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Test/Edit/5
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

        // GET: Test/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Test/Delete/5
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

        public ActionResult FinishTests()
        {            
            return RedirectToAction("FinishProblem", "Problem", tests);
        }
    }
}
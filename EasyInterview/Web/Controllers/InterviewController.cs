using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Enums;
using Services.Interfaces;
using System.Threading.Tasks;

namespace Web.Controllers
{
    public class InterviewController : Controller
    {
        private readonly IInterviewService _interviewService;

        public InterviewController(IInterviewService interviewService)
        {
            _interviewService = interviewService;
        }

        // GET: Interview
        public ActionResult Index()
        {
            return View("Interview");
        }

        public async Task<ActionResult> Get(InterviewStatus status)
        {
            var interviews = await _interviewService.Get(status);

            return View();
        }

        // GET: Interview/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Interview/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Interview/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Interview/Edit/5
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

        // GET: Interview/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Interview/Delete/5
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
    }
}
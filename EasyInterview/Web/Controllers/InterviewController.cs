using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Enums;
using Services.Interfaces;
using System.Threading.Tasks;
using System;


namespace Web.Controllers
{
    public class InterviewController : Controller
    {
        private readonly IInterviewService _interviewService;
		private Interview interview;
		private readonly ILibraryService _libraryService;
	

        public InterviewController(IInterviewService interviewService, ILibraryService libraryService)
        {
            _interviewService = interviewService;
			_libraryService = libraryService;
        }
			
        // GET: Interview
        public ActionResult Index()
        {
            return View("Interview");
        }

		public async Task<ActionResult> List()
		{
			var interviews = await _interviewService.GetAll();
			return View("InterviewList",interviews);
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
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
				// TODO: Add insert logic here
				interview = new Interview
				{
					Report = "",
					Start = DateTime.Now,	
					Finish = DateTime.Now,
					LibraryId = 1,																
					CandidateId = Convert.ToInt16(collection["CandidateId"]),
					Candidate = new Candidate()
				};
				await _interviewService.Create(interview);

				Interview createdInterview = await _interviewService.GetbyId(interview.Id);

				return RedirectToAction("Create", "Test", new { candidateId = createdInterview.Id });
				
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

		public static implicit operator InterviewController(Interview v)
		{
			throw new NotImplementedException();
		}
	}
}
using Common.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using Web.Models.LibraryModels;
using Web.Models.Problem;

namespace Web.Controllers
{
    public class LibraryController : Controller
    {
        private readonly ILibraryService _libraryService;
        private readonly IProblemService _problemService;
        private readonly IMappingService _mappingService;

        public LibraryController(ILibraryService libraryService, IMappingService mappingService, IProblemService problemService)
        {
            _libraryService = libraryService;
            _mappingService = mappingService;
            _problemService = problemService;
        }

        public async Task<ActionResult> Index()
        {
            var defaultLibrary = await _libraryService.Get("Default");
            var library = await _libraryService.Get("Company");

            var libraryModel = new LibraryViewModel
            {
                Default = defaultLibrary,
                Library = library
            };

            return View(libraryModel);
        }

        // GET: Library/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var problem = await _problemService.Get(id);

            return PartialView(problem);
        }

        // GET: Library/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Library/Create
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

        // GET: Library/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Library/Edit/5
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

        // GET: Library/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Library/Delete/5
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
using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using EasyInterview.BLL.Interfaces;
using EasyInterview.Core.Entities;
using EasyInterview.WEB.Models.ModelViewEntities;

namespace EasyInterview.WEB.Controllers
{
    public class TaskController : Controller
    {
        private readonly IService<Exercise> _service;

        public TaskController(IService<Exercise> service)
        {
            _service = service;
        }

        public ViewResult Index()
        {
            var tasks = _service.GetAll();

            var tasksView = Mapper.Map<IEnumerable<Exercise>, List<TaskModelView>>(tasks);

            return View(tasksView);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View(new TaskModelView());
        }

        [HttpPost]
        public ActionResult Create(TaskModelView taskView)
        {
            if (ModelState.IsValid)
            {
                var task = Mapper.Map<TaskModelView, Exercise>(taskView);

                _service.Create(task);

                return RedirectToAction("Index");
            }

            return View(taskView);
        }

        [HttpGet]
        public ViewResult Edit(int id)
        {
            var task = _service.Get(id);

            var taskView = Mapper.Map<Exercise, TaskModelView>(task);

            return View(taskView);
        }

        [HttpPost]
        public ActionResult Edit(TaskModelView taskView)
        {
            if (ModelState.IsValid)
            {
                var task = _service.Get(taskView.Id);

                Mapper.Map(taskView, task);

                _service.Update(task);

                return RedirectToAction("Index");
            }

            return View(taskView);
        }

        public ViewResult Details(int id)
        {
            var task = _service.Get(id);

            var taskView = Mapper.Map<Exercise, TaskModelView>(task);

            return View(taskView);
        }

        public ActionResult Delete(int id)
        {
            _service.Delete(id);

            return RedirectToAction("Index");
        }
    }
}
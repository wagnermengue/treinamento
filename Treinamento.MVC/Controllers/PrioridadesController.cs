using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.MVC.ViewModels;

namespace Treinamento.MVC.Controllers
{
    public class PrioridadesController : Controller
    {

        private readonly IPrioridadeAppService _prioridadeApp;

        public PrioridadesController(IPrioridadeAppService prioridadeApp)
        {
            _prioridadeApp = prioridadeApp;
        }

        // GET: Prioridades
        public ActionResult Index()
        {
            var prioridadeViewModel = Mapper.Map<IEnumerable<Prioridade>, IEnumerable<PrioridadeViewModel>>(_prioridadeApp.GetAll());
            return View(prioridadeViewModel);
        }

        // GET: Prioridades/Details/5
        public ActionResult Details(int id)
        {
            var prioridade = _prioridadeApp.GetById(id);
            var prioridadeViewModel = Mapper.Map<Prioridade, PrioridadeViewModel>(prioridade);

            return View(prioridadeViewModel);
        }

        // GET: Prioridades/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Prioridades/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PrioridadeViewModel prioridade)
        {
            if (ModelState.IsValid)
            {
                var prioridadeDomain = Mapper.Map<PrioridadeViewModel, Prioridade>(prioridade);
                _prioridadeApp.Add(prioridadeDomain);

                return RedirectToAction("Index");
            }
            return View(prioridade);
        }

        // GET: Prioridades/Edit/5
        public ActionResult Edit(int id)
        {
            var prioridade = _prioridadeApp.GetById(id);
            var prioridadeViewModel = Mapper.Map<Prioridade, PrioridadeViewModel>(prioridade);

            return View(prioridadeViewModel);
        }

        // POST: Prioridades/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PrioridadeViewModel prioridade)
        {
            if (ModelState.IsValid)
            {
                var prioridadeDomain = Mapper.Map<PrioridadeViewModel, Prioridade>(prioridade);
                _prioridadeApp.Update(prioridadeDomain);

                return RedirectToAction("Index");
            }

            return View(prioridade);
        }

        // GET: Prioridades/Delete/5
        public ActionResult Delete(int id)
        {
            var prioridade = _prioridadeApp.GetById(id);
            var prioridadeViewModel = Mapper.Map<Prioridade, PrioridadeViewModel>(prioridade);

            return View(prioridadeViewModel);
        }

        // POST: Prioridades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var prioridade = _prioridadeApp.GetById(id);
            _prioridadeApp.Remove(prioridade);

            return RedirectToAction("Index");
        }
    }
}

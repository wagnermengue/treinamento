using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.MVC.ViewModels;

namespace Treinamento.MVC.Controllers
{
    public class PessoasController : Controller
    {

        private readonly IPessoaAppService _pessoaApp;

        public PessoasController(IPessoaAppService pessoaApp)
        {
            _pessoaApp = pessoaApp;
        } 

        // GET: Pessoas
        public ActionResult Index()
        {
            var pessoaViewModel = Mapper.Map<IEnumerable<Pessoa>, IEnumerable<PessoaViewModel>>(_pessoaApp.GetAll());
            return View(pessoaViewModel);
        }

        // GET: Pessoas/Details/5
        public ActionResult Details(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);

            return View(pessoaViewModel);
        }

        // GET: Pessoas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pessoas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<PessoaViewModel, Pessoa>(pessoa);
                _pessoaApp.Add(pessoaDomain);

                return RedirectToAction("Index");
            }
            return View(pessoa);
        }

        // GET: Pessoas/Edit/5
        public ActionResult Edit(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);

            return View(pessoaViewModel);
        }

        // POST: Pessoas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(PessoaViewModel pessoa)
        {
            if (ModelState.IsValid)
            {
                var pessoaDomain = Mapper.Map<PessoaViewModel, Pessoa>(pessoa);
                _pessoaApp.Update(pessoaDomain);

                return RedirectToAction("Index");
            }

            return View(pessoa);
        }

        // GET: Pessoas/Delete/5
        public ActionResult Delete(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            var pessoaViewModel = Mapper.Map<Pessoa, PessoaViewModel>(pessoa);

            return View(pessoaViewModel);
        }

        // POST: Pessoas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var pessoa = _pessoaApp.GetById(id);
            _pessoaApp.Remove(pessoa);

            return RedirectToAction("Index");
        }
    }
}

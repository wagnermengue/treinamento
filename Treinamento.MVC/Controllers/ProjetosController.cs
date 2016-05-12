using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.MVC.ViewModels;

namespace Treinamento.MVC.Controllers
{
    public class ProjetosController : Controller
    {
        //como utilizo 2 pessoas tem que verificar se precisará de mais 1 variavel
        private readonly IPessoaAppService _pessoaApp;
        private readonly IStatusAppService _statusApp;
        private readonly IProjetoAppService _projetoApp;

        public ProjetosController(IPessoaAppService pessoaApp, IStatusAppService statusApp, IProjetoAppService projetoApp)
        {
            _pessoaApp = pessoaApp;
            _statusApp = statusApp;
            _projetoApp = projetoApp;
        }

        // GET: Projetos
        public ActionResult Index()
        {
            var projetoViewModel = Mapper.Map<IEnumerable<Projeto>, IEnumerable<ProjetoViewModel>>(_projetoApp.GetAll());
            return View(projetoViewModel);
        }

        // GET: Projetos/Details/5
        public ActionResult Details(int id)
        {
            var projeto = _projetoApp.GetById(id);
            var projetoViewModel = Mapper.Map<Projeto, ProjetoViewModel>(projeto);

            return View(projetoViewModel);
        }

        // GET: Projetos/Create
        public ActionResult Create()
        {
            ViewBag.IdPessoa = new SelectList(_pessoaApp.GetAll(), "IdPessoa", "Nome");
            ViewBag.IdStatus = new SelectList(_statusApp.GetAll(), "IdStatus", "Descricao");
            return View();
        }

        // POST: Projetos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjetoViewModel projeto)
        {
            if (ModelState.IsValid)
            {
                var projetoDomain = Mapper.Map<ProjetoViewModel, Projeto>(projeto);
                _projetoApp.Add(projetoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.IdPessoa = new SelectList(_pessoaApp.GetAll(), "IdPessoa", "Nome", projeto.IdPessoa);
            ViewBag.IdStatus = new SelectList(_statusApp.GetAll(), "IdPessoa", "Nome", projeto.IdStatus);
            ViewBag.Responsavel = new SelectList(_pessoaApp.GetAll(), "IdPessoa", "Nome", projeto.Responsavel);
            return View(projeto);
        }

        // GET: Projetos/Edit/5
        public ActionResult Edit(int id)
        {
            var projeto = _projetoApp.GetById(id);
            var projetoViewModel = Mapper.Map<Projeto, ProjetoViewModel>(projeto);

            return View(projetoViewModel);
        }

        // POST: Projetos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProjetoViewModel projeto)
        {
            if (ModelState.IsValid)
            {
                var projetoDomain = Mapper.Map<ProjetoViewModel, Projeto>(projeto);
                _projetoApp.Update(projetoDomain);

                return RedirectToAction("Index");
            }

            return View(projeto);
        }

        // GET: Projetos/Delete/5
        public ActionResult Delete(int id)
        {
            var projeto = _projetoApp.GetById(id);
            var projetoViewModel = Mapper.Map<Projeto, ProjetoViewModel>(projeto);

            return View(projetoViewModel);
        }

        // POST: Projetos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var projeto = _projetoApp.GetById(id);
            _projetoApp.Remove(projeto);

            return RedirectToAction("Index");
        }
    }
}

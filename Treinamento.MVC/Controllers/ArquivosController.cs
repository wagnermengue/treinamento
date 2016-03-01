using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.MVC.ViewModels;

namespace Treinamento.MVC.Controllers
{
    public class ArquivosController : Controller
    {

        private readonly IArquivoAppService _arquivoApp;
        private readonly IProjetoAppService _projetoApp;

        public ArquivosController(IArquivoAppService arquivoApp, IProjetoAppService projetoApp)
        {
            _arquivoApp = arquivoApp;
            _projetoApp = projetoApp;
        }


        // GET: Arquivos
        public ActionResult Index()
        {
            var arquivoViewModel = Mapper.Map<IEnumerable<Arquivo>, IEnumerable<ArquivoViewModel>>(_arquivoApp.GetAll());
            return View(arquivoViewModel);
        }

        // GET: Arquivos/Details/5
        public ActionResult Details(int id)
        {
            var arquivo = _arquivoApp.GetById(id);
            var arquivoViewModel = Mapper.Map<Arquivo, ArquivoViewModel>(arquivo);

            return View(arquivoViewModel);
        }

        // GET: Arquivos/Create
        public ActionResult Create()
        {
            ViewBag.IdProjeto = new SelectList(_projetoApp.GetAll(), "IdProjeto", "Descricao");
            return View();
        }

        // POST: Arquivos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ArquivoViewModel arquivo)
        {
            if (ModelState.IsValid)
            {
                var arquivoDomain = Mapper.Map<ArquivoViewModel, Arquivo>(arquivo);
                _arquivoApp.Add(arquivoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.IdProjeto = new SelectList(_projetoApp.GetAll(), "IdProjeto", "Descricao", arquivo.IdProjeto);
            return View(arquivo);
        }

        // GET: Arquivos/Edit/5
        public ActionResult Edit(int id)
        {
            var arquivo = _arquivoApp.GetById(id);
            var arquivoViewModel = Mapper.Map<Arquivo, ArquivoViewModel>(arquivo);

            return View(arquivoViewModel);
        }

        // POST: Arquivos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ArquivoViewModel arquivo)
        {
            if (ModelState.IsValid)
            {
                var arquivoDomain = Mapper.Map<ArquivoViewModel, Arquivo>(arquivo);
                _arquivoApp.Update(arquivoDomain);

                return RedirectToAction("Index");
            }

            return View(arquivo);
        }

        // GET: Arquivos/Delete/5
        public ActionResult Delete(int id)
        {
            var arquivo = _arquivoApp.GetById(id);
            var arquivoViewModel = Mapper.Map<Arquivo, ArquivoViewModel>(arquivo);

            return View(arquivoViewModel);
        }

        // POST: Arquivos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var arquivo = _arquivoApp.GetById(id);
            _arquivoApp.Remove(arquivo);

            return RedirectToAction("Index");
        }
    }
}

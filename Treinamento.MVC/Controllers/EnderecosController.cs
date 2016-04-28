using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using Treinamento.Application.Interfaces;
using Treinamento.Domain.Entities;
using Treinamento.MVC.ViewModels;

namespace Treinamento.MVC.Controllers
{
    public class EnderecosController : Controller
    {
        private readonly IEnderecoAppService _enderecoApp;
        private readonly IPessoaAppService _pessoaApp;

        public EnderecosController(IEnderecoAppService enderecoApp, IPessoaAppService pessoaApp)
        {
            _enderecoApp = enderecoApp;
            _pessoaApp = pessoaApp;
        }

        // GET: Enderecos
        public ActionResult Index()
        {
            var enderecoViewModel = Mapper.Map<IEnumerable<Endereco>, IEnumerable<EnderecoViewModel>>(_enderecoApp.GetAll());
            return View(enderecoViewModel);
        }

        // GET: Enderecos/Details/5
        public ActionResult Details(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            var enderecoViewModel = Mapper.Map<Endereco, EnderecoViewModel>(endereco);

            return View(enderecoViewModel);
        }

        // GET: Enderecos/Create
        public ActionResult Create()
        {
            ViewBag.IdPessoa = new SelectList(_pessoaApp.GetAll(), "IdPessoa", "Nome");
            return View();
        }

        // POST: Enderecos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EnderecoViewModel endereco)
        {
            if (ModelState.IsValid)
            {
                var enderecoDomain = Mapper.Map<EnderecoViewModel, Endereco>(endereco);
                _enderecoApp.Add(enderecoDomain);

                return RedirectToAction("Index");
            }
            ViewBag.IdPessoa = new SelectList(_pessoaApp.GetAll(), "IdPessoa", "Nome", endereco.IdPessoa);
            return View(endereco);
        }

        // GET: Enderecos/Edit/5
        public ActionResult Edit(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            var enderecoViewModel = Mapper.Map<Endereco, EnderecoViewModel>(endereco);

            return View(enderecoViewModel);
        }

        // POST: Enderecos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EnderecoViewModel endereco)
        {
            if (ModelState.IsValid)
            {
                var enderecoDomain = Mapper.Map<EnderecoViewModel, Endereco>(endereco);
                _enderecoApp.Update(enderecoDomain);

                return RedirectToAction("Index");
            }

            return View(endereco);
        }

        // GET: Enderecos/Delete/5
        public ActionResult Delete(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            var enderecoViewModel = Mapper.Map<Endereco, EnderecoViewModel>(endereco);

            return View(enderecoViewModel);
        }

        // POST: Enderecos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var endereco = _enderecoApp.GetById(id);
            _enderecoApp.Remove(endereco);

            return RedirectToAction("Index");
        }
    }
}

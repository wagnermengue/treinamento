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
            return View();
        }

        // GET: Enderecos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enderecos/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Enderecos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Enderecos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Enderecos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Enderecos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}

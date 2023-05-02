using Cadastro.Interfaces;
using Cadastro.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadastro.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductViewModelService _productViewModelService;
        public ProductsController(IProductViewModelService ProductViewModelService)
        {
            _productViewModelService = ProductViewModelService;
        }

        // GET: Clients
        public ActionResult Index()
        {
            var list = _productViewModelService.GetAll();
            return View(list);
        }

        // GET: Clients/Details/5
        public ActionResult Details(int id)
        {
            var viewModel = _productViewModelService.Get(id);
            return View(viewModel);
        }

        // GET: Clients/Create
        public ActionResult Create()
        {
            ProductViewModel model = new ProductViewModel();
            return View(model);
        }

        // POST: Clients/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel viewModel)
        {
            
            try
            {               
                if (ModelState.IsValid)
                {
                    _productViewModelService.Insert(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                
                return Ok(ModelState);
                // RedirectToAction("Error", "Home");
            }
        }

        // GET: Clients/Edit/5
        public ActionResult Edit(int id)
        {
            var viewModel = _productViewModelService.Get(id);
            return View(viewModel);
        }

        // POST: Clients/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductViewModel viewModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productViewModelService.Update(viewModel);

                    return RedirectToAction(nameof(Index));
                }
                return View(viewModel);
            }
            catch
            {
                return View(viewModel);
            }
        }

        // GET: Clients/Delete/5
        public ActionResult Delete(int id)
        {
            var viewModel = _productViewModelService.Get(id);
            return View(viewModel);
        }

        // POST: Clients/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _productViewModelService.Delete(id);

                    return RedirectToAction(nameof(Index));
                }

                var viewModel = _productViewModelService.Get(id);
                return View(viewModel);
            }
            catch
            {
                var viewModel = _productViewModelService.Get(id);
                return View(viewModel);
            }
        }
    }
}

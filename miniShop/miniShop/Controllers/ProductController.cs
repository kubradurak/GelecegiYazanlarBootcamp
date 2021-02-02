 using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using miniShop.Models;
using miniShop.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Controllers
{
    public class ProductController : Controller
    {
        private IProductService productService;
        private ICategoryService categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            this.productService = productService;
            this.categoryService = categoryService;

        }
        public IActionResult Index()
        {
            var products = productService.GetProducts();
            return View(products);
        }
        
        public IActionResult Create()
        {
            List<SelectListItem> selectListItems = GetCetagoriesForSelect();
            ViewBag.Items = selectListItems;
            return View();

        }

        private List<SelectListItem> GetCetagoriesForSelect()
        {
            var categories = categoryService.GetCategories();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            categories.ToList().ForEach(category => selectListItems.Add(new SelectListItem
            {
                Text = category.Name,
                Value = category.Id.ToString()
            }));
            return selectListItems;
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                productService.AddProduct(product);
                return RedirectToAction(nameof(Index));
            }
            // modelState hatalı olursa comboboxı geri getirmek için

            List<SelectListItem> selectListItems = GetCetagoriesForSelect();
            ViewBag.Items = selectListItems;

            return View();
        }
    }
}

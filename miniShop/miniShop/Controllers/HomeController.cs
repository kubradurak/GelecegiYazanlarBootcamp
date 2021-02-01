using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using miniShop.Models;
using miniShop.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace miniShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductService productService; // önemli nokta 1

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService; // önemli nokta 2

        }


        public IActionResult Index(int page = 1)
        {
            var pageSize = 4;
            var products = productService.GetProducts();
            var pagingProducts = products.OrderBy(p => p.Id)
                                          .Skip((page-1)*pageSize) // atlanacak sayı
                                          .Take(pageSize); // atlandıktan sonra tutacak satır sayısı
            /*
             * 1. sayfa: 0 atla 4 göster
             * 2. sayfa: 4 atla 4 göster
             * 3. sayfa: 8 atla 4 göster
             * 4. sayfa: 10 atla 4 göster 
             * */
            var totalProduct = products.Count;            
            var totalPages = Math.Ceiling((decimal) totalProduct / pageSize);

            ViewBag.TotalPages = totalPages; 

            return View(pagingProducts);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

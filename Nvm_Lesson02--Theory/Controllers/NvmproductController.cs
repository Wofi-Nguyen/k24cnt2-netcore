using Microsoft.AspNetCore.Mvc;
using Nvm_Lesson02__Theory.Models;

namespace Nvm_Lesson02__Theory.Controllers
{
    public class NvmproductController : Controller
    {
        public IActionResult Nvmindex()
        {
            ViewBag.name = "Nguyễn Văn Mỹ";
            ViewData["productVd"] = "Lenovo IdeaPad";
            TempData["Uni"] = "NTU";
            return View();
        }

        public IActionResult GetProduct()
        {
            NvmProduct nvmProduct = new NvmProduct()
            {
                ProductId = "01",
                ProductName = "Nguyễn Văn Mỹ",
                YearRelease = 01/01/0001,
                ProductGia = 10000
            };
            ViewBag.product = nvmProduct;
            ViewData["dataproduct"] = nvmProduct;
            return View("product");
        }
    }
}

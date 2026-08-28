using Microsoft.AspNetCore.Mvc;
using Nvm_Lesson03.Models;

namespace Nvm_Lesson03.Controllers
{
    public class NvmProductController : Controller
    {
        public IActionResult NvmIndex()
        {
            return Json(product);
        }

        private readonly List<Nvmproducts> product = new()
        {
            new Nvmproducts() { PId = "1",  PName = "Laptop Gaming ASUS ROG",  PDate = new DateOnly(2024, 01, 01), PPrice = 28500000 },
            new Nvmproducts() { PId = "2",  PName = "Bàn phím cơ AKKO 3087",   PDate = new DateOnly(2023, 05, 15), PPrice = 1450000  },
            new Nvmproducts() { PId = "3",  PName = "Chuột Logitech G502 Hero", PDate = new DateOnly(2022, 11, 20), PPrice = 990000   },
            new Nvmproducts() { PId = "4",  PName = "Màn hình Dell UltraSharp", PDate = new DateOnly(2024, 03, 10), PPrice = 8200000  },
            new Nvmproducts() { PId = "5",  PName = "Tai nghe Sony WH-1000XM5", PDate = new DateOnly(2023, 08, 25), PPrice = 6900000  },
            new Nvmproducts() { PId = "6",  PName = "MacBook Air M3",          PDate = new DateOnly(2024, 04, 12), PPrice = 27900000 },
            new Nvmproducts() { PId = "7",  PName = "Loa Bluetooth JBL Flip 6", PDate = new DateOnly(2022, 09, 05), PPrice = 2100000  },
            new Nvmproducts() { PId = "8",  PName = "Webcam Logitech C922 Pro", PDate = new DateOnly(2021, 12, 18), PPrice = 1850000  },
            new Nvmproducts() { PId = "9",  PName = "Ổ cứng di động SSD 1TB",   PDate = new DateOnly(2023, 07, 30), PPrice = 2350000  },
            new Nvmproducts() { PId = "10", PName = "Ghế công thái học Sihoo", PDate = new DateOnly(2024, 02, 14), PPrice = 4200000  }
        };
        
        public IActionResult GetAllProduct()
        {
            ViewData["Product"] = product;
            return View();
        }
        public IActionResult GetListProduct()
        {
            return View(product);
        }
    }
}

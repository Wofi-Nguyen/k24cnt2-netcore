using Microsoft.AspNetCore.Mvc;

namespace Nvm_Lesson06.ViewComponents
{
    public class CategoryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(int? n)
        {
            var categories = new List<Models.NvmCategory>
            {
                new Models.NvmCategory { Id = 1, Name = "A"},
                new Models.NvmCategory { Id = 2, Name = "B"},
                new Models.NvmCategory { Id = 3, Name = "C"},
                new Models.NvmCategory { Id = 4, Name = "D"}
            };

            n= n ?? 0;
            var search = categories.Where(c => c.Id > n).ToList();
            return View(search);
        }
    }
}

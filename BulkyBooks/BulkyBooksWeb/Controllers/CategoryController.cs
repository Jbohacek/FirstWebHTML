using BulkyBooksWeb.Data;
using BulkyBooksWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBooksWeb.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ApplicationdbContext _db;

        public CategoryController(ApplicationdbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }
    }
}

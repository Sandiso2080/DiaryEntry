using DiaryEntry.Data;
using DiaryEntry.Models;
using Microsoft.AspNetCore.Mvc;

namespace DiaryEntry.Controllers
{
    public class DiaryModelController : Controller
    {
        private readonly AppDbContext _db;
        public DiaryModelController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<DiaryModel> entries = _db.DiaryEntries.ToList();
            return View(entries);
        }
    }
}

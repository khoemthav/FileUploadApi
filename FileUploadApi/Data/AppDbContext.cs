using Microsoft.AspNetCore.Mvc;

namespace FileUploadApi.Data
{
    public class AppDbContext : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

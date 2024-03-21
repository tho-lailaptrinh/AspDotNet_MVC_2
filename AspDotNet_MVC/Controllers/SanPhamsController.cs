using Microsoft.AspNetCore.Mvc;
using AspDotNet_MVC.Repositorys;
using AspDotNet_MVC.Models.Data;
using AspDotNet_MVC.Models.Entitis;

namespace AspDotNet_MVC.Controllers
{
    public class SanPhamsController : Controller
    {
        private readonly SanPhamRepo _repo;
        public SanPhamsController(SanPhamRepo repo)
        {
            _repo = repo;
        }

        // GET: SanPhams
        public async Task<IActionResult> Index()
        {
            var data = await _repo.GetSanPhams();
            return View(data);
        }
        public IActionResult Create()
        {

            return View();
        }
        public IActionResult CreateSP(SanPham sp)
        {
            var data = _repo.CreateSP(sp);
            return RedirectToAction("Index");
        }

    }
}

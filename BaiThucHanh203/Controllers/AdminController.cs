using Microsoft.AspNetCore.Mvc;
using BaiThucHanh203.Data;
using BaiThucHanh203.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh203.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AdminController (ApplicationDbContext context)
        {
        _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _context.Admin.ToListAsync();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        } 

        [HttpPost]

        public async Task<IActionResult> Create(Admin std)
        {
            if(ModelState.IsValid)
            {   
                _context.Add(std);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof (Index));
            }
            return View(std);
        }


    }
}
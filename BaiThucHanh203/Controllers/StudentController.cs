using Microsoft.AspNetCore.Mvc;
using BaiThucHanh203.Data;
using BaiThucHanh203.Models;
using Microsoft.EntityFrameworkCore;

namespace BaiThucHanh203.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentController (ApplicationDbContext context)
        {
        _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _context.Student.ToListAsync();
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        } 

        [HttpPost]

        public async Task<IActionResult> Create(Student std)
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
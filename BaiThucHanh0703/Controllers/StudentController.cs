using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;

namespace BaiThucHanh0703.Controllers;

public class StudentController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
        [Httppost]

        public IActionResult Create(Student std)
        {
            string kq= std.StudentCode + "-" + std.FullName + "-" + std.Address ;
            return View();
            ViewBag.xyz = ketqua;
        }
    }
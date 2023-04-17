using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BaiThucHanh0703.Models;
using BaiThucHanh0703.Models.Process

namespace BaiThucHanh0703.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    //pham vi ten_Class ten_Goi = new ten_Class();
    GiaiPhuongTrinhB1 gpt = new GiaiPhuongTrinhB1();

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }
    public IActionResult GiaiPhuongTrinhB1()
    {
        return View();
    }
    [HttpPost
    ]
    public IActionResult GiaiPhuongTrinhB1(string HeSoA, string HeSoB)
    {
        return View();

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

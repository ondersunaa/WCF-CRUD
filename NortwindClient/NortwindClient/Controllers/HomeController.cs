using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NortwindClient.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NorthwindService;


namespace NortwindClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INorthwindService _client;
        public HomeController(ILogger<HomeController> logger, INorthwindService client)
        {
            _logger = logger;
            _client = client;
        }

        public async  Task<IActionResult> Index()
        {
            List<Models.Employee> ab = new List<Models.Employee>();
            var a = await _client.GetAllEmployeesAsync();
            await _client.DeleteEmployeeAsync(1);
            return View(a);
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _client.DeleteEmployeeAsync(id);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ViewEmployee(int id)
        {
            
            
            return View(await _client.GetEmployeeByIdAsync(id));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {


            return View(await _client.GetEmployeeByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NorthwindService.Employee model)
        {
            await _client.UpdateEmployeeAsync(model);
            ViewBag.mesaj = "Güncelleme Başarılı";
            return View(await _client.GetEmployeeByIdAsync(model.EmployeeId));
        }

        [HttpGet]
        public async Task<IActionResult> Insert()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Insert(NorthwindService.Employee model)
        {
            await _client.InsertEmployeeAsync(model);
            ViewBag.mesaj = "Ekleme Başarılı";
            return RedirectToAction("Index");
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
}

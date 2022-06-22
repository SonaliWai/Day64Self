using Day64Self.Data.Services;
using Day64Self.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Day64Self.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly IDepartmentsService _departmentsService;

        public DepartmentsController(IDepartmentsService departmentsService)
        {
            _departmentsService = departmentsService;
        }
        public async Task<IActionResult> Index()
        {
            var departments = await _departmentsService.GetAllAsync();
            return View(departments);

        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
                return NotFound();

            var department = await _departmentsService.GetByIdAsync((int)id);

            if (department == null)
                return NotFound();

            return View(department);
        }


        public IActionResult Create()
        {
            return View();
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(DepartmentViewModel department)
        {
            if (ModelState.IsValid)
            {
                await _departmentsService.CreateAsync(department);
                return RedirectToAction(nameof(Index));
            }

            return View(department);
        }
    }
}

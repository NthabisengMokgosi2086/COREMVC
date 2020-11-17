using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COREMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace COREMVC.Controllers
{
    [Authorize]
    public class ManagerTablesController : Controller
    {
        private readonly DimeDataDBContext _context;

        public ManagerTablesController(DimeDataDBContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Manager")]
        // GET: ManagerTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.ManagerTable.ToListAsync());
        }

        [HttpGet]

        public async Task<IActionResult> Index(string search)
        {
            ViewData["GetAllEmployees"] = search;

            var query = from x in _context.ManagerTable select x;
            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(x => x.JobRole.Contains(search) || x.Department.Contains(search));
            }
            return View(await query.AsNoTracking().ToListAsync());
        }

        // GET: ManagerTables/Details/5
        public async Task<IActionResult> Details(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managerTable = await _context.ManagerTable
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (managerTable == null)
            {
                return NotFound();
            }

            return View(managerTable);
        }

        // GET: ManagerTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ManagerTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Attrition,DailyRate,Department,EmployeeCount,EmployeeNumber,HourlyRate,JobInvolvement,JobRole,MonthlyIncome,MonthlyRate,OverTime,PercentSalaryHike,PerformanceRating,StandardHours")] ManagerTable managerTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(managerTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(managerTable);
        }

        // GET: ManagerTables/Edit/5
        public async Task<IActionResult> Edit(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managerTable = await _context.ManagerTable.FindAsync(id);
            if (managerTable == null)
            {
                return NotFound();
            }
            return View(managerTable);
        }

        // POST: ManagerTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(double? id, [Bind("Attrition,DailyRate,Department,EmployeeCount,EmployeeNumber,HourlyRate,JobInvolvement,JobRole,MonthlyIncome,MonthlyRate,OverTime,PercentSalaryHike,PerformanceRating,StandardHours")] ManagerTable managerTable)
        {
            if (id != managerTable.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(managerTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManagerTableExists(managerTable.EmployeeNumber))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(managerTable);
        }

        // GET: ManagerTables/Delete/5
        public async Task<IActionResult> Delete(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var managerTable = await _context.ManagerTable
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (managerTable == null)
            {
                return NotFound();
            }

            return View(managerTable);
        }

        // POST: ManagerTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(double? id)
        {
            var managerTable = await _context.ManagerTable.FindAsync(id);
            _context.ManagerTable.Remove(managerTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManagerTableExists(double? id)
        {
            return _context.ManagerTable.Any(e => e.EmployeeNumber == id);
        }
    }
}

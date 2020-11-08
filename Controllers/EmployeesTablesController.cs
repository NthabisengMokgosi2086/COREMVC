using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COREMVC.Models;

namespace COREMVC.Controllers
{
    public class EmployeesTablesController : Controller
    {
        private readonly DimeDataDBContext _context;

        public EmployeesTablesController(DimeDataDBContext context)
        {
            _context = context;
        }

        // GET: EmployeesTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.EmployeesTable.ToListAsync());
        }

        // GET: EmployeesTables/Details/5
        public async Task<IActionResult> Details(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeesTable = await _context.EmployeesTable
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (employeesTable == null)
            {
                return NotFound();
            }

            return View(employeesTable);
        }

        // GET: EmployeesTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EmployeesTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,Department,EducationField,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,RelationshipSatisfaction,StandardHours,StockOptionLevel")] EmployeesTable employeesTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(employeesTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employeesTable);
        }

        // GET: EmployeesTables/Edit/5
        public async Task<IActionResult> Edit(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeesTable = await _context.EmployeesTable.FindAsync(id);
            if (employeesTable == null)
            {
                return NotFound();
            }
            return View(employeesTable);
        }

        // POST: EmployeesTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(double? id, [Bind("Age,Department,EducationField,EmployeeNumber,EnvironmentSatisfaction,Gender,HourlyRate,JobRole,JobSatisfaction,MaritalStatus,MonthlyIncome,RelationshipSatisfaction,StandardHours,StockOptionLevel")] EmployeesTable employeesTable)
        {
            if (id != employeesTable.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(employeesTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeesTableExists(employeesTable.EmployeeNumber))
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
            return View(employeesTable);
        }

        // GET: EmployeesTables/Delete/5
        public async Task<IActionResult> Delete(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employeesTable = await _context.EmployeesTable
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (employeesTable == null)
            {
                return NotFound();
            }

            return View(employeesTable);
        }

        // POST: EmployeesTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(double? id)
        {
            var employeesTable = await _context.EmployeesTable.FindAsync(id);
            _context.EmployeesTable.Remove(employeesTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeesTableExists(double? id)
        {
            return _context.EmployeesTable.Any(e => e.EmployeeNumber == id);
        }
    }
}

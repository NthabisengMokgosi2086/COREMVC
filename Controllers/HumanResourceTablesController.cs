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
    public class HumanResourceTablesController : Controller
    {
        private readonly DimeDataDBContext _context;

        public HumanResourceTablesController(DimeDataDBContext context)
        {
            _context = context;
        }

        // GET: HumanResourceTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.HumanResourceTable.ToListAsync());
        }

        // GET: HumanResourceTables/Details/5
        public async Task<IActionResult> Details(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var humanResourceTable = await _context.HumanResourceTable
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (humanResourceTable == null)
            {
                return NotFound();
            }

            return View(humanResourceTable);
        }

        // GET: HumanResourceTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: HumanResourceTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Age,BusinessTravel,Department,DistanceFromHome,EducationField,EmployeeNumber,Gender,JobRole,MaritalStatus,NumCompaniesWorked,OverTime,TotalWorkingYears,TrainingTimesLastYear,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] HumanResourceTable humanResourceTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(humanResourceTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(humanResourceTable);
        }

        // GET: HumanResourceTables/Edit/5
        public async Task<IActionResult> Edit(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var humanResourceTable = await _context.HumanResourceTable.FindAsync(id);
            if (humanResourceTable == null)
            {
                return NotFound();
            }
            return View(humanResourceTable);
        }

        // POST: HumanResourceTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(double? id, [Bind("Age,BusinessTravel,Department,DistanceFromHome,EducationField,EmployeeNumber,Gender,JobRole,MaritalStatus,NumCompaniesWorked,OverTime,TotalWorkingYears,TrainingTimesLastYear,YearsAtCompany,YearsInCurrentRole,YearsSinceLastPromotion,YearsWithCurrManager")] HumanResourceTable humanResourceTable)
        {
            if (id != humanResourceTable.EmployeeNumber)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(humanResourceTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HumanResourceTableExists(humanResourceTable.EmployeeNumber))
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
            return View(humanResourceTable);
        }

        // GET: HumanResourceTables/Delete/5
        public async Task<IActionResult> Delete(double? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var humanResourceTable = await _context.HumanResourceTable
                .FirstOrDefaultAsync(m => m.EmployeeNumber == id);
            if (humanResourceTable == null)
            {
                return NotFound();
            }

            return View(humanResourceTable);
        }

        // POST: HumanResourceTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(double? id)
        {
            var humanResourceTable = await _context.HumanResourceTable.FindAsync(id);
            _context.HumanResourceTable.Remove(humanResourceTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HumanResourceTableExists(double? id)
        {
            return _context.HumanResourceTable.Any(e => e.EmployeeNumber == id);
        }
    }
}

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
    public class DepartmentTablesController : Controller
    {
        private readonly DimeDataDBContext _context;

        public DepartmentTablesController(DimeDataDBContext context)
        {
            _context = context;
        }

        // GET: DepartmentTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.DepartmentTable.ToListAsync());
        }

        // GET: DepartmentTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentTable = await _context.DepartmentTable
                .FirstOrDefaultAsync(m => m.id == id);
            if (departmentTable == null)
            {
                return NotFound();
            }

            return View(departmentTable);
        }

        // GET: DepartmentTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DepartmentTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,Department")] DepartmentTable departmentTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(departmentTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(departmentTable);
        }

        // GET: DepartmentTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentTable = await _context.DepartmentTable.FindAsync(id);
            if (departmentTable == null)
            {
                return NotFound();
            }
            return View(departmentTable);
        }

        // POST: DepartmentTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,Department")] DepartmentTable departmentTable)
        {
            if (id != departmentTable.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(departmentTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentTableExists(departmentTable.id))
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
            return View(departmentTable);
        }

        // GET: DepartmentTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var departmentTable = await _context.DepartmentTable
                .FirstOrDefaultAsync(m => m.id == id);
            if (departmentTable == null)
            {
                return NotFound();
            }

            return View(departmentTable);
        }

        // POST: DepartmentTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var departmentTable = await _context.DepartmentTable.FindAsync(id);
            _context.DepartmentTable.Remove(departmentTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartmentTableExists(int id)
        {
            return _context.DepartmentTable.Any(e => e.id == id);
        }
    }
}

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
    public class RolesTablesController : Controller
    {
        private readonly DimeDataDBContext _context;

        public RolesTablesController(DimeDataDBContext context)
        {
            _context = context;
        }

        // GET: RolesTables
        public async Task<IActionResult> Index()
        {
            return View(await _context.RolesTable.ToListAsync());
        }

        // GET: RolesTables/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rolesTable = await _context.RolesTable
                .FirstOrDefaultAsync(m => m.id == id);
            if (rolesTable == null)
            {
                return NotFound();
            }

            return View(rolesTable);
        }

        // GET: RolesTables/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: RolesTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,JobRoles")] RolesTable rolesTable)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rolesTable);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rolesTable);
        }

        // GET: RolesTables/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rolesTable = await _context.RolesTable.FindAsync(id);
            if (rolesTable == null)
            {
                return NotFound();
            }
            return View(rolesTable);
        }

        // POST: RolesTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,JobRoles")] RolesTable rolesTable)
        {
            if (id != rolesTable.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rolesTable);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RolesTableExists(rolesTable.id))
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
            return View(rolesTable);
        }

        // GET: RolesTables/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rolesTable = await _context.RolesTable
                .FirstOrDefaultAsync(m => m.id == id);
            if (rolesTable == null)
            {
                return NotFound();
            }

            return View(rolesTable);
        }

        // POST: RolesTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rolesTable = await _context.RolesTable.FindAsync(id);
            _context.RolesTable.Remove(rolesTable);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RolesTableExists(int id)
        {
            return _context.RolesTable.Any(e => e.id == id);
        }
    }
}

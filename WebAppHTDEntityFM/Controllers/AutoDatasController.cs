using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebAppHTDEntityFM.Models;

namespace WebAppHTDEntityFM.Controllers
{
    public class AutoDatasController : Controller
    {
        private readonly DataBasedbContext _context;

        public AutoDatasController(DataBasedbContext context)
        {
            _context = context;
        }

        // GET: AutoDatas
        public async Task<IActionResult> Index()
        {
              return _context.AutoData != null ? 
                          View(await _context.AutoData.ToListAsync()) :
                          Problem("Entity set 'DataBasedbContext.AutoData'  is null.");
        }

        // GET: AutoDatas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AutoData == null)
            {
                return NotFound();
            }

            var autoData = await _context.AutoData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autoData == null)
            {
                return NotFound();
            }

            return View(autoData);
        }

        // GET: AutoDatas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AutoDatas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Address")] AutoData autoData)
        {
            if (ModelState.IsValid)
            {
                _context.Add(autoData);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(autoData);
        }

        // GET: AutoDatas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AutoData == null)
            {
                return NotFound();
            }

            var autoData = await _context.AutoData.FindAsync(id);
            if (autoData == null)
            {
                return NotFound();
            }
            return View(autoData);
        }

        // POST: AutoDatas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Address")] AutoData autoData)
        {
            if (id != autoData.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(autoData);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AutoDataExists(autoData.Id))
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
            return View(autoData);
        }

        // GET: AutoDatas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AutoData == null)
            {
                return NotFound();
            }

            var autoData = await _context.AutoData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (autoData == null)
            {
                return NotFound();
            }

            return View(autoData);
        }

        // POST: AutoDatas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AutoData == null)
            {
                return Problem("Entity set 'DataBasedbContext.AutoData'  is null.");
            }
            var autoData = await _context.AutoData.FindAsync(id);
            if (autoData != null)
            {
                _context.AutoData.Remove(autoData);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AutoDataExists(int id)
        {
          return (_context.AutoData?.Any(e => e.Id == id)).GetValueOrDefault();
        }
  

    }
}

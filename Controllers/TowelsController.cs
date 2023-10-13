using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TowelHarbor.Data;
using TowelHarbor.Models;

namespace TowelHarbor.Controllers
{
    public class TowelsController : Controller
    {
        private readonly TowelHarborContext _context;

        public TowelsController(TowelHarborContext context)
        {
            _context = context;
        }

        // GET: Towels
        public async Task<IActionResult> Index(string towelMaterial, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> materialQuery = from t in _context.Towels
                                            orderby t.Material
                                            select t.Material;

            /*Updating method to use the search functionality*/
            var towels = from t in _context.Towels
                         select t;

            if (!String.IsNullOrEmpty(searchString))
            {
                towels = towels.Where(s => s.Type.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(towelMaterial))
            {
                towels = towels.Where(x => x.Material == towelMaterial);
            }

            var towelMaterialVM = new TowelMeterialViewModel
            {
                Materials = new SelectList(await materialQuery.Distinct().ToListAsync()),
                Towels = await towels.ToListAsync()
            };

            return View(towelMaterialVM);
        }

        // GET: Towels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var towels = await _context.Towels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (towels == null)
            {
                return NotFound();
            }

            return View(towels);
        }

        // GET: Towels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Towels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Type,Material,Stock,Price,Description,Rating")] Towels towels)
        {
            if (ModelState.IsValid)
            {
                _context.Add(towels);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(towels);
        }

        // GET: Towels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var towels = await _context.Towels.FindAsync(id);
            if (towels == null)
            {
                return NotFound();
            }
            return View(towels);
        }

        // POST: Towels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Type,Material,Stock,Price,Description,Rating")] Towels towels)
        {
            if (id != towels.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(towels);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TowelsExists(towels.Id))
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
            return View(towels);
        }

        // GET: Towels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var towels = await _context.Towels
                .FirstOrDefaultAsync(m => m.Id == id);
            if (towels == null)
            {
                return NotFound();
            }

            return View(towels);
        }

        // POST: Towels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var towels = await _context.Towels.FindAsync(id);
            _context.Towels.Remove(towels);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TowelsExists(int id)
        {
            return _context.Towels.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TitanInformationSolutions.Data;
using TitanInformationSolutions.Models;

namespace TitanInformationSolutions.Controllers
{
    public class BGCProgramsController : Controller
    {
        private readonly TitanInformationSolutionsContext _context;

        public BGCProgramsController(TitanInformationSolutionsContext context)
        {
            _context = context;
        }

        // GET: BGCPrograms
        public async Task<IActionResult> Index()
        {
            return View(await _context.BGCProgram.ToListAsync());
        }

        // GET: BGCPrograms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bGCProgram = await _context.BGCProgram
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bGCProgram == null)
            {
                return NotFound();
            }

            return View(bGCProgram);
        }

        // GET: BGCPrograms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BGCPrograms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name")] BGCProgram bGCProgram)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bGCProgram);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bGCProgram);
        }

        // GET: BGCPrograms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bGCProgram = await _context.BGCProgram.FindAsync(id);
            if (bGCProgram == null)
            {
                return NotFound();
            }
            return View(bGCProgram);
        }

        // POST: BGCPrograms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name")] BGCProgram bGCProgram)
        {
            if (id != bGCProgram.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bGCProgram);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BGCProgramExists(bGCProgram.ID))
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
            return View(bGCProgram);
        }

        // GET: BGCPrograms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bGCProgram = await _context.BGCProgram
                .FirstOrDefaultAsync(m => m.ID == id);
            if (bGCProgram == null)
            {
                return NotFound();
            }

            return View(bGCProgram);
        }

        // POST: BGCPrograms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bGCProgram = await _context.BGCProgram.FindAsync(id);
            _context.BGCProgram.Remove(bGCProgram);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BGCProgramExists(int id)
        {
            return _context.BGCProgram.Any(e => e.ID == id);
        }
    }
}

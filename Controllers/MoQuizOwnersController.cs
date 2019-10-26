using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoustacheApp.Data;
using MoustacheApp.Models;

namespace MoustacheApp.Controllers
{
    public class MoQuizOwnersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoQuizOwnersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MoQuizOwners
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MoQuizOwner.Include(m => m.Quiz);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MoQuizOwners/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuizOwner = await _context.MoQuizOwner
                .Include(m => m.Quiz)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moQuizOwner == null)
            {
                return NotFound();
            }

            return View(moQuizOwner);
        }

        // GET: MoQuizOwners/Create
        public IActionResult Create()
        {
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id");
            return View();
        }

        // POST: MoQuizOwners/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuizId,UserId,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoQuizOwner moQuizOwner)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moQuizOwner);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuizOwner.QuizId);
            return View(moQuizOwner);
        }

        // GET: MoQuizOwners/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuizOwner = await _context.MoQuizOwner.FindAsync(id);
            if (moQuizOwner == null)
            {
                return NotFound();
            }
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuizOwner.QuizId);
            return View(moQuizOwner);
        }

        // POST: MoQuizOwners/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,QuizId,UserId,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoQuizOwner moQuizOwner)
        {
            if (id != moQuizOwner.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moQuizOwner);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoQuizOwnerExists(moQuizOwner.Id))
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
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuizOwner.QuizId);
            return View(moQuizOwner);
        }

        // GET: MoQuizOwners/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuizOwner = await _context.MoQuizOwner
                .Include(m => m.Quiz)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moQuizOwner == null)
            {
                return NotFound();
            }

            return View(moQuizOwner);
        }

        // POST: MoQuizOwners/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var moQuizOwner = await _context.MoQuizOwner.FindAsync(id);
            _context.MoQuizOwner.Remove(moQuizOwner);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoQuizOwnerExists(string id)
        {
            return _context.MoQuizOwner.Any(e => e.Id == id);
        }
    }
}

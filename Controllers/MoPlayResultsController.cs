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
    public class MoPlayResultsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoPlayResultsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MoPlayResults
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MoPlayResult.Include(m => m.Quiz);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MoPlayResults/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moPlayResult = await _context.MoPlayResult
                .Include(m => m.Quiz)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moPlayResult == null)
            {
                return NotFound();
            }

            return View(moPlayResult);
        }

        // GET: MoPlayResults/Create
        public IActionResult Create()
        {
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id");
            return View();
        }

        // POST: MoPlayResults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuizId,PlayedDt,SubmittedDt,Attempt,QuestCount,Result,ResultAdjusted,Feedback,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoPlayResult moPlayResult)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moPlayResult);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moPlayResult.QuizId);
            return View(moPlayResult);
        }

        // GET: MoPlayResults/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moPlayResult = await _context.MoPlayResult.FindAsync(id);
            if (moPlayResult == null)
            {
                return NotFound();
            }
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moPlayResult.QuizId);
            return View(moPlayResult);
        }

        // POST: MoPlayResults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,QuizId,PlayedDt,SubmittedDt,Attempt,QuestCount,Result,ResultAdjusted,Feedback,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoPlayResult moPlayResult)
        {
            if (id != moPlayResult.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moPlayResult);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoPlayResultExists(moPlayResult.Id))
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
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moPlayResult.QuizId);
            return View(moPlayResult);
        }

        // GET: MoPlayResults/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moPlayResult = await _context.MoPlayResult
                .Include(m => m.Quiz)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moPlayResult == null)
            {
                return NotFound();
            }

            return View(moPlayResult);
        }

        // POST: MoPlayResults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var moPlayResult = await _context.MoPlayResult.FindAsync(id);
            _context.MoPlayResult.Remove(moPlayResult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoPlayResultExists(string id)
        {
            return _context.MoPlayResult.Any(e => e.Id == id);
        }
    }
}

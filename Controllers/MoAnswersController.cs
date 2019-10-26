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
    public class MoAnswersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoAnswersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MoAnswers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MoAnswer.Include(m => m.Question);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MoAnswers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moAnswer = await _context.MoAnswer
                .Include(m => m.Question)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moAnswer == null)
            {
                return NotFound();
            }

            return View(moAnswer);
        }

        // GET: MoAnswers/Create
        public IActionResult Create()
        {
            ViewData["QuestionId"] = new SelectList(_context.MoQuestion, "Id", "Id");
            return View();
        }

        // POST: MoAnswers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuestionId,Answer,Correct,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoAnswer moAnswer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moAnswer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuestionId"] = new SelectList(_context.MoQuestion, "Id", "Id", moAnswer.QuestionId);
            return View(moAnswer);
        }

        // GET: MoAnswers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moAnswer = await _context.MoAnswer.FindAsync(id);
            if (moAnswer == null)
            {
                return NotFound();
            }
            ViewData["QuestionId"] = new SelectList(_context.MoQuestion, "Id", "Id", moAnswer.QuestionId);
            return View(moAnswer);
        }

        // POST: MoAnswers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,QuestionId,Answer,Correct,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoAnswer moAnswer)
        {
            if (id != moAnswer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moAnswer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoAnswerExists(moAnswer.Id))
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
            ViewData["QuestionId"] = new SelectList(_context.MoQuestion, "Id", "Id", moAnswer.QuestionId);
            return View(moAnswer);
        }

        // GET: MoAnswers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moAnswer = await _context.MoAnswer
                .Include(m => m.Question)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moAnswer == null)
            {
                return NotFound();
            }

            return View(moAnswer);
        }

        // POST: MoAnswers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var moAnswer = await _context.MoAnswer.FindAsync(id);
            _context.MoAnswer.Remove(moAnswer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoAnswerExists(string id)
        {
            return _context.MoAnswer.Any(e => e.Id == id);
        }
    }
}

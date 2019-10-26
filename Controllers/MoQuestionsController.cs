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
    public class MoQuestionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoQuestionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MoQuestions
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MoQuestion.Include(m => m.Quiz);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MoQuestions/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuestion = await _context.MoQuestion
                .Include(m => m.Quiz)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moQuestion == null)
            {
                return NotFound();
            }

            return View(moQuestion);
        }

        // GET: MoQuestions/Create
        public IActionResult Create()
        {
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id");
            return View();
        }

        // POST: MoQuestions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuizId,Question,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoQuestion moQuestion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moQuestion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuestion.QuizId);
            return View(moQuestion);
        }

        // GET: MoQuestions/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuestion = await _context.MoQuestion.FindAsync(id);
            if (moQuestion == null)
            {
                return NotFound();
            }
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuestion.QuizId);
            return View(moQuestion);
        }

        // POST: MoQuestions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,QuizId,Question,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoQuestion moQuestion)
        {
            if (id != moQuestion.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moQuestion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoQuestionExists(moQuestion.Id))
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
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuestion.QuizId);
            return View(moQuestion);
        }

        // GET: MoQuestions/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuestion = await _context.MoQuestion
                .Include(m => m.Quiz)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moQuestion == null)
            {
                return NotFound();
            }

            return View(moQuestion);
        }

        // POST: MoQuestions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var moQuestion = await _context.MoQuestion.FindAsync(id);
            _context.MoQuestion.Remove(moQuestion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoQuestionExists(string id)
        {
            return _context.MoQuestion.Any(e => e.Id == id);
        }
    }
}

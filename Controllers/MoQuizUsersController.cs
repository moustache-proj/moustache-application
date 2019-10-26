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
    public class MoQuizUsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MoQuizUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MoQuizUsers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MoQuizUser.Include(m => m.Quiz);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MoQuizUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuizUser = await _context.MoQuizUser
                .Include(m => m.Quiz)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moQuizUser == null)
            {
                return NotFound();
            }

            return View(moQuizUser);
        }

        // GET: MoQuizUsers/Create
        public IActionResult Create()
        {
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id");
            return View();
        }

        // POST: MoQuizUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,QuizId,UserId,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoQuizUser moQuizUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moQuizUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuizUser.QuizId);
            return View(moQuizUser);
        }

        // GET: MoQuizUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuizUser = await _context.MoQuizUser.FindAsync(id);
            if (moQuizUser == null)
            {
                return NotFound();
            }
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuizUser.QuizId);
            return View(moQuizUser);
        }

        // POST: MoQuizUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,QuizId,UserId,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoQuizUser moQuizUser)
        {
            if (id != moQuizUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moQuizUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoQuizUserExists(moQuizUser.Id))
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
            ViewData["QuizId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuizUser.QuizId);
            return View(moQuizUser);
        }

        // GET: MoQuizUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuizUser = await _context.MoQuizUser
                .Include(m => m.Quiz)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moQuizUser == null)
            {
                return NotFound();
            }

            return View(moQuizUser);
        }

        // POST: MoQuizUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var moQuizUser = await _context.MoQuizUser.FindAsync(id);
            _context.MoQuizUser.Remove(moQuizUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoQuizUserExists(string id)
        {
            return _context.MoQuizUser.Any(e => e.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MoustacheApp.Data;
using MoustacheApp.Models;

namespace MoustacheApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: MoQuizDetails
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.MoQuizDetail.Include(m => m.Previous);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: MoQuizDetails/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuizDetail = await _context.MoQuizDetail
                .Include(m => m.Previous)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moQuizDetail == null)
            {
                return NotFound();
            }

            return View(moQuizDetail);
        }

        // GET: MoQuizDetails/Create
        public IActionResult Create()
        {
            ViewData["PreviousId"] = new SelectList(_context.MoQuizDetail, "Id", "Id");
            return View();
        }

        // POST: MoQuizDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PreviousId,Current,CommonId,Name,Information,Type,Published,Attempts,Played,Randomise,QuestToPlay,QuizStart,TimeLimit,ResultLocked,LockedUntil,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoQuizDetail moQuizDetail)
        {
            if (ModelState.IsValid)
            {
                _context.Add(moQuizDetail);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PreviousId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuizDetail.PreviousId);
            return View(moQuizDetail);
        }

        // GET: MoQuizDetails/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuizDetail = await _context.MoQuizDetail.FindAsync(id);
            if (moQuizDetail == null)
            {
                return NotFound();
            }
            ViewData["PreviousId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuizDetail.PreviousId);
            return View(moQuizDetail);
        }

        // POST: MoQuizDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Id,PreviousId,Current,CommonId,Name,Information,Type,Published,Attempts,Played,Randomise,QuestToPlay,QuizStart,TimeLimit,ResultLocked,LockedUntil,CreatedBy,CreatedDate,ModifiedBy,ModifiedDate")] MoQuizDetail moQuizDetail)
        {
            if (id != moQuizDetail.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(moQuizDetail);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MoQuizDetailExists(moQuizDetail.Id))
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
            ViewData["PreviousId"] = new SelectList(_context.MoQuizDetail, "Id", "Id", moQuizDetail.PreviousId);
            return View(moQuizDetail);
        }

        // GET: MoQuizDetails/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var moQuizDetail = await _context.MoQuizDetail
                .Include(m => m.Previous)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (moQuizDetail == null)
            {
                return NotFound();
            }

            return View(moQuizDetail);
        }

        // POST: MoQuizDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var moQuizDetail = await _context.MoQuizDetail.FindAsync(id);
            _context.MoQuizDetail.Remove(moQuizDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MoQuizDetailExists(string id)
        {
            return _context.MoQuizDetail.Any(e => e.Id == id);
        }
    }
}

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
    public class AppUsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AppUsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: AppUsers
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Users.Include(a => a.UserId);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AppUsers/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.Users
                .Include(a => a.UserId)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }

        // GET: AppUsers/Create
        public IActionResult Create()
        {
            ViewData["DisabledBy"] = new SelectList(_context.Users, "Id", "Id");
            return View();
        }

        // POST: AppUsers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AltName,Anonymous,Disabled,DisableDate,DisabledBy,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUser appUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(appUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DisabledBy"] = new SelectList(_context.Users, "Id", "Id", appUser.DisabledBy);
            return View(appUser);
        }

        // GET: AppUsers/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.Users.FindAsync(id);
            if (appUser == null)
            {
                return NotFound();
            }
            ViewData["DisabledBy"] = new SelectList(_context.Users, "Id", "Id", appUser.DisabledBy);
            return View(appUser);
        }

        // POST: AppUsers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("AltName,Anonymous,Disabled,DisableDate,DisabledBy,Id,UserName,NormalizedUserName,Email,NormalizedEmail,EmailConfirmed,PasswordHash,SecurityStamp,ConcurrencyStamp,PhoneNumber,PhoneNumberConfirmed,TwoFactorEnabled,LockoutEnd,LockoutEnabled,AccessFailedCount")] AppUser appUser)
        {
            if (id != appUser.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(appUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AppUserExists(appUser.Id))
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
            ViewData["DisabledBy"] = new SelectList(_context.Users, "Id", "Id", appUser.DisabledBy);
            return View(appUser);
        }

        // GET: AppUsers/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var appUser = await _context.Users
                .Include(a => a.UserId)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (appUser == null)
            {
                return NotFound();
            }

            return View(appUser);
        }

        // POST: AppUsers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var appUser = await _context.Users.FindAsync(id);
            _context.Users.Remove(appUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AppUserExists(string id)
        {
            return _context.Users.Any(e => e.Id == id);
        }
    }
}

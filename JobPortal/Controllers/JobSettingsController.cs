using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using JobPortal.Models;

namespace JobPortal.Controllers
{
    public class JobSettingsController : Controller
    {
        private readonly JobPortalDbContext _context;

        public JobSettingsController(JobPortalDbContext context)
        {
            _context = context;
        }

        // GET: JobSettings
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobSettingses.ToListAsync());
        }

        // GET: JobSettings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSettings = await _context.JobSettingses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobSettings == null)
            {
                return NotFound();
            }

            return View(jobSettings);
        }

        // GET: JobSettings/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobSettings/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,JobId,JobTitle,Company,vacancy,TopSkills,MinorSkills")] JobSettings jobSettings)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobSettings);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobSettings);
        }

        // GET: JobSettings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSettings = await _context.JobSettingses.FindAsync(id);
            if (jobSettings == null)
            {
                return NotFound();
            }
            return View(jobSettings);
        }

        // POST: JobSettings/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,JobId,JobTitle,Company,vacancy,TopSkills,MinorSkills")] JobSettings jobSettings)
        {
            if (id != jobSettings.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobSettings);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobSettingsExists(jobSettings.Id))
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
            return View(jobSettings);
        }

        // GET: JobSettings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobSettings = await _context.JobSettingses
                .FirstOrDefaultAsync(m => m.Id == id);
            if (jobSettings == null)
            {
                return NotFound();
            }

            return View(jobSettings);
        }

        // POST: JobSettings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobSettings = await _context.JobSettingses.FindAsync(id);
            _context.JobSettingses.Remove(jobSettings);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobSettingsExists(int id)
        {
            return _context.JobSettingses.Any(e => e.Id == id);
        }
    }
}

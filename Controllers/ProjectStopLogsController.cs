using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvc_energy_plants.Models;

namespace mvc_energy_plants.Controllers
{
    public class ProjectStopLogsController : Controller
    {
        private readonly energy_plantsContext _context;

        public ProjectStopLogsController(energy_plantsContext context)
        {
            _context = context;
        }

        // GET: ProjectStopLogs
        public async Task<IActionResult> Index()
        {
            return _context.ProjectStopLog != null ?
                        View(await _context.ProjectStopLog.ToListAsync()) :
                        Problem("Entity set 'energy_plantsContext.ProjectStopLog'  is null.");
        }

        // GET: ProjectStopLogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProjectStopLog == null)
            {
                return NotFound();
            }

            var projectStopLog = await _context.ProjectStopLog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectStopLog == null)
            {
                return NotFound();
            }

            return View(projectStopLog);
        }

        // GET: ProjectStopLogs/Create
        public IActionResult Create(int projectId)
        {
            this.ViewData["projectId"] = projectId;
            return View();
        }

        // POST: ProjectStopLogs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProjectId,StopDate,Classification,Cause,Action")] ProjectStopLog projectStopLog)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectStopLog);
                await _context.SaveChangesAsync();
                return RedirectToAction("Details", "Projects", new { id = projectStopLog.ProjectId });
            }
            return View(projectStopLog);
        }

        // GET: ProjectStopLogs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProjectStopLog == null)
            {
                return NotFound();
            }

            var projectStopLog = await _context.ProjectStopLog.FindAsync(id);
            if (projectStopLog == null)
            {
                return NotFound();
            }
            return View(projectStopLog);
        }

        // POST: ProjectStopLogs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProjectId,StopDate,Classification,Cause,Action")] ProjectStopLog projectStopLog)
        {
            if (id != projectStopLog.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectStopLog);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectStopLogExists(projectStopLog.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Projects", new { id = projectStopLog.ProjectId });
            }
            return View(projectStopLog);
        }

        // GET: ProjectStopLogs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProjectStopLog == null)
            {
                return NotFound();
            }

            var projectStopLog = await _context.ProjectStopLog
                .FirstOrDefaultAsync(m => m.Id == id);
            if (projectStopLog == null)
            {
                return NotFound();
            }

            return View(projectStopLog);
        }

        // POST: ProjectStopLogs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProjectStopLog == null)
            {
                return Problem("Entity set 'energy_plantsContext.ProjectStopLog'  is null.");
            }
            var projectStopLog = await _context.ProjectStopLog.FindAsync(id);
            if (projectStopLog != null)
            {
                _context.ProjectStopLog.Remove(projectStopLog);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Projects", new { id = projectStopLog.ProjectId });
        }

        private bool ProjectStopLogExists(int id)
        {
            return (_context.ProjectStopLog?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}

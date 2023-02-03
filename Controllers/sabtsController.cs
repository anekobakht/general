using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using general.Data;
using general.Models;
using System.Diagnostics;

namespace general.Controllers
{
    public class sabtsController : Controller
    {
        private readonly generalContext _context;

        public sabtsController(generalContext context)
        {
            _context = context;
        }

        // GET: sabts
        public async Task<IActionResult> Index()
        {
              return View();
        }

        public async Task<IActionResult> login()
        {
            return View();
        }

        public async Task<IActionResult>  shafa()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo('\\' + "\\172.16.2.8\\shafa8.5Complete\\Shafa85.exe");
            startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            Process.Start(startInfo);
             return RedirectToAction("Index","sabts");
        }

        // GET: sabts/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.sabt == null)
            {
                return NotFound();
            }

            var sabt = await _context.sabt
                .FirstOrDefaultAsync(m => m.id == id);
            if (sabt == null)
            {
                return NotFound();
            }

            return View(sabt);
        }

        // GET: sabts/Create
        public IActionResult Create()
        {
            TempData["sabt"] = 0;
            return View();
        }

        // POST: sabts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,fname,lname,meli,phone,matn")] sabt sabt)
        {
            if (ModelState.IsValid)
            {
                _context.Add(sabt);
                await _context.SaveChangesAsync();
                TempData["sabt"] = 1;
                return View();
            }
            return View(sabt);
        }

        // GET: sabts/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.sabt == null)
            {
                return NotFound();
            }

            var sabt = await _context.sabt.FindAsync(id);
            if (sabt == null)
            {
                return NotFound();
            }
            return View(sabt);
        }

        // POST: sabts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("id,fname,lname,meli,phone,matn")] sabt sabt)
        {
            if (id != sabt.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sabt);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!sabtExists(sabt.id))
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
            return View(sabt);
        }

        // GET: sabts/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.sabt == null)
            {
                return NotFound();
            }

            var sabt = await _context.sabt
                .FirstOrDefaultAsync(m => m.id == id);
            if (sabt == null)
            {
                return NotFound();
            }

            return View(sabt);
        }

        // POST: sabts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.sabt == null)
            {
                return Problem("Entity set 'generalContext.sabt'  is null.");
            }
            var sabt = await _context.sabt.FindAsync(id);
            if (sabt != null)
            {
                _context.sabt.Remove(sabt);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool sabtExists(long id)
        {
          return _context.sabt.Any(e => e.id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestingApp.Data;
using TestingApp.Models;

namespace TestingApp.Controllers
{
    public class TestController : Controller
    {
        private readonly TestAppContext _context;

        public TestController(TestAppContext context)
        {
            _context = context;
        }

        // GET: Test
        [Authorize]
        public async Task<IActionResult> Index()
        {
            return View(await _context.TestAppRecords.ToListAsync());
        }

        // GET: Test/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testAppRecord = await _context.TestAppRecords
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testAppRecord == null)
            {
                return NotFound();
            }

            return View(testAppRecord);
        }

        // GET: Test/Create
        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Test/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind("Id,Issue_Number,Client_Name,Issue_Type,Assigned_Developer,Assigned_Tester,Cycle_Count,Date_Per_Cycle_Count,Release_Date,Status")] TestAppRecord testAppRecord)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testAppRecord);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testAppRecord);
        }

        // GET: Test/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testAppRecord = await _context.TestAppRecords.FindAsync(id);
            if (testAppRecord == null)
            {
                return NotFound();
            }
            return View(testAppRecord);
        }

        // POST: Test/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Issue_Number,Client_Name,Issue_Type,Assigned_Developer,Assigned_Tester,Cycle_Count,Date_Per_Cycle_Count,Release_Date,Status")] TestAppRecord testAppRecord)
        {
            if (id != testAppRecord.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testAppRecord);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestAppRecordExists(testAppRecord.Id))
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
            return View(testAppRecord);
        }

        // GET: Test/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testAppRecord = await _context.TestAppRecords
                .FirstOrDefaultAsync(m => m.Id == id);
            if (testAppRecord == null)
            {
                return NotFound();
            }

            return View(testAppRecord);
        }

        // POST: Test/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testAppRecord = await _context.TestAppRecords.FindAsync(id);
            _context.TestAppRecords.Remove(testAppRecord);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestAppRecordExists(int id)
        {
            return _context.TestAppRecords.Any(e => e.Id == id);
        }
    }
}

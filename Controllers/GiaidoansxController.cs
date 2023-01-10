﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using QuanLySanXuat.Entities;

namespace QuanLySanXuat.Controllers
{
    [Authorize]
    public class GiaidoansxController : Controller
    {
        private readonly ProductionManagementSoftwareContext _context;

        public GiaidoansxController(ProductionManagementSoftwareContext context)
        {
            _context = context;
        }

        // GET: Tosanxuat
        public async Task<IActionResult> Index()
        {
            var productionManagementSoftwareContext = _context.Giaidoansx;
            return View(await productionManagementSoftwareContext.ToListAsync());
        }

        // GET: Tosanxuat/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gdsx = await _context.Giaidoansx

                .FirstOrDefaultAsync(m => m.Idgdsx == id);
            if (gdsx == null)
            {
                return NotFound();
            }

            return View(gdsx);
        }


        public IActionResult Create()
        {

            return View();
        }


        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Giaidoansx gdsx)
        {
            if (ModelState.IsValid)
            {
                _context.Add(gdsx);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(gdsx);
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gdsx = await _context.Giaidoansx.FindAsync(id);
            if (gdsx == null)
            {
                return NotFound();
            }

            return View(gdsx);
        }

      
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Giaidoansx gdsx)
        {
            if (id != gdsx.Idgdsx)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(gdsx);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GDsanxuatExists(gdsx.Idgdsx))
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

            return View(gdsx);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var gdsx = await _context.Giaidoansx

                .FirstOrDefaultAsync(m => m.Idgdsx == id);
            if (gdsx == null)
            {
                return NotFound();
            }

            return View(gdsx);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var gdsx = await _context.Giaidoansx.FindAsync(id);
            _context.Giaidoansx.Remove(gdsx);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GDsanxuatExists(int id)
        {
            return _context.Giaidoansx.Any(e => e.Idgdsx == id);
        }
    }
}
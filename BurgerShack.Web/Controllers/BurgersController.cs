using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BurgerShack.Entities;
using BurgerShack.Web.Models;
using BurgerShack.Business;

namespace BurgerShack.Web.Controllers
{
    public class BurgersController : Controller
    {
        private readonly BurgersService _burgersService;

        public BurgersController(BurgersService burgersService)
        {
            _burgersService = burgersService;
        }

        // GET: Burgers
        public IActionResult Index()
        {
            return View(_burgersService.GetAll());
        }

        // GET: Burgers/Details/5
        public IActionResult Details(int id)
        {

            var burger = _burgersService.GetById(id);
            if (burger == null)
            {
                return NotFound();
            }

            return View(burger);
        }

        // GET: Burgers/Create
        public IActionResult Create()
        {
            return View();
        }

           //POST: Burgers/Create
          // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
          // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
          [HttpPost]
          [ValidateAntiForgeryToken]
          public IActionResult Create(Burger burger)
          {
            if (ModelState.IsValid)
            {
              Burger b = _burgersService.Create(burger);
              return RedirectToAction(nameof(Index));
            }
            return View(burger);
            }
        
    //    // GET: Burgers/Edit/5
    //    public async Task<IActionResult> Edit(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var burger = await _context.Burger.SingleOrDefaultAsync(m => m.Id == id);
    //        if (burger == null)
    //        {
    //            return NotFound();
    //        }
    //        return View(burger);
    //    }

    //    // POST: Burgers/Edit/5
    //    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    //    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price")] Burger burger)
    //    {
    //        if (id != burger.Id)
    //        {
    //            return NotFound();
    //        }

    //        if (ModelState.IsValid)
    //        {
    //            try
    //            {
    //                _context.Update(burger);
    //                await _context.SaveChangesAsync();
    //            }
    //            catch (DbUpdateConcurrencyException)
    //            {
    //                if (!BurgerExists(burger.Id))
    //                {
    //                    return NotFound();
    //                }
    //                else
    //                {
    //                    throw;
    //                }
    //            }
    //            return RedirectToAction(nameof(Index));
    //        }
    //        return View(burger);
    //    }

    //    // GET: Burgers/Delete/5
    //    public async Task<IActionResult> Delete(int? id)
    //    {
    //        if (id == null)
    //        {
    //            return NotFound();
    //        }

    //        var burger = await _context.Burger
    //            .SingleOrDefaultAsync(m => m.Id == id);
    //        if (burger == null)
    //        {
    //            return NotFound();
    //        }

    //        return View(burger);
    //    }

    //    // POST: Burgers/Delete/5
    //    [HttpPost, ActionName("Delete")]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> DeleteConfirmed(int id)
    //    {
    //        var burger = await _context.Burger.SingleOrDefaultAsync(m => m.Id == id);
    //        _context.Burger.Remove(burger);
    //        await _context.SaveChangesAsync();
    //        return RedirectToAction(nameof(Index));
    //    }

    //    private bool BurgerExists(int id)
    //    {
    //        return _context.Burger.Any(e => e.Id == id);
    //    }
    }
}

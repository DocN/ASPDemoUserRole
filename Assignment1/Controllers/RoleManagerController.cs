using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Assignment1.Controllers
{
    public class RoleManagerController : Controller
    {
        private readonly Assignment1Context _context;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RoleManagerController(Assignment1Context context, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _roleManager = roleManager;
        }

        // GET: Cities
        public async Task<IActionResult> Index()
        {
            var roles = _roleManager.Roles;
            return View(await roles.ToListAsync());
        }

        // GET: Provinces/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var UserData = await _context.UserData
                .FirstOrDefaultAsync(m => m.Id == id);
            if (UserData == null)
            {
                return NotFound();
            }

            return View(UserData);
        }

        // GET: Provinces/Create
        public IActionResult Create()
        {
            return View();
        }
        // GET: Provinces/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var CurrentRole = await _roleManager.FindByIdAsync(id);
            if (CurrentRole == null)
            {
                return NotFound();
            }
            return View(CurrentRole);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var CurrentRole = await _roleManager.FindByIdAsync(id);
            await _roleManager.DeleteAsync(CurrentRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    
        // POST: Provinces/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name")] IdentityRole role)
        {
            if (ModelState.IsValid)
            {
                if (!await _roleManager.RoleExistsAsync(role.Name))
                {
                    await _roleManager.CreateAsync(new IdentityRole(role.Name));
                }
            }
            return RedirectToAction(nameof(Index));
        }


    }
}

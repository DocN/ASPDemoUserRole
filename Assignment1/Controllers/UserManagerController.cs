using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment1.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;


namespace Assignment1.Controllers
{
    public class UserManagerController : Controller
    {
        private readonly Assignment1Context _context;
        private readonly UserManager<Assignment1User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private string currentID;

        public UserManagerController(Assignment1Context context, RoleManager<IdentityRole> roleManager, UserManager<Assignment1User> userManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        // GET: Cities
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserData.ToListAsync());
        }

        // GET: Provinces/Details/5
        public async Task<IActionResult> DeleteUser(string id)
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

        public async Task<IActionResult> ChangeUserRole(string id)
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

            var IdentRole = await _context.IdentRole
                .FirstOrDefaultAsync(m => m.Id == id);
            if (UserData == null)
            {
                return NotFound();
            }
            
            var val = await _context.IdentRole
                .FirstOrDefaultAsync();

    
            //System.Diagnostics.Debug.WriteLine(roleManager.Roles);
            
           
            var CurrentRole = await _userManager.GetRolesAsync(UserData);
            this.currentID = id;

            System.Diagnostics.Debug.WriteLine("here yo");
            UserSpecs specs = new UserSpecs();
            specs.AvailableRoles = _roleManager.Roles.ToList();
            specs.CurrentRole = CurrentRole.ToList();
            var modelCollection = new ModelContainer();
            modelCollection.AddModel(UserData);
            modelCollection.AddModel(specs);
            return View(modelCollection);
        }

        // GET: Provinces/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Provinces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var CurrentUser = await _userManager.FindByIdAsync(id);
            await _userManager.DeleteAsync(CurrentUser);
            return RedirectToAction(nameof(Index));
        }

        // POST: Provinces/Delete/5
        [HttpPost, ActionName("RemoveFromRole")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RemoveFromRoleConfirmed(string item, string id)
        {
            System.Diagnostics.Debug.WriteLine("here");
            System.Diagnostics.Debug.WriteLine(item);
            System.Diagnostics.Debug.WriteLine(id);
            var CurrentUser = await _userManager.FindByIdAsync(id);
            await _userManager.RemoveFromRoleAsync(CurrentUser, item);
            return RedirectToAction(nameof(Index));
        }


        // POST: Provinces/Delete/5
        [HttpPost, ActionName("Save")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveConfirmed(string id)
        {
            string newRole = Request.Form["selectedRole"];
            System.Diagnostics.Debug.WriteLine(newRole);
            var currentUser = await _userManager.FindByIdAsync(id);
            var roles = await _userManager.GetRolesAsync(currentUser);
            //await _userManager.RemoveFromRolesAsync(currentUser, roles.ToArray());
            var userRoles = await _userManager.GetRolesAsync(currentUser);
            bool alreadyInrole = false;
            foreach(var item in userRoles.ToList())
            {
                if(item.Equals(newRole))
                {
                    alreadyInrole = true;
                }
            }

            if(!alreadyInrole)
            {
                await _userManager.AddToRoleAsync(currentUser, newRole);
            }
            return RedirectToAction(nameof(Index));
        }

        private bool ProvinceExists(string id)
        {
            return _context.UserData.Any(e => e.Id == id);
        }

    }
}
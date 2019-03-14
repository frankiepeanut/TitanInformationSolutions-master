using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TitanInformationSolutions.Data;
using TitanInformationSolutions.Models;
using Microsoft.AspNetCore.Authorization;
using TitanInformationSolutions.Utilities;

namespace TitanInformationSolutions.Controllers
{
    //[Authorize]
    public class InstructorProfileController : Controller
    {
        private readonly TitanInformationSolutionsContext _context;

        public InstructorProfileController(TitanInformationSolutionsContext context)
        {
            _context = context;
        }

        // GET: EmployeeProfile
        public IActionResult Index()
        {
            return RedirectToAction(nameof(Details));
        }

        // GET: EmployeeProfile/Details/5
        public async Task<IActionResult> Details()
        {

            var instructor = await _context.Instructors
                .Where(c => c.email == User.Identity.Name)
                .FirstOrDefaultAsync();
            if (instructor == null)
            {
                return RedirectToAction(nameof(Create));
            }

            return View(instructor);
        }

        // GET: EmployeeProfile/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: EmployeeProfile/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,email")] Instructor instructor)
        {
            instructor.email = User.Identity.Name;
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(instructor);
                    await _context.SaveChangesAsync();
                    UpdateUserNameCookie(instructor.FullName);
                    return RedirectToAction(nameof(Details));
                }
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(instructor);
        }

        // GET: EmployeeProfile/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var instructor = await _context.Instructors
                .Where(c => c.email == User.Identity.Name)
                .FirstOrDefaultAsync();
            if (instructor == null)
            {
                return NotFound();
            }
            return View(instructor);
        }

        // POST: EmployeeProfile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Byte[] RowVersion)
        {
            var instructorToUpdate = await _context.Instructors
                .FirstOrDefaultAsync(m => m.ID == id);

            if (await TryUpdateModelAsync<Instructor>(instructorToUpdate, "",
                c => c.firstName, c => c.lastName))
            {
                try
                {
                    //Put the original RowVersion value in the OriginalValues collection for the entity
                    _context.Entry(instructorToUpdate).Property("RowVersion").OriginalValue = RowVersion;
                    _context.Update(instructorToUpdate);
                    await _context.SaveChangesAsync();
                    UpdateUserNameCookie(instructorToUpdate.FullName);
                    return RedirectToAction(nameof(Details));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstructorExists(instructorToUpdate.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Unable to save changes. The record you attempted to edit "
                                + "was modified by another user after you received your values.  You need to go back and try your edit again.");
                    }
                }
            }
            return View(instructorToUpdate);
        }

        private void UpdateUserNameCookie(string userName)
        {
            CookieHelper.CookieSet(HttpContext, "userName", userName, 960);
        }

        private bool InstructorExists(int id)
        {
            return _context.Instructors.Any(e => e.ID == id);
        }
    
}

}

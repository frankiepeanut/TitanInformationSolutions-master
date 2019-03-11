﻿using System;
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
    [Authorize]
    public class EmployeeProfileController : Controller
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

            var employee = await _context.Instructor
                .Where(c => c.email == User.Identity.Name)
                .FirstOrDefaultAsync();
            if (employee == null)
            {
                return RedirectToAction(nameof(Create));
            }

            return View(employee);
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
        public async Task<IActionResult> Create([Bind("ID,FirstName,LastName,Phone,eMail")] Employee employee)
        {
            employee.eMail = User.Identity.Name;
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(employee);
                    await _context.SaveChangesAsync();
                    UpdateUserNameCookie(employee.FullName);
                    return RedirectToAction(nameof(Details));
                }
            }
            catch (DbUpdateException)
            {
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }

            return View(employee);
        }

        // GET: EmployeeProfile/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await _context.Employees
                .Where(c => c.eMail == User.Identity.Name)
                .FirstOrDefaultAsync();
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: EmployeeProfile/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Byte[] RowVersion)
        {
            var employeeToUpdate = await _context.Employees
                .FirstOrDefaultAsync(m => m.ID == id);

            if (await TryUpdateModelAsync<Employee>(employeeToUpdate, "",
                c => c.FirstName, c => c.LastName, c => c.Phone))
            {
                try
                {
                    //Put the original RowVersion value in the OriginalValues collection for the entity
                    _context.Entry(employeeToUpdate).Property("RowVersion").OriginalValue = RowVersion;
                    _context.Update(employeeToUpdate);
                    await _context.SaveChangesAsync();
                    UpdateUserNameCookie(employeeToUpdate.FullName);
                    return RedirectToAction(nameof(Details));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employeeToUpdate.ID))
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
            return View(employeeToUpdate);
        }

        private void UpdateUserNameCookie(string userName)
        {
            CookieHelper.CookieSet(HttpContext, "userName", userName, 960);
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.ID == id);
        }
    }

}

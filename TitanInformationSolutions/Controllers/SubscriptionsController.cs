﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TitanInformationSolutions.Data;
using TitanInformationSolutions.Models;

namespace TitanInformationSolutions.Controllers
{
	public class SubscriptionsController : Controller
	{
		private readonly TitanInformationSolutionsContext _context;
		private readonly IConfiguration _configuration;

		public SubscriptionsController(TitanInformationSolutionsContext context, IConfiguration configuration)
		{
			_context = context;
			_configuration = configuration;

		}

		// GET: Subscriptions
		public async Task<IActionResult> Index()
		{
			//Generate VAPID keys ifyou don't have them
			string PK = _configuration.GetSection("VapidKeys")["PublicKey"];
			if (String.IsNullOrEmpty(PK))
			{
				return RedirectToAction("GenerateKeys", "WebPush");
			}

			var subs = _context.Subs.Include(s => s.Parent);
			return View(await subs.ToListAsync());
		}

		// GET: Subscriptions/Create
		public IActionResult Create()
		{
			PopulateSelectLists();
			ViewBag.PublicKey = _configuration.GetSection("VapidKeys")["PublicKey"];
			return View();
		}

		// POST: Subscriptions/Create
		// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
		// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Create([Bind("ID,Name,PushEndpoint,PushP256DH,PushAuth,ParentID")] Sub sub)
		{
			if (ModelState.IsValid)
			{
				_context.Add(sub);
				await _context.SaveChangesAsync();
				return RedirectToAction(nameof(Index));
			}
			PopulateSelectLists(sub);
			return View(sub);
		}



		// GET: Subscriptions/Delete/5
		public async Task<IActionResult> Delete(int? id)
		{
			if (id == null)
			{
				return NotFound();
			}

			var sub = await _context.Subs
				.Include(s => s.Parent)
				.FirstOrDefaultAsync(m => m.ID == id);
			if (sub == null)
			{
				return NotFound();
			}

			return View(sub);
		}

		// POST: Subscriptions/Delete/5
		[HttpPost, ActionName("Delete")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> DeleteConfirmed(int id)
		{
			var sub = await _context.Subs.FindAsync(id);
			_context.Subs.Remove(sub);
			await _context.SaveChangesAsync();
			return RedirectToAction(nameof(Index));
		}

		private SelectList ParentSelectList(int? id)
		{
			var dQuery = from d in _context.Parents
						 orderby d.lastName, d.firstName
						 select d;
			return new SelectList(dQuery, "ID", "FormalName", id);
		}
		private void PopulateSelectLists(Sub sub = null)
		{
			ViewData["ParentID"] = ParentSelectList(sub?.ParentID);
		}

		private bool SubExists(int id)
		{
			return _context.Subs.Any(e => e.ID == id);
		}
	}
}
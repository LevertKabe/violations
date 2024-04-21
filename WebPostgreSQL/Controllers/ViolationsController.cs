using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebPostgreSQL.Models;

namespace WebPostgreSQL.Controllers
{
    public class ViolationsController : Controller
    {
        private readonly Contexto _context;

        public ViolationsController(Contexto context)
        {
            _context = context;
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Amount,DataIssued,ViolationType,IsPayed,AnnualTax,IssueOfficer,IssueCar,Payment")] Violation violation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(violation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(violation);
        }

        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CustMgmt.Models;

namespace CustMgmt.Controllers
{
    public class CustomerDetailsController : Controller
    {
        private readonly CMSDbContext _context;

        public CustomerDetailsController(CMSDbContext context)
        {
            _context = context;
        }

        // GET: CustomerDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.customerDetails.ToListAsync());
        }

        // GET: CustomerDetails/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerDetails = await _context.customerDetails
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customerDetails == null)
            {
                return NotFound();
            }

            return View(customerDetails);
        }

        // GET: CustomerDetails/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CustomerDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,FirstName,LastName,PrimaryContactNo,AltContactNo,Email,AddressLine1,AddressLine2,District,States,Country,PinCode,UID,PAN,Occupation")] CustomerDetails customerDetails)
        {
            if (ModelState.IsValid)
            {
                _context.Add(customerDetails);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(customerDetails);
        }

        // GET: CustomerDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerDetails = await _context.customerDetails.FindAsync(id);
            if (customerDetails == null)
            {
                return NotFound();
            }
            return View(customerDetails);
        }

        // POST: CustomerDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,FirstName,LastName,PrimaryContactNo,AltContactNo,Email,AddressLine1,AddressLine2,District,States,Country,PinCode,UID,PAN,Occupation")] CustomerDetails customerDetails)
        {
            if (id != customerDetails.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customerDetails);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerDetailsExists(customerDetails.CustomerId))
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
            return View(customerDetails);
        }

        // GET: CustomerDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customerDetails = await _context.customerDetails
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customerDetails == null)
            {
                return NotFound();
            }

            return View(customerDetails);
        }

        // POST: CustomerDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customerDetails = await _context.customerDetails.FindAsync(id);
            if (customerDetails != null)
            {
                _context.customerDetails.Remove(customerDetails);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustomerDetailsExists(int id)
        {
            return _context.customerDetails.Any(e => e.CustomerId == id);
        }
    }
}

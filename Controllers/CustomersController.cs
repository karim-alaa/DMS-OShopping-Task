using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DMSOShopping.Helper;
using DMSOShopping.Models;
using DMSOShopping.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json;
using DMSOShopping.Middlewares;

namespace DMSOShopping.Controllers
{
    public class CustomersController : Controller
    {
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly UserManager _userManager;

        public CustomersController(DataContext context, IHttpContextAccessor httpContextAccessor, UserManager userManager)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
            _userManager = userManager;
        }

        // GET: Customers/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // GET: Customers/Register
        public IActionResult Register()
        {
            return View();
        }

        // POST: Customers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([Bind("Id,Description_FL,Description_SL,Username,Password,IsAdmin,CreatedAt,UpdateAt")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                if(await _context.Customers.Where(c => c.Username == customer.Username).FirstOrDefaultAsync() != null)
                {
                    ModelState.AddModelError(nameof(customer.Username), "Username Already Exists");
                    return View(customer);
                }

                customer.Id = Guid.NewGuid();
                _context.Add(customer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return RedirectToAction(nameof(Login));
        }

        // GET: Customers/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Description_FL,Description_SL,Username,Password,IsAdmin,CreatedAt,UpdateAt")] Customer customer)
        {
            if (id != customer.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                if (await _context.Customers.Where(c => c.Username == customer.Username).FirstOrDefaultAsync() != null)
                {
                    ModelState.AddModelError(nameof(customer.Username), "Username Already Exists");
                    return View(customer);
                }

                try
                {
                    _context.Update(customer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index), "Items");
            }
            return View(customer);
        }

        private bool CustomerExists(Guid id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }

        // GET: Customers/Login
        public IActionResult Login()
        {
            return View();
        }

        // GET: Users/Logout
        public IActionResult Logout()
        {
            _httpContextAccessor.HttpContext.Session.SetString(SessionNames.ISLOGIN, SessionNames.NO);
            _httpContextAccessor.HttpContext.Session.Clear();
            _userManager.SignOut(this.HttpContext);

            return RedirectToAction(nameof(Login));
        }

        // POST: Customers/Login
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login([Bind("Username,Password")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                Customer loggedUser = await _context.Customers.Where(c => c.Username == customer.Username && c.Password == customer.Password)
                                .AsNoTracking()
                                .FirstOrDefaultAsync();
                if (loggedUser == null)
                {
                    ModelState.AddModelError(nameof(customer.Username), Messages.E_USERNAME_OR_PASSWORD_IS_WRONG);
                    return View(customer);
                }


                // Perform login logic
                _httpContextAccessor.HttpContext.Session.SetString(SessionNames.ISLOGIN, SessionNames.YES);
                _httpContextAccessor.HttpContext.Session.SetString(SessionNames.ROLE, loggedUser.IsAdmin.ToString());

                //authenticate
                _userManager.SignIn(this.HttpContext, loggedUser);

                var UserStr = JsonConvert.SerializeObject(loggedUser);
                _httpContextAccessor.HttpContext.Session.SetString(SessionNames.USER, UserStr);

                return RedirectToAction(nameof(Index), "Items");
            }
            return View(customer);
        }

        // GET: Doctors/Create
        public IActionResult AccessDenied()
        {
            return View();
        }

    }
}

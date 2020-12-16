using DMSOShopping.Constants;
using DMSOShopping.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Security.Claims;

namespace DMSOShopping.Middlewares
{
    public class UserManager
    {
        string _connectionString;

        public UserManager(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async void SignIn(HttpContext httpContext, Customer customer, bool isPersistent = false)
        {
            using var con = new Microsoft.Data.SqlClient.SqlConnection(_connectionString);
            ClaimsIdentity identity = new ClaimsIdentity(this.GetUserClaims(customer), CookieAuthenticationDefaults.AuthenticationScheme);
            ClaimsPrincipal principal = new ClaimsPrincipal(identity);

            await httpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
        }

        public async void SignOut(HttpContext httpContext)
        {
            await httpContext.SignOutAsync();
        }

        private IEnumerable<Claim> GetUserClaims(Customer customer)
        {
            string Role = Roles.ADMIN;
            if (!customer.IsAdmin)
                Role = Roles.USER;

            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, customer.Id.ToString()),
                new Claim(ClaimTypes.Name, customer.Username),
                new Claim(ClaimTypes.NameIdentifier, customer.Id.ToString()),
                new Claim(ClaimTypes.Role, Role)
            };
            return claims;
        }

    }
}

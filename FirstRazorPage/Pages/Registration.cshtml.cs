using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FirstRazorPage.Pages
{
    public class RegistrationModel : PageModel
    {
        [BindProperty]
        public string? FullName { get; set; }

        [BindProperty]
        public string? Email { get; set; }

        public void OnGet()
        {
            
        }

        public void OnPost()
        {
            var name = FullName;
            var email = Email;

            Console.WriteLine($"Name: {name}, email: {email}");
        }
    }
}

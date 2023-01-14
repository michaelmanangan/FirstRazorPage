using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using FirstRazorPage.Model;

namespace FirstRazorPage.Pages
{
    public class ViewProductsModel : PageModel
    {
        [BindProperty]
        public List<Products> Products { get; set; }

        public void OnGet()
        {
            Products = new List<Products>();
            Products.Add(new Products
            {
                ProductName = "iPod",
                Category = "Accessories",
                MRP = 120
            });

            Products.Add(new Products
            {
                ProductName = "Mouse",
                Category = "Computers",
                MRP = 140
            });

            Products.ToList();

        }
    }
}

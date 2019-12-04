using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProductsApp.Data;
using ProductsApp.Models;

namespace ProductsApp.Pages_Products
{
    public class IndexModel : PageModel
    {
        private readonly ProductsApp.Data.ProductsContext _context;

        public IndexModel(ProductsApp.Data.ProductsContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Movies.ToListAsync();
        }
    }
}

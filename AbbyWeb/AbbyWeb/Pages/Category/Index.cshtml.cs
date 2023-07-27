using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbbyWeb.Data;
using AbbyWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace AbbyWeb.Pages.Category
{
    public class Index : PageModel
    {
        private readonly ILogger<Index> _logger;

        public IEnumerable<AbbyWeb.Models.Category> Categories {get; set;}

        private readonly ApplicationDbContext _db;

        public Index(ILogger<Index> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {
            Categories = _db.Categories;
        }
    }
}
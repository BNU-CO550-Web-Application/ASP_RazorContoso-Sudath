using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ASP_RazorContoso.Data;
using ASP_RazorContoso.Models;

namespace ASP_RazorContoso.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ASP_RazorContoso.Data.SchoolContext _context;

        public IndexModel(ASP_RazorContoso.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Course> Courses { get; set; }

        public async Task OnGetAsync()
        {
            Courses = await _context.Courses
               .Include(c => c.Department)
               .AsNoTracking()
               .ToListAsync();
        }
    }
}

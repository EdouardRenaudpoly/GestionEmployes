using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using GestionEmployes.Data;
using GestionEmployes.Models;
using Microsoft.AspNetCore.Mvc;

namespace GestionEmployes.Pages.Employees
{
    public class DetailsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string? Action { get; set; }
        public required string PageTitle { get; set; }

        private readonly AppDbContext _context;
        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employees { get; set; } = new List<Employee>();

        [BindProperty(SupportsGet = true)]
        public string? SearchTerm { get; set; }

        public async Task OnGetAsync()
        {
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                Employees = await _context.Employees
                    .Where(e => e.Name.Contains(SearchTerm))
                    .ToListAsync();
            }
            PageTitle = Action switch
            {
                "delete" => "Rechercher un employé à retirer",
                "modify" => "Rechercher un employé à modifier",
                "details" => "Rechercher un employé pour voir les infos",
                _ => "",
            };
        }
    }
}

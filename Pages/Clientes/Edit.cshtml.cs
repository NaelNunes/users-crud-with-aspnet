using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetoCadastroUsuarios.Data;
using ProjetoCadastroUsuarios.Models;

namespace ProjetoCadastroUsuarios.Pages.Clientes
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente == null)
            {
                return NotFound();
            }

            Cliente = cliente; 

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int id)
        {
            var clientToUpdate = await _context.Clientes.FindAsync(id);

            if (clientToUpdate == null)
            {
                return NotFound();
            }

            if (await TryUpdateModelAsync<Cliente>(
                clientToUpdate,
                "Cliente",
                s => s.Nome, s => s.Email))
            {
                await _context.SaveChangesAsync();
                return RedirectToPage("./Index");
            }

            return Page();
        }

        private bool ClienteExists(int id)
        {
            return _context.Clientes.Any(e => e.Id == id);
        }
    }
}
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetoCadastroUsuarios.Data;
using ProjetoCadastroUsuarios.Models;

namespace ProjetoCadastroUsuarios.Pages.Clientes
{
    public class DeleteModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public DeleteModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public Cliente Cliente { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes
                .FirstOrDefaultAsync(m => m.Id == id);

            if (cliente == null)
            {
                return NotFound();
            }
            
            Cliente = cliente;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Clientes.FindAsync(id);

            if (cliente != null)
            {
                _context.Clientes.Remove(cliente); 
                
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
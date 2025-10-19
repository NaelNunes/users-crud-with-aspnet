using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetoCadastroUsuarios.Data;
using ProjetoCadastroUsuarios.Models;

namespace ProjetoCadastroUsuarios.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Cliente> Cliente { get; set; } = default!;

        public async Task OnGetAsync()
        {

            Cliente = await _context.Clientes.ToListAsync();
        }
    }
}
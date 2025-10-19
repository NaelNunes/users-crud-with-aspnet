using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProjetoCadastroUsuarios.Data;
using ProjetoCadastroUsuarios.Models;

namespace ProjetoCadastroUsuarios.Pages.Clientes
{
    // A rota será /Clientes/Index (ou apenas /Clientes)
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        // Injeção de Dependência do DbContext
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        // Propriedade que armazena a lista de clientes para ser usada na View
        public IList<Cliente> Cliente { get; set; } = default!;

        // Chamado quando a página é acessada (GET)
        public async Task OnGetAsync()
        {
            // Consulta o banco de dados e carrega todos os clientes na lista.
            // O .ToListAsync() garante que a consulta seja executada.
            Cliente = await _context.Clientes.ToListAsync();
        }
    }
}
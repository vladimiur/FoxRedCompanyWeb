using FoxRedCompany.Models;
using Microsoft.EntityFrameworkCore;

namespace FoxRedCompany.Datos
{
	public class ApplicationDbcontext: DbContext
	{
		public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext>options) : base(options)
		{
		}
		public DbSet<Clientes> clientes { get; set; }

	}
}

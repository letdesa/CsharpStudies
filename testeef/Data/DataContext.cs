using Microsoft.EntityFrameworkCore;
using testeef.Models;

namespace testeef.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) 
			: base(options)
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<Type> Types { get; set; }
	}
}
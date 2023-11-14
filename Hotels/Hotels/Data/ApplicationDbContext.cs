using Hotels.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotels.Data
{
	public class ApplicationDbContext:DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
		{
			 }
		public DbSet<Cart> carts { get; set; }
        public DbSet<Hotel> hotel { get; set; }
		public DbSet<Invoice> invoices { get; set; }
		public DbSet<RoomsDetails> roomsDetails { get; set; }
		public DbSet<Rooms> rooms { get; set; }
	}
}


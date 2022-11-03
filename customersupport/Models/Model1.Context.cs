namespace customer_supports.Models
{
	using customersupports.Models;
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Infrastructure;

	public partial class phase4Entities1 : DbContext
	{
		public phase4Entities1()
			: base("name=phase4Entities1")
		{
		}

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			throw new UnintentionalCodeFirstException();
		}

		public virtual DbSet<custinfo> custinfoes { get; set; }
		public virtual DbSet<userinfo> userinfoes { get; set; }
	}
}
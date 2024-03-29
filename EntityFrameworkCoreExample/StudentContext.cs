﻿using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCoreExample
{
	// https://learn.microsoft.com/en-us/ef/core/get-started/overview/install
	public class StudentContext: DbContext
	{
		public StudentContext()
		{

		}

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			// Database = The desired name for the database
			// Server = The server we are connecting to. LocalDB is included with VS
			// Trusted_Connection - indicates that our windows account should be used
			options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=EFCoreExampleTK;Trusted_Connection=True;");
		}

		// Tells EF Core to track Students in the database
		public DbSet<Student> Students { get;set; }
	}
}

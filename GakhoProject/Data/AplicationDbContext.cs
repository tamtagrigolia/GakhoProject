﻿using Microsoft.EntityFrameworkCore;
using GakhoProject.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace GakhoProject.Data
{
	public class AplicationDbContext : IdentityDbContext
	{
		public AplicationDbContext(DbContextOptions <AplicationDbContext> options) : base(options)
		{
		}

		public DbSet<PolitParties> classes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)

		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<PolitParties>().HasData(
					new PolitParties
					{
						Id = 1,
						YourFullName = "tamta grigolia",
						PartiesName = "ForGeo",
						DateOfBirth = new DateTime(1792, 2, 21),
					},
					new PolitParties
					{
						Id = 2,
						YourFullName = "irakli kobaxidze",
						PartiesName = "Georgia dream",
						DateOfBirth = new DateTime(1792, 2, 21),
					},
					new PolitParties
					{
						Id = 3,
						YourFullName = "giorgi gaxaria",
						PartiesName = "ForGeo",
						DateOfBirth = new DateTime(1792, 2, 21),
					}
				);
			modelBuilder.Entity<IdentityRole>().HasData(
				new IdentityRole()
				{
					Id = Guid.NewGuid().ToString(),
					Name = "Admin",
					NormalizedName = "ADMIN"
				},
				new IdentityRole()
				{
                    Id = Guid.NewGuid().ToString(),
                    Name = "Customer",
                    NormalizedName = "CUSTOMER"
                }
				);
		}

	}
}
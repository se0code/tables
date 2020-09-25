using dal.entities;
using dal.entities.identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace dal
{
    public class MyContext : IdentityDbContext<AppUser,AppRole,Guid,AppUserClaim,AppUserRole,AppUserLogin,AppRoleClaim,AppUserToken>
    {
        public MyContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Route> Routes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}

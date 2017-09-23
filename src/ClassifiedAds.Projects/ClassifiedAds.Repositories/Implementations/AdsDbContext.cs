using ClassifiedAds.Contracts.Entities;
using ClassifiedAds.Repositories.MappingConfigurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassifiedAds.Repositories.Implementations
{
    public class AdsDbContext : IdentityDbContext<User>
    {

        public AdsDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UserConfiguration());
        }
    }
}

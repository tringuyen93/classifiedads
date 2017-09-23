using ClassifiedAds.Contracts.Entities;
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
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassifiedAds.Repositories.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> DbSet { get; }

        IQueryable<T> GetAll();
    }
}

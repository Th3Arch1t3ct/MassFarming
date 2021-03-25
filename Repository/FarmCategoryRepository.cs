﻿using Contracts;
using Entities;
using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class FarmCategoryRepository : RepositoryBase<FarmCategory>, IFarmCategoryRepository
    {
        public FarmCategoryRepository(RepositoryContext context) : base(context) { }

        public async Task<IEnumerable<FarmCategory>> GetAllFarmTypesAsync() => await FindAll().OrderBy(cat => cat.Category).ToListAsync();
    }
}

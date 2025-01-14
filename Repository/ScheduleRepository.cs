﻿using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public class ScheduleRepository : RepositoryBase<Schedule>, IScheduleRepository
    {
        public ScheduleRepository(RepositoryContext context) : base(context) { }

        public IEnumerable<Schedule> GetByFarmId(Guid id)
        {
            return FindByCondition(sched => sched.FarmId.Equals(id));
        }
    }
}

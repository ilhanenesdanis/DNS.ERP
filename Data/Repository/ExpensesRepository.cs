﻿using Core.Entity;
using Core.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class ExpensesRepository : Repository<Expenses>, IExpensesRepository
    {
        public ExpensesRepository(Context context) : base(context)
        {
        }
    }
}

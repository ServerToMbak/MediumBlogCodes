﻿using UOWAndGenericRepoısitory.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UOWAndGenericRepoısitory.Data
{
    public interface IProductRepository : IGenericRepository<Product>
    {
    }
}

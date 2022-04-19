﻿using MasterGenerator.Data.Entity;
using MasterGenerator.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterGenerator.Data.Repository
{
    public interface IDealDetailsRepository
    {
        IEnumerable<string> GetAllCustomerMap();
        Task<bool> AddDealDetailsRange(List<DealDetails> dealDetails);
        Task<List<DealDetails>> GetDealDetailsByCustomerNames(List<string> name);
    }
}

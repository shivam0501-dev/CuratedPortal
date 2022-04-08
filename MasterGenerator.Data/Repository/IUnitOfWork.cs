﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterGenerator.Data.Repository
{
    public interface IUnitOfWork
    {
        IProjectRepository IProjectRepository { get; }
        IDealDetailsRepository IDealDetailsRepository { get; }
        Task<bool> Complete();
        bool HasChanges();
    }
}

using InstituteManagment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstituteManagment.Application.Contracts.Persistence
{
    internal interface IFeeRepository:IAsyncRepository<Fee>
    {
    }
}

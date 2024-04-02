using Demo.DAL.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IBaseRepository<Department> Department { get; }
        IBaseRepository<Employee> Employee { get; }

        void Complete();
    }
}

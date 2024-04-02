using BLL.Interfaces;
using Demo.DAL.Context;
using Demo.DAL.Entites;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Repositary
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IBaseRepository<Department> Department { get; private set; } 
        public IBaseRepository<Employee> Employee { get; private set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Department = new BaseRepository<Department>(_context);
            Employee = new BaseRepository<Employee>(_context);
        }

        public void Complete()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}

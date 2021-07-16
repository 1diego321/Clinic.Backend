﻿using Clinic.Core.Entities;
using Clinic.Core.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace Clinic.Infrastructure.Data.Repositories
{
    public class EmployeeRepository : GenericRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(AppDbContext context, IConfiguration configuration)
            : base(context, configuration)
        {
            
        }

        public async Task<Employee> GetByEmail(string email)
        {
            return await _dbEntity.Include(e => e.Person).Include(e => e.AppUser).FirstOrDefaultAsync(e => e.Person.Email.ToLower() == email.ToLower());
        }

        public async Task<Employee> GetByIdentification(int identification)
        {
            return await _dbEntity.Include(e => e.Person).Include(e => e.AppUser).FirstOrDefaultAsync(e => e.Person.Identification == identification);
        }
    }
}

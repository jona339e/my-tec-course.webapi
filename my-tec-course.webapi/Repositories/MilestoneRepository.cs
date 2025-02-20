﻿using my_tec_course.webapi.Interfaces.Repositories;
using my_tec_course.webapi.Models;

namespace my_tec_course.webapi.Repositories
{
    public class MilestoneRepository : IGenericCrudRepository<Milestone>
    {
        private readonly ApplicationDbContext _context;

        public MilestoneRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Milestone> CreateAsync(Milestone entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Milestone>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Milestone> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Milestone> UpdateAsync(Milestone entity)
        {
            throw new NotImplementedException();
        }
    }
}

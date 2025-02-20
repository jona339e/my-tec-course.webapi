﻿using my_tec_course.webapi.Interfaces.Repositories;
using my_tec_course.webapi.Interfaces.Services;
using my_tec_course.webapi.Models;

namespace my_tec_course.webapi.Services
{
    public class MilestoneService : IGenericCrudService<Milestone>
    {
        private readonly IGenericCrudRepository<Milestone> _repository;

        public MilestoneService(IGenericCrudRepository<Milestone> repository)
        {
            _repository = repository;
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

using System;
using ProductApp.Domain.Common;
using ProductApp.Domain.Entities;

namespace ProductApp.Application.Interfaces.Repository
{
	public interface IGenericRepositoryAsync<T> where T:BaseEntity
	{
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddSync(T Entity);
    }
}


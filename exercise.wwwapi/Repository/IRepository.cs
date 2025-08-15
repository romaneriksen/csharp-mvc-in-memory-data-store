﻿using exercise.wwwapi.Models;

namespace workshop.wwwapi.Repository
{
    public interface IRepository
    {
        Task<List<Product>> GetAsync();
        Task<Product> AddAsync(Product model);
        Task<Product> GetByIdAsync(int id);
        Task<Product> DeleteAsync(int id);
        Task<Product> UpdateAsync(int id, Product model);
    }
}
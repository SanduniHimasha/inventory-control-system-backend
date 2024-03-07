﻿using Assignment.Models;

namespace Assignment.Interfaces.IRepositories
{
    public interface ICategoryRepository
    {
        public Task<bool> AddCategory(ProductCategoryModel request);
        public Task<List<ProductCategoryModel>> GetAllCategories();
        public Task<ProductCategoryModel> GetCategoryById(string id);
        public Task<bool> DeleteCategoryById(ProductCategoryModel category);
        public Task<bool> UpdateCategory(ProductCategoryModel category);

    }
}

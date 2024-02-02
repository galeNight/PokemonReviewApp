﻿using PokemonReviewApp.Models;

namespace PokemonReviewApp.Intefaces
{
    public interface ICategoryRepository
    {
        ICollection<Category> GetCategories();
        Category GetCategory(int id);
        ICollection<Pokemon> GetPokemonByCategory(int categoryId);
        bool CategoriesExists(int id);
        bool CreateCategory(Category category);
        bool Save();
    }
}

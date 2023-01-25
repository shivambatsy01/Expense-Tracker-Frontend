using ExpenseTrackerFrontend.Models.APIModels;
using ExpenseTrackerFrontend.Models.Domain;

namespace ExpenseTrackerFrontend.DataProviders.CategoryDataProvider
{
    public interface ICategoryDataProvider
    {
        public Task<IEnumerable<Category>> GetAllCategoriesAsync();
        public Task<Category> AddCategoryAsync(CategoryApiModel category);
        public Task<Category> DeleteCategoryAsync(int id);
    }
}

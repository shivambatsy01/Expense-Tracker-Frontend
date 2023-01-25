using ExpenseTrackerFrontend.Models.APIModels;
using ExpenseTrackerFrontend.Models.Domain;
using RestSharp;

namespace ExpenseTrackerFrontend.DataProviders.CategoryDataProvider
{
    public class CategoryDataProvider : ICategoryDataProvider
    {
        private readonly IConfiguration configuration;
        private string urlRoute;
        public CategoryDataProvider(IConfiguration configuration)
        {
            this.configuration = configuration;
            urlRoute = configuration["APIServer"] + "categories/";
        }


        public async Task<Category> AddCategoryAsync(CategoryApiModel category)
        {
            var serverUrl = urlRoute;
            var client = new RestClient(serverUrl);
            var request = new RestRequest();
            request.AddJsonBody(category);
            var response = await client.PostAsync(request);

            return new Category();

        }

        public async Task<Category> DeleteCategoryAsync(int id)
        {
            var serverUrl = urlRoute + id.ToString() +"/";
            var client = new RestClient(serverUrl);
            var request = new RestRequest();
            var response = await client.DeleteAsync(request);
            
            return new Category();
        }

        public async Task<IEnumerable<Category>> GetAllCategoriesAsync()
        {
            var serverUrl = urlRoute;
            var client = new RestClient(serverUrl);
            var request = new RestRequest();
            var response = await client.GetAsync(request);

            return new List<Category>();

        }
    }
}

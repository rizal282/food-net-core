using foodapi.Data.Request;
using foodapi.Data.Response;

namespace foodapi.Services;

public interface IFoodService
{
    Task<IEnumerable<FoodResponse>> GetAllFoods();

    Task CreateNewFood(FoodRequest foodRequest);

    Task<FoodResponse> GetFoodById(int id);
}
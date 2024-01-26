using foodapi.Data.Request;
using foodapi.Data.Response;

namespace foodapi.Repositories;

public interface IFoodRepo
{
    Task<IEnumerable<FoodResponse>> GetAllFoods();

    Task CreateNewFood(FoodRequest foodRequest);

    Task<FoodResponse> GetFoodById(int id);
}
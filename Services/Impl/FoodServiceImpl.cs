using foodapi.Data.Request;
using foodapi.Data.Response;
using foodapi.Repositories;

namespace foodapi.Services.Impl;

public class FoodServiceImpl : IFoodService
{

    private readonly IFoodRepo _foodRepo;

    public FoodServiceImpl(IFoodRepo foodRepo)
    {
        _foodRepo = foodRepo;
    }

    public async Task CreateNewFood(FoodRequest foodRequest)
    {
        await _foodRepo.CreateNewFood(foodRequest);
    }

    public async Task<IEnumerable<FoodResponse>> GetAllFoods()
    {
        return await _foodRepo.GetAllFoods();
    }

    public async Task<FoodResponse> GetFoodById(int id)
    {
        var food = await _foodRepo.GetFoodById(id);

        if(food != null){
            return food;
        }

        return null;
    }
}
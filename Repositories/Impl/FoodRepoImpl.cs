using foodapi.Data;
using foodapi.Data.Request;
using foodapi.Data.Response;
using foodapi.Models;
using Microsoft.EntityFrameworkCore;

namespace foodapi.Repositories.Impl;

public class FoodRepoImpl : IFoodRepo
{

    private readonly ApplicationDbContext _appDbContext;

    public FoodRepoImpl(ApplicationDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task CreateNewFood(FoodRequest foodRequest)
    {
        var newFood = new Food {
            Name = foodRequest.Name,
            Price = foodRequest.Price,
            CategoryName = foodRequest.CategoryName
        };

        _appDbContext.Foods.Add(newFood);

        await _appDbContext.SaveChangesAsync();
    }

    public async Task<IEnumerable<FoodResponse>> GetAllFoods()
    {
        var listFoods = await _appDbContext.Foods.Select(food => new FoodResponse {
            Id = food.Id,
            Name = food.Name,
            Price = food.Price,
            CategoryName = food.CategoryName
        }).ToListAsync();

        return listFoods;
    }

    public async Task<FoodResponse> GetFoodById(int id)
    {
        return await _appDbContext.Foods.Select(food => new FoodResponse {
            Id = food.Id,
            Name = food.Name,
            Price = food.Price,
            CategoryName = food.CategoryName
        }).Where(food => food.Id == id).FirstOrDefaultAsync();
    }
}
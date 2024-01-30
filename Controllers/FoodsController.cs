using foodapi.Constans;
using foodapi.Data.Request;
using foodapi.Data.Response;
using foodapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace foodapi.Controllers;

[Route(ConstansEndpoint.BASE_ROUTE_API)]
[ApiController]
public class FoodsController : ControllerBase
{

    private readonly IFoodService _foodService;

    public FoodsController(IFoodService foodService)
    {
        _foodService = foodService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<FoodResponse>>> GetFoods()
    {
        var listFoods = await _foodService.GetAllFoods();

        if(listFoods == null){
            return NotFound("No foods found");
        }

        return StatusCode(StatusCodes.Status200OK, new {
            data = listFoods
        });
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<FoodResponse>> GetFoodById(int id)
    {
        var food = await _foodService.GetFoodById(id);

        if(food == null){
            return StatusCode(StatusCodes.Status404NotFound, new {
                message = "No food found with id ${id}"
            });
        }

        return Ok(food);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult> CreateFood([FromBody] FoodRequest foodRequest)
    {
        if(!ModelState.IsValid){
            return BadRequest();
        }

        await _foodService.CreateNewFood(foodRequest);

        return StatusCode(StatusCodes.Status201Created, new {
            data = foodRequest
        });
    }
}
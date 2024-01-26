using foodapi.Data.Response;
using foodapi.Services;
using Microsoft.AspNetCore.Mvc;

namespace foodapi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CustomersController : ControllerBase
{
    private readonly ICustomerService _customerService;

    public CustomersController(ICustomerService customerService)
    {
        _customerService = customerService;
    }

    [HttpGet]
    public async Task<ActionResult<List<CustomerResponse>>> GetAllCustomers()
    {
        var listCustomers = await _customerService.GetAllCustomers();

        if(listCustomers.Count == 0){
            return StatusCode(StatusCodes.Status204NoContent);
        }

        return StatusCode(StatusCodes.Status200OK, new {
            message = "success",
            data = listCustomers
        });
    }
}
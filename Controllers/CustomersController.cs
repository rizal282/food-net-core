using foodapi.Data.Request;
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

        if (listCustomers.Count == 0)
        {
            return StatusCode(StatusCodes.Status204NoContent);
        }

        return StatusCode(StatusCodes.Status200OK, new
        {
            message = "success",
            data = listCustomers
        });
    }

    [HttpGet("{id:int}")]
    public async Task<ActionResult<CustomerResponse>> GetCustomerById(int id)
    {
        var customer = await _customerService.GetCustomerById(id);

        if (customer == null)
        {
            return StatusCode(StatusCodes.Status404NotFound, new
            {
                message = "Customer not found"
            });
        }

        return StatusCode(StatusCodes.Status200OK, new
        {
            message = "success",
            data = customer
        });
    }

    [HttpPost]
    public async Task<ActionResult> CreateNewCustomer([FromBody] CustomerRequest customerRequest)
    {
        try
        {
            if (!ModelState.IsValid)
            {
                return StatusCode(StatusCodes.Status400BadRequest, new
                {
                    message = "All fields is Required"
                });
            }

            await _customerService.CreateNewCustomer(customerRequest);

            return StatusCode(StatusCodes.Status201Created, new
            {
                message = "created",
                data = customerRequest
            });
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new
            {
                message = e.InnerException
            });
        }
    }
}
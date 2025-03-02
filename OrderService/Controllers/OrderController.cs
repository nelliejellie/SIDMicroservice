using CustomerService;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly CustomerService.Customer.CustomerClient _customerClient;

    public OrderController(CustomerService.Customer.CustomerClient customerClient)
    {
        _customerClient = customerClient;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetCustomer(string id)
    {
        var request = new CustomerRequest { CustomerId = id };
        var response = await _customerClient.GetCustomerAsync(request);
        return Ok(response);
    }
}
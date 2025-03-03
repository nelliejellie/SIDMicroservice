using CustomerService;
using Grpc.Net.Client;
using Microsoft.AspNetCore.Mvc;
using GrpcCustomerService;


[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
     private readonly GrpcCustomerService.Customer.CustomerClient _customerClient;

     public OrderController(GrpcCustomerService.Customer.CustomerClient customerClient)
    {
        _customerClient = customerClient;
    }

     [HttpGet("getcustomer/{id}")]
     public async Task<IActionResult> GetCustomer(int id)
     {
         var request = new GrpcCustomerService.CustomerRequest { CustomerId = id };
         var response = await _customerClient.GetCustomerAsync(request);
        return Ok(response);
     }
}
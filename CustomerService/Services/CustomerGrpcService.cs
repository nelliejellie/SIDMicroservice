using Grpc.Core;
using Microsoft.EntityFrameworkCore;
using CustomerService;

public class CustomerGrpcService : CustomerService.Customer.CustomerBase
{
    private readonly CustomerDbContext _context;

    public CustomerGrpcService(CustomerDbContext context)
    {
        _context = context;
    }

    public override async Task<CustomerResponse> GetCustomer(CustomerRequest request, ServerCallContext context)
    {
        var customer = await _context.Customers.FindAsync(request.CustomerId);
        if (customer == null)
        {
            throw new RpcException(new Status(StatusCode.NotFound, "Customer not found"));
        }

        return new CustomerResponse
        {
            Id = customer.Id,
            Name = customer.Name,
            Email = customer.Email
        };
    }
}
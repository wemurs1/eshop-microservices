namespace Ordering.Application.Orders.Queries.GetOrdersByCustomer;

public record GetOrdersByCustomerRequest(Guid CustomerId) : IQuery<GetOrdersByCustomerResult>;
public record GetOrdersByCustomerResult(IEnumerable<OrderDto> Orders);

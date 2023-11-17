using Crm.BusinessLogic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Crm.Web;

[ApiController]
[Route("api/orders")]
[Authorize]
public sealed class OrderController : ControllerBase
{
    private readonly IOrderService _orderService;
    private readonly IOptionsMonitor<ConnectionStrings> _options;

    public OrderController(
        IOrderService orderService,
        IOptionsMonitor<ConnectionStrings> options)
    {
        _orderService = orderService;
        _options = options;
    }

    [HttpPost]
    public ValueTask<bool> CreateOrderAsync([FromBody] OrderInfo orderInfo, CancellationToken token)
        => _orderService.CreateOrderAsync(orderInfo, token);

    [HttpGet]
    [AllowAnonymous]
    public ValueTask<bool> FindOrderAsync([FromQuery] string description, CancellationToken token)
        => _orderService.FindOrderAsync(description, token);

    [HttpDelete]
    public ValueTask<bool> DeleteOrder([FromQuery] long orderId, CancellationToken token)
        => _orderService.RemoveOrderAsync(orderId, token);

    [HttpGet("Config")]
    [AllowAnonymous]
    public string Config()
    {
        return _options.CurrentValue.DefaultConnection;
    }
}
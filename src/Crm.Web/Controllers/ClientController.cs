using Crm.BusinessLogic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Crm.Web;

[ApiController]
[Route("api/clients")]
[Authorize]
public sealed class ClientController : ControllerBase
{
    private readonly IClientService _clientService;
    private readonly IOptionsMonitor<ConnectionStrings> _options;

    public ClientController(
        IClientService clientService,
        IOptionsMonitor<ConnectionStrings> options)
    {
        _clientService = clientService;
        _options = options;
    }

    [HttpPost]
    public ValueTask<bool> CreateClientAsync([FromBody] ClientInfo clientInfo, CancellationToken token)
        => _clientService.CreateClientAsync(clientInfo, token);

    [HttpGet]
    [AllowAnonymous]
    public ValueTask<bool> FindClientAsync([FromQuery] string firstName, [FromQuery] string lastName, CancellationToken token)
        => _clientService.FindClientAsync(firstName, lastName, token);

    [HttpDelete]
    public ValueTask<bool> DeleteClient([FromQuery] string firstName, [FromQuery] string lastName, CancellationToken token)
        => _clientService.RemoveClientAsync(firstName, lastName, token);

    [HttpGet("Config")]
    [AllowAnonymous]
    public string Config()
    {
        return _options.CurrentValue.DefaultConnection;
    }
}

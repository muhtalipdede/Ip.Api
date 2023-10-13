using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Ip.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RemoteIpController : ControllerBase
{

    public RemoteIpController()
    {
    }

    [HttpGet]
    public string Get()
    {
        var remoteIp = Request.HttpContext.Connection.RemoteIpAddress.MapToIPv4();
        return remoteIp.ToString();
    }
}

using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace Ip.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class IpController : ControllerBase
{

    public IpController()
    {
    }

    [HttpGet]
    public string Get()
    {
            string xForwardedForHeader = HttpContext.Request.Headers["X-Original-Forwarded-For"];
            Console.WriteLine(xForwardedForHeader);
            if (string.IsNullOrEmpty(xForwardedForHeader))
            {
                return "0.0.0.0";
            }
            string[] ipAddresses = xForwardedForHeader.Split(',');
            string ipv4Address = ipAddresses.FirstOrDefault(ip => IPAddress.TryParse(ip, out IPAddress address) && address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
            return ipv4Address;
    }
}

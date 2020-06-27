using Microsoft.AspNetCore.Mvc;

namespace Lambda.WebApi.Controllers
{
	[Route("api/Lambda/[controller]/[action]")]
	[ApiController]
	public class BaseController : ControllerBase
	{
	}
}

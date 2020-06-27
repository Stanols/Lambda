using Microsoft.AspNetCore.Mvc;

namespace Lambda.WebApi.Controllers
{
	public class ReportController : BaseController
	{
		public ReportController()
		{
		}

		[HttpPost]
		public void CreateReport()
		{
		}

		[HttpGet]
		public string GetReport()
		{
			return "Hello, world!";
		}
	}
}

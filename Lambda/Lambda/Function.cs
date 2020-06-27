using Microsoft.AspNetCore.Hosting;
using Amazon.Lambda.AspNetCoreServer;
using Lambda.WebApi;
using Microsoft.AspNetCore;

namespace Lambda.Function
{
	public class Function : APIGatewayProxyFunction
	{
		protected override void Init(IWebHostBuilder builder)
		{
			builder.UseStartup<Startup>();
		}

		public static void Main(string[] args)
		{
			BuildWebHost(args).Run();
		}

		public static IWebHost BuildWebHost(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>()
				.Build();
	}
}

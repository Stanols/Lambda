using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc;

namespace Lambda.WebApi
{
	public class Startup
	{
		public static IConfiguration Configuration { get; private set; }

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public void ConfigureServices(IServiceCollection services)
		{
			services.AddSingleton(Configuration);
			services.AddMvc(option => option.EnableEndpointRouting = false);
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseHttpsRedirection();
			app.UseMvc();
		}
	}
}

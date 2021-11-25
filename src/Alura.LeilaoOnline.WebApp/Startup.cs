using Alura.LeilaoOnline.WebApp.Dados;
using Alura.LeilaoOnline.WebApp.Dados.EfCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

#pragma warning disable RMSEncoding01 // Codificação (Encoding) do arquivo
namespace Alura.LeilaoOnline.WebApp
#pragma warning restore RMSEncoding01 // Codificação (Encoding) do arquivo
{
	public class Startup
	{
		//https://refactoring.guru/refactoring/smells


		public void ConfigureServices(IServiceCollection services)
		{
			services.AddTransient<ILeilaoDao, LeilaoDaoComEfCore>();
			services
					.AddControllersWithViews()
					.AddNewtonsoftJson(options =>
					{
						options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
					});
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseDeveloperExceptionPage();
			app.UseStatusCodePagesWithRedirects("/Home/StatusCode/{0}");
			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseRouting();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
									name: "default",
									pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}

using Blazored.LocalStorage;
using BlazorWebShop.Components;
using ClassLibrary;

namespace BlazorWebShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents();
            builder.Services.AddScoped<CartService>();
			builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddHttpClient("MinimalAPI", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7034");
            });

            //builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7034") });


            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseAntiforgery();

            app.MapStaticAssets();
            app.MapRazorComponents<App>()
                .AddInteractiveServerRenderMode();

            app.Run();
        }
    }
}

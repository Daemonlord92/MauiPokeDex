using Microsoft.Extensions.Logging;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using PokedexClient.Data;

namespace PokedexClient;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
    {
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiCompatibility()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
#endif

        builder.Services.AddScoped<PokemonService>();

        return builder.Build();
	}
}

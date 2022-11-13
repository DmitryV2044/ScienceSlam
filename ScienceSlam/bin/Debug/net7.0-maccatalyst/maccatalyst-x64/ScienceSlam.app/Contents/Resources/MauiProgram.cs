namespace ScienceSlam;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");
                fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");

            });


        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddTransient<LoginPage>();
        builder.Services.AddTransient<LoginPageModel>();

        builder.Services.AddTransient<CurrentEventPage>();
        builder.Services.AddTransient<CurrentEventPageModel>();

        builder.Services.AddTransient<VotePage>();
        builder.Services.AddTransient<VotePageModel>();

       // builder.Services.AddTransient<CurrentEventAlt>();
       // builder.Services.AddTransient<CurrentEventPageAltModel>();

        return builder.Build();
	}
}


namespace People;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		//Implementacion de SQLite: referencia
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        // TODO: Add statements for adding PersonRepository as a singleton
        string dbPath = FileAccessHelper.GetLocalFilePath("JDS_People.db3");
        builder.Services.AddSingleton<PersonRepository>(s => ActivatorUtilities.CreateInstance<PersonRepository>(s, dbPath));
        return builder.Build();
	}
}

using Microsoft.Extensions.Logging;
using Todo5834249.Data;
using Todo5834249.View;

namespace Todo5834249
{
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
                });

#if DEBUG
    		builder.Logging.AddDebug();

            builder.Services.AddSingleton<TodoListPage>();
            builder.Services.AddTransient<TodoListPage>();

            builder.Services.AddSingleton<TodoItemDatabase>();
#endif

            return builder.Build();
        }
    }
}

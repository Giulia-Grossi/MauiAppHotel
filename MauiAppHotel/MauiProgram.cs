using Microsoft.Extensions.Logging;

namespace MauiAppHotel
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
                    fonts.AddFont("SourGummy_Expanded-Bold.ttf", "SourGummyBold");
                    fonts.AddFont("SourGummy_Expanded-BoldItalic.ttf", "SourGummyBoldItalic");
                    fonts.AddFont("SourGummy_Expanded-Italic.ttf", "SourGummyItalic");
                    fonts.AddFont("SourGummy_Expanded-Regular.ttf", "SourGummy");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}

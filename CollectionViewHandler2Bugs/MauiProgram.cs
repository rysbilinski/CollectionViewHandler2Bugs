using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using CollectionViewHandler2Bugs.PageModels;

namespace CollectionViewHandler2Bugs
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>().ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
                .UseMauiCommunityToolkit();
#if IOS || MACCATALYST
            builder.ConfigureMauiHandlers(handlers =>
            {
                handlers.AddHandler<Microsoft.Maui.Controls.CollectionView, Microsoft.Maui.Controls.Handlers.Items2.CollectionViewHandler2>();
                handlers.AddHandler<Microsoft.Maui.Controls.CarouselView, Microsoft.Maui.Controls.Handlers.Items2.CarouselViewHandler2>();
            });
#endif
#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<ItemsLayoutPageModel>();
            builder.Services.AddSingleton<RelativeSourceBindingPageModel>();


            return builder.Build();
        }
    }
}
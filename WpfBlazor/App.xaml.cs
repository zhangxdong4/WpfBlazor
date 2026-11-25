using System.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace WpfBlazor
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // 对应 MAUI 项目 MauiProgram.cs 里的 CreateMauiApp() 注册服务
        public static IServiceProvider Services { get; } = ConfigureServices();

        private static IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();

            // 注册 BlazorWebView 所需服务（对应 AddMauiBlazorWebView）
            services.AddWpfBlazorWebView();

#if DEBUG
            services.AddBlazorWebViewDeveloperTools();
#endif

            return services.BuildServiceProvider();
        }
    }
}

using Microsoft.UI;
using Microsoft.UI.Windowing;
using Microsoft.UI.Xaml;
using Windows.Graphics;

namespace MauiAppJogoDaVelha.WinUI
{
    public partial class App : MauiWinUIApplication
    {
        public App()
        {
            this.InitializeComponent();
        }

        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        protected override void OnLaunched(LaunchActivatedEventArgs args)
        {
            base.OnLaunched(args);

            foreach (var window in Microsoft.Maui.Controls.Application.Current.Windows)
            {
                var nativeWindow = window.Handler.PlatformView as Microsoft.UI.Xaml.Window;
                if (nativeWindow != null)
                {
                    IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
                    WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
                    AppWindow appWindow = AppWindow.GetFromWindowId(windowId);

                    if (appWindow != null)
                    {
                        // Define o tamanho da janela (Largura x Altura em pixels)
                        appWindow.Resize(new SizeInt32(430, 750));
                    }
                }
            }
        }
    }
}
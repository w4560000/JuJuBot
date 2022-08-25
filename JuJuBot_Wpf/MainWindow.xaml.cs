using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace JuJuBot_Wpf
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeCoreWebView2Environment();
        }

        async void InitializeCoreWebView2Environment()
        {
            string args = "--autoplay-policy=no-user-gesture-required ";
            //if (_webWindowOptions.DisableWebSecurity)
            //    args += "--disable-web-security";

            CoreWebView2Environment coreWebView2Environment = 
                await CoreWebView2Environment.CreateAsync(null, Helper.GetPathForUserAppDataFolder(""), new CoreWebView2EnvironmentOptions(args));
            await webView2.EnsureCoreWebView2Async(coreWebView2Environment);
            //webView2.CoreWebView2.IsMuted = _webWindowOptions.IsMuted;

            //LoadScript();
            webView2.Source = new Uri("http://localhost:8085/api/bot");
            webView2.DefaultBackgroundColor = System.Drawing.Color.Transparent;
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }
    }

    public static class WindowBehaviours
    {
        // Closing window
        public static void SetClose(DependencyObject target, bool value)
        {
            target.SetValue(CloseProperty, value);
        }

        public static readonly DependencyProperty CloseProperty =
                                                  DependencyProperty.RegisterAttached("Close",
                                                  typeof(bool),
                                                  typeof(WindowBehaviours),
                                                  new UIPropertyMetadata(false, OnClose));

        private static void OnClose(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (((System.Windows.Shapes.Path)sender).Name == "CloseWindow")
            {
                if (e.NewValue is bool && ((bool)e.NewValue))
                {
                    Window window = GetWindow(sender);

                    if (window != null)
                    {
                        window.Close();
                    }
                }
            }
        }

        private static Window GetWindow(DependencyObject sender)
        {
            Window window = null;

            if (sender is Window)
            {
                window = (Window)sender;
            }

            if (window == null)
            {
                window = Window.GetWindow(sender);
            }

            return window;
        }
    }
}

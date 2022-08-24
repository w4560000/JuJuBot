using JuJuBot_Wpf.Owin;
using Microsoft.Owin.Hosting;
using System;
using System.Net;
using System.Threading;
using System.Windows;

namespace JuJuBot_Wpf
{
    /// <summary>
    /// App.xaml 的互動邏輯
    /// </summary>
    public partial class App : Application
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            try
            {
                using (new Mutex(true, "f45b30b9-9e65-4d33-a2bc-d6ba6a7500bd", out var createdNew))
                {
                    if (createdNew)
                    {
                        string baseUri = "http://localhost:8085";

                        Console.WriteLine("Starting web Server...");
                        WebApp.Start<Startup>(baseUri);

                        ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls12;
                        StartupUri = new Uri("/MainWindow.xaml", UriKind.Relative);
                    }
                }
            }
            catch (Exception ex)
            {
                //StaticCode.Logger?.Here().Error(ex.Message);
            }
        }
    }
}
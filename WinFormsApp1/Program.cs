using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            HostApplicationBuilder builder = Host.CreateApplicationBuilder();
            builder.Configuration.Sources.Clear();

            IHostEnvironment env = builder.Environment;

            builder.Configuration
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appsettings.test.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appsettings.prod.json", optional: true, reloadOnChange: true)
                .Build();

            builder.Services.AddSingleton<Form1>();
            var host = builder.Build();

            var form1 = host.Services.GetRequiredService<Form1>();
            Application.Run(form1);
        }
    }
}
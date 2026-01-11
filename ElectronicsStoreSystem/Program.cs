using DotNetEnv;
using ElectronicsStoreSystem.View;
namespace ElectronicsStoreSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Env.Load(); 
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
using DotNetEnv;
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
            Env.Load(); // Load .env file contents into environment variables
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
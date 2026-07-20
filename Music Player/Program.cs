namespace Music_Player
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Global exception handlers to capture runtime errors and show stack traces for debugging
            Application.ThreadException += (sender, e) =>
            {
                ShowException(e.Exception);
            };

            AppDomain.CurrentDomain.UnhandledException += (sender, e) =>
            {
                if (e.ExceptionObject is Exception ex)
                {
                    ShowException(ex);
                }
            };

            try
            {
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                ShowException(ex);
            }
        }

        private static void ShowException(Exception ex)
        {
            try
            {
                string message = $"Unhandled exception:\n{ex.Message}\n\nStack trace:\n{ex.StackTrace}";
                MessageBox.Show(message, "Unhandled Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                // swallow
            }
        }
    }
}
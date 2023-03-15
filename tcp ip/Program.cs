namespace tcp_ip
{
    internal static class Program
    {
        public static void server()
        {
            Application.Run(new Form1());
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Thread t1 = new Thread(new ThreadStart(server));
            t1.Start();
        }
    }
}
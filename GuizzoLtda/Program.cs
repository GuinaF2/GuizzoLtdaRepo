using Modelos;

namespace GuizzoLtda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Inicio());
                
                ApplicationConfiguration.Initialize();

        }
        public static PictureBox thePictureBox;

    }
}
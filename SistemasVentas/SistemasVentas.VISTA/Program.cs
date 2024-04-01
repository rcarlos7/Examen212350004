namespace SistemasVentas.VISTA
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
            Application.Run(new Ejercicio1Vistas.Ejercicio1ListarVista());
            Application.Run(new Ejercicio2Vistas.Ejercicio2ListarVista());
            Application.Run(new Ejercicio3Vistas.Ejercicio3ListarVista());
            Application.Run(new Ejercicio4Vistas.Ejercicio4ListarVista());
            Application.Run(new Ejercicio5Vistas.Ejercicio5ListarVista());
            Application.Run(new Ejercicio6Vistas.Ejercicio6ListarVista());
            Application.Run(new Ejercicio7Vistas.Ejercicio7ListarVista());
            Application.Run(new Ejercicio8Vistas.Ejercicio8ListarVista());
            Application.Run(new Ejercicio9Vistas.Ejercicio9ListarVista());
        }
    }
}
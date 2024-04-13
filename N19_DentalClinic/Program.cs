using N19_DentalClinic.controller.receptionist;
using N19_ProjectForm.GUI.AdminView;
using N19_ProjectForm.GUI.ReceptionistView;

namespace N19_DentalClinic
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
            Application.Run(new Admin());
            //Application.Run(new Receptionist());
        }
    }
}
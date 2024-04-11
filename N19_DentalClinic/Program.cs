using N19_DentalClinic.controller.receptionist;

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
            //Application.Run(new Form1());
            // -- Test ManagePatientFornm
            //Application.Run(new ManageAppointmentBookingForm());
            Application.Run(new N19_ProjectForm.GUI.ReceptionistView.Receptionist());
        }
    }
}
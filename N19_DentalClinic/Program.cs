using N19_DentalClinic.controller.receptionist;
using N19_DentalClinic.GUI.AccountView;
using N19_DentalClinic.GUI.AdminView;
using N19_DentalClinic.GUI.DentistView;
using N19_DentalClinic.GUI.ReceptionistView;
using N19_DentalClinic.GUI.SupportView;

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
            //Application.Run(new Receptionist("RE00000001"));
            Application.Run(new Dentist("DE00000001"));
            //Application.Run(new Report());
            //Application.Run(new Admin());
            //Application.Run(new LoginMain());
        }
    }
}
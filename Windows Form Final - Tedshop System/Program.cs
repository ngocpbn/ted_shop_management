using Windows_Form_Final___Tedshop_System.BusinessObjects;
using Windows_Form_Final___Tedshop_System.Views.Dashboard;
using Windows_Form_Final___Tedshop_System.Views.SupplierForm;

namespace Windows_Form_Final___Tedshop_System
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
            Application.Run(new FormLogin());
        }
    }
}
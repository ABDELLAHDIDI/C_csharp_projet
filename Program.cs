using DB;
using System.Xml.Linq;

namespace projet
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


            XDocument doc;

         try
            {
                doc = XDocument.Load(@".\env.xml");
                Connection.Connect();

                ApplicationConfiguration.Initialize();
                Application.Run(new Gestion());


            }
            catch (Exception ex)
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new sign_up());
               
            }




        }
    }
}
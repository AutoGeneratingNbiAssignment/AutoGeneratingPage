using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoGeneratingPage
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            var test = new List<JsonHandlerTest>()
            {
                new JsonHandlerTest {Name = "Oliver", LastName = "Stenström", BornYear = 1994 },
                new JsonHandlerTest {Name = "Kevin", LastName = "Dani", BornYear = 1994 },
                new JsonHandlerTest {Name = "Vivi", LastName = "Tran", BornYear = 1994 },
                new JsonHandlerTest {Name = "Daniel", LastName = "Xu", BornYear = 1994 }
            };

            var file = new GenericJsonFilehandler<List<JsonHandlerTest>> { Filename = "Us", Data = test };
            file.Save();

            var file2 = new GenericJsonFilehandler<List<JsonHandlerTest>> { Filename = "Us" };
            file2.Load();
        }
    }
}

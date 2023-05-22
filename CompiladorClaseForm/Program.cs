using CompiladorClaseForm.CrossCutting;
using CompiladorClaseForm.DataCache;
using CompiladorClaseForm.ErrorManager;
using CompiladorClaseForm.LexicalAnalyzer;
using CompiladorClaseForm.SyntaticAnalyzer;

namespace CompiladorClaseForm
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
            Application.Run(new Form1());
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            
            // Precarga de datos
            Cache.AddLine(Line.Create(1, "123 456           678,8"));
            Cache.AddLine(Line.Create(2, "?         678  "));
            Cache.AddLine(Line.Create(3, ""));
            Cache.AddLine(Line.Create(4, "4"));

            LexicalAnalysis.Initialize();

            try
            {
                SintaticAnalysis SiAna = new SintaticAnalysis();
                string response = SiAna.Analyze();
                Console.WriteLine(response);

            }
            catch (Exception exception)
            {
                Console.WriteLine("¡¡¡¡¡ERROR DE COMPILACION!!!!!");
                Console.WriteLine(exception.Message);
            }
            //Pintar los resultados
            if (TablaMaestra.GetComponentsAsList(ComponentType.NORMAL).Count > 0)
            {
                Console.WriteLine("Simbolos: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.NORMAL))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            else if (TablaMaestra.GetComponentsAsList(ComponentType.LITERAL).Count > 0)
            {
                Console.WriteLine("Literales: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.LITERAL))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            else if (TablaMaestra.GetComponentsAsList(ComponentType.PALABRA_RESERVADA).Count > 0)
            {
                Console.WriteLine("Palabras reservadas: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.PALABRA_RESERVADA))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            else if (TablaMaestra.GetComponentsAsList(ComponentType.DUMMY).Count > 0)
            {
                Console.WriteLine("Dummies: ");
                foreach (LexicalComponent componentTmp in TablaMaestra.GetComponentsAsList(ComponentType.DUMMY))
                {
                    Console.WriteLine("=======================================================");
                    Console.WriteLine(componentTmp.ToString());

                }
            }
            if (ErrorManagement.HayErrores())
            {
                foreach (Error error in ErrorManagement.GetErrors(ErrorLevel.LEXICO))
                {
                    Console.WriteLine(error.ToString());
                    Console.WriteLine("___________________________________________________________");
                }
            }


            Console.ReadKey();
        }
    
    }
}
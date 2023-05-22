using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompiladorClaseForm.LexicalAnalyzer;

namespace CompiladorClaseForm.CrossCutting
{
    public class TablaDeDummies : TablaComponentes
    {
        private static TablaComponentes INSTANCE = new TablaComponentes();

        private TablaDeDummies()
        {

        }

        public static TablaComponentes GetTablaDummies()
        {
            return INSTANCE;
        }

        public static void Inicializar()
        {
            INSTANCE.Initialize();
        }

        public static void Add(LexicalComponent component)
        {
            INSTANCE.Add(component);
        }

        public static List<LexicalComponent> GetComponetsAsList()
        {
            return INSTANCE.GetComponentsAsList();
        }

        public static Dictionary<string, List<LexicalComponent>> GetComponets()
        {
            return INSTANCE.GetComponents();
        }
    }

}

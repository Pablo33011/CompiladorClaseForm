using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompiladorClaseForm.LexicalAnalyzer;

namespace CompiladorClaseForm.CrossCutting
{
    public  class TablaSimbolos : TablaComponentes
    {
        private static TablaComponentes INSTANCE = new TablaSimbolos();

        private TablaSimbolos() 
        {
            
        }

        public static TablaComponentes GetTablaSimbolos()
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

        public static Dictionary<string, List<LexicalComponent>> GetComponents()
        {
            return INSTANCE.GetComponents();
        }

        public static List<LexicalComponent> GetComponentsAsList()
        {
            return INSTANCE.GetComponentsAsList();
        }
    }
}

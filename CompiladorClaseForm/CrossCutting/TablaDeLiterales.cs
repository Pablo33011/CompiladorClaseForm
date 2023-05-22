﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompiladorClaseForm.LexicalAnalyzer;

namespace CompiladorClaseForm.CrossCutting
{
    internal class TablaDeLiterales : TablaComponentes
    {
        private static TablaComponentes INSTANCE = new TablaComponentes();

        private TablaDeLiterales()
        {

        }

        public static TablaComponentes GetTablaLiterales()
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

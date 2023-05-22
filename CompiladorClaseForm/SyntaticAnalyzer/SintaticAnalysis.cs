using CompiladorClaseForm.DataCache;
using CompiladorClaseForm.ErrorManager;
using CompiladorClaseForm.LexicalAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompiladorClaseForm.SyntaticAnalyzer
{
    public class SintaticAnalysis
    {
        private LexicalComponent Component;
        private LexicalAnalysis LexAna;

        public SintaticAnalysis()
        {
            LexAna = LexicalAnalysis.GetInstance();
        }

        public string Analyze() 
        {
            string response = "El proceso de Analisis Sintantico finalizó exitosamente";
            LexicalAnalysis.Initialize();
            LeerSiguienteComponente();
            Expresion();

            if (ErrorManagement.HayErrores())
            {
                response = "El proceso de Compiplación finalizó con errores...";
            }
            else if (Category.EOF.Equals(Component.GetCategory()))
            {
                response = "Aunque no se presentaron errores durante el proceso de compilacion, faltaron componentes por evaluar...";
            }
            return response;
        }
        private void Expresion() 
        {
            Terimino();
            ExpresionPrima();
        }

        private void ExpresionPrima() 
        {
          if(EsCategoriaEsperada(Category.SUMA))
            {
                LeerSiguienteComponente();
                Expresion();
            }
          else if (EsCategoriaEsperada(Category.RESTA))
            {
                LeerSiguienteComponente();
                Expresion();
            }
        }

        private void Terimino() 
        {
            Factor();
            TerminoPrima();
        }

        private void TerminoPrima()
        {
            if (EsCategoriaEsperada(Category.MULTIPLICACION))
            {
                LeerSiguienteComponente();
                Terimino();

            }
            else if (EsCategoriaEsperada(Category.DIVISION))
            {
                LeerSiguienteComponente();
                Terimino();

            }
        }

        private void Factor()
        {
            if (EsCategoriaEsperada(Category.ENTERO))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.DECIMAL))
            {
                LeerSiguienteComponente();
            }
            else if (EsCategoriaEsperada(Category.PARENTESIS_QUE_ABRE))
            {
                LeerSiguienteComponente();
                Expresion() ;
                if (EsCategoriaEsperada(Category.PARENTESIS_QUE_CIERRA))
                {
                    LeerSiguienteComponente() ;
                }
                else
                {
                    string fail = "Componente lexico no valido a parentesis que cierra...";
                    string cause = "Se ha recibido un simbolo desconocido por el lenguaje...";
                    string solution = "Asegurese de que solo existan simbolos aceptados por el lenguaje...";
                    CreateSintacticEror(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, Component.GetCategory().ToString());
                }
            }
            else
            {
                string fail = "Componente lexico no valido a parentesis que cierra...";
                string cause = "Se ha recibido un simbolo desconocido por el lenguaje...";
                string solution = "Asegurese de que solo existan simbolos aceptados por el lenguaje...";
                CreateSintacticEror(ErrorType.STOPPER, fail, cause, solution, Category.GENERAL, Component.GetCategory().ToString());
            }

        }

        private bool EsCategoriaEsperada(Category category)
        {
            return category.Equals(Component.GetCategory());
        }
        private void LeerSiguienteComponente()
        {
            Component = LexicalAnalysis.Analyze();
        }
        private  void CreateSintacticEror(ErrorType errorType, string fail, string cause, string solution, Category expectedCategory, string lexeme)
        {
            int lineNumber = Component.GetLineNumber();
            Error error;

            if (ErrorType.STOPPER.Equals(errorType))
            {
                int initialPosition = Component.GetInitialPosition();
                int finalPosition = Component.GetFinalPosition();
                 error = Error.CreateStopperSintacticError(lineNumber, initialPosition, finalPosition, fail, cause, solution, expectedCategory, lexeme);
                ErrorManagement.Agregar(error);
                throw new Exception("Se ha presentado un error de tipo STOPPER durante el analisis lexico" +
                    "No es posible continuar con el proceso de compilacion hasta que el error haya sido " +
                    "solucionado. Por favor verifique la consola de errores para tender mas detalle del " +
                    "problema que se ha presentado...");

            }
            else if (ErrorType.CONTROLABLE.Equals(errorType))
            {
                int initialPosition = Component.GetInitialPosition();
                int finalPosition = Component.GetFinalPosition();
                 error = Error.CreateNoStopperSintacticError(lineNumber, initialPosition, finalPosition, fail, cause, solution, expectedCategory, lexeme);
                ErrorManagement.Agregar(error);
            }
        }
    }
}

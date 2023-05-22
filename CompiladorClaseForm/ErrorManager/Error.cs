using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using CompiladorClaseForm.LexicalAnalyzer;

namespace CompiladorClaseForm.ErrorManager
{
    public class Error
    {
        private int LineNumber;
        private int InitialPosition;
        private int FinalPosition;
        private string Fail;
        private string Cause;
        private string Solution;
        private ErrorLevel Level;
        private ErrorType Type;
        private Category ExpectedCategory;
        private string Lexeme;

        public Error(int lineNumber, int initialPosition, int finalPosition, string fail, string cause, string solution, ErrorLevel level, ErrorType type, Category expectedCategory, string lexeme)
        {
            LineNumber = lineNumber;
            InitialPosition = initialPosition;
            FinalPosition = finalPosition;
            Fail = fail;
            Cause = cause;
            Solution = solution;
            Level = level;
            Type = type;
            ExpectedCategory = expectedCategory;
            Lexeme = lexeme;
        }

        public static Error CreateStopperSintacticError(int lineNumber, int initialPosition, int finalPosition, string fail, string cause, string solution, Category expectedCategory, string lexeme)
        {
            return new Error(lineNumber, initialPosition, finalPosition, fail, cause, solution, ErrorLevel.SINTACTICO, ErrorType.STOPPER, expectedCategory, lexeme);
        }
        public static Error CreateStopperLexicalError(int lineNumber, int initialPosition, int finalPosition, string fail, string cause, string solution, Category expectedCategory, string lexeme)
        {
            return new Error(lineNumber, initialPosition, finalPosition, fail, cause, solution, ErrorLevel.LEXICO, ErrorType.STOPPER, expectedCategory, lexeme);
        }

        public static Error CreateNoStopperLexicalError(int lineNumber, int initialPosition, int finalPosition, string fail, string cause, string solution, Category expectedCategory, string lexeme)
        {
            return new Error(lineNumber, initialPosition, finalPosition, fail, cause, solution, ErrorLevel.LEXICO, ErrorType.CONTROLABLE, expectedCategory, lexeme);
        }

        public static Error CreateNoStopperSintacticError(int lineNumber, int initialPosition, int finalPosition, string fail, string cause, string solution, Category expectedCategory, string lexeme)
        {
            return new Error(lineNumber, initialPosition, finalPosition, fail, cause, solution, ErrorLevel.SINTACTICO, ErrorType.CONTROLABLE, expectedCategory, lexeme);
        }

        public void SetLineNumber(int lineNumber)
        {
            LineNumber = lineNumber;
        }

        public void SetInitialPosition(int initialPosition)
        {
            InitialPosition = initialPosition;
        }

        public void SetFinalPosition(int finalPosition)
        {
            FinalPosition = finalPosition;
        }

        public void SetExpectedCategory(Category expectedCategory)
        {
            ExpectedCategory = expectedCategory;
        }

        public void SetLexeme(string lexeme)
        {
            Lexeme = lexeme;
        }

        public void SetFail(string fail)
        {
            Fail = fail;
        }

        public void SetCause(string cause)
        {
            Cause = cause;
        }

        public void SetSolution(string solution)
        {
            Solution = solution;
        }

        public void SetLevel(ErrorLevel level)
        {
            Level = level;
        }

        public void SetType(ErrorType type)
        {
            Type = type;
        }

        public int GetLineNumber()
        {
            return LineNumber;
        }

        public int GetInitialPosition()
        {
            return InitialPosition;
        }

        public int GetFinalPosition()
        {
            return FinalPosition;
        }

        public Category GetExpectedCategory()
        {
            return ExpectedCategory;
        }

        public string GetLexeme()
        {
            return Lexeme;
        }

        public string GetFail()
        {
            return Fail;
        }

        public string GetCause()
        {
            return Cause;
        }

        public string GetSolution()
        {
            return Solution;
        }

        public ErrorLevel GetLevel()
        {
            return Level;
        }

        public ErrorType GetType()
        {
            return Type;
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Nivel: ").Append(GetLevel()).Append("\n");
            sb.Append("Típo: ").Append(GetType()).Append("\n");
            sb.Append("Falla: ").Append(GetFail()).Append("\n");
            sb.Append("Causa: ").Append(GetCause()).Append("\n");
            sb.Append("Solución: ").Append(GetSolution()).Append("\n");
            sb.Append("Categoría Esperada: ").Append(GetExpectedCategory()).Append("\n");
            sb.Append("Lexema: ").Append(GetLexeme()).Append("\n");
            sb.Append("Numero de Linea: ").Append(GetLineNumber()).Append("\n");
            sb.Append("Posicion de linea: ").Append(GetInitialPosition()).Append("\n");
            sb.Append("Posicion Final: ").Append(GetFinalPosition()).Append("\n");

            return sb.ToString();
        }
    }
}

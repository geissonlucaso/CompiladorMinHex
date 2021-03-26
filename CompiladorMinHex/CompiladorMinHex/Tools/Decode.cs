using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CompiladorMinHex.Tools
{
    public static class Decode
    {
        private static String X { get; set; }
        private static String Y { get; set; }
        private static String W { get; set; }
        public static String InstructionHex { get; private set; }
        public static bool FlagRecord { get; private set; }

        // Método para compilar a instrução mnemônica.
        public static string Compile(string line)
        {
            // Analisa a linha lida atualmente.
            Decode.Analyse(line);
            string instrucaoHex = Decode.InstructionHex;

            return instrucaoHex;
        }

        // Método para obter instrução compilada.
        public static void Analyse(string line)
        {
            // Verifica se é o inicio ou fim.
            if (line == "inicio:" || line == "fim.") {
                FlagRecord = false;         // Desabilita a exibicao e gravacao da instrucao hexadecimal.
                return; 
            }

            line = Regex.Replace(line, @";", String.Empty);     // Substitui o ';' por ''.

            // Verifica se a linha é operação ou atribuição.
            if (line.Contains("="))       // Atribuição.
            {
                CutInstruction(line);
                FlagRecord = false;
            }
            else                           // Operação.
            {
                CutOperation(line);
                FlagRecord = true;
            }

            // Constrói a instrução hexadecimal.
            BuildInstruction();
        }

        public static void CutInstruction(string linha)
        {
            string[] caracteres = linha.Split('=');
            if (caracteres[0] == "X")
                X = caracteres[1];
            else
                Y = caracteres[1];
        }

        public static void CutOperation(string linha)
        {
            switch (linha)
            {
                case "An":
                    W = "0";
                    break;
                case "nAoB":
                    W = "1";
                    break;
                case "AnB":
                    W = "2";
                    break;
                case "zeroL":
                    W = "3";
                    break;
                case "nAeB":
                    W = "4";
                    break;
                case "Bn":
                    W = "5";
                    break;
                case "AxB":
                    W = "6";
                    break;
                case "ABn":
                    W = "7";
                    break;
                case "AnoB":
                    W = "8";
                    break;
                case "nAxB":
                    W = "9";
                    break;
                case "B":
                    W = "A";
                    break;
                case "AB":
                    W = "B";
                    break;
                case "umL":
                    W = "C";
                    break;
                case "AoBn":
                    W = "D";
                    break;
                case "AoB":
                    W = "E";
                    break;
                case "A":
                    W = "F";
                    break;
                default:
                    break;
            }
        }

        private static void BuildInstruction()
        {
            InstructionHex = X + Y + W;
        }
    }
}

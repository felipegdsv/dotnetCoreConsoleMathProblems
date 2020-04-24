using System;
using Operations.Factorial;
using Operations.Basic;

namespace MathProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            string result = "Start";
            while (result != "Exit")
            {
                result = SelectCalculationMethod();
                Console.WriteLine(result);
            }
        }

        private static string SelectCalculationMethod()
        {
            string result = string.Empty;
            
            DisplayIntroMessage();

            int CalcType = Convert.ToInt32(Console.ReadLine());

            switch (CalcType)
            {
                case 0:
                    result = "Exit";
                    break;
                case 1:
                    result = new Factorial().Calculate();
                    break;
                case 2:
                    result = new Basic().Addition();
                    break;
                case 3:
                    result = new Basic().Subtraction();
                    break;
                case 4:
                    result = new Basic().Multiplication();
                    break;
                case 5:
                    result = new Basic().Division();
                    break;
                default:
                    result = "Erro";
                    break;
            }

            return result;
        }

        private static void DisplayIntroMessage()
        {
            Console.WriteLine("Digite o codigo da operação de deseja executar");
            Console.WriteLine("1 // Fatorial"     );
            Console.WriteLine("2 // Soma"         );
            Console.WriteLine("3 // Subtração"    );
            Console.WriteLine("4 // Multiplicação");
            Console.WriteLine("5 // Divisão"      );
            Console.WriteLine("0 // Sair"         );
        }
    }
}

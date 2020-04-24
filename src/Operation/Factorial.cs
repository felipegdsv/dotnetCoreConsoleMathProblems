using System;

namespace Operations.Factorial
{
    public class Factorial
    {
        public Factorial() { }  

        public string Calculate()
        {    
            Console.WriteLine("Digite um numero para calcular fatorial: ");
            int number = Convert.ToInt32(Console.ReadLine()); 
            int result = 1;

            if(number == 0) return number.ToString();
            else
            {
                for(int i = number; i > 0; i--)
                {
                    result = result * i;
                }
            }

            return $"{number}! = {result}";
        }
    }
}
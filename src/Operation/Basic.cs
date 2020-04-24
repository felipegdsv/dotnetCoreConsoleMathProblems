using System;

namespace Operations.Basic
{
    public class Basic
    {
        public Basic() { }  
        
        public string Addition()
        {    
            Console.WriteLine("Digite primeiro numero para calcular soma: ");
            int number1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Digite segundo numero para calcular soma: ");
            int number2 = Convert.ToInt32(Console.ReadLine()); 
            
            int result = number1 + number2;

            return $"{number1} + {number2} = {result}";
        }

        public string Subtraction()
        {    
            Console.WriteLine("Digite primeiro numero para calcular subtração : ");
            int number1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Digite segundo numero para calcular subtração: ");
            int number2 = Convert.ToInt32(Console.ReadLine()); 
            
            int result = number1 - number2;

            return $"{number1} - {number2} = {result}";
        }
        
        public string Multiplication()
        {    
            Console.WriteLine("Digite primeiro numero para calcular multiplicação : ");
            int number1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Digite segundo numero para calcular divisão: ");
            int number2 = Convert.ToInt32(Console.ReadLine()); 
            
            int result = number1 * number2;

            return $"{number1} X {number2} = {result}";
        }

        public string Division()
        {    
            Console.WriteLine("Digite primeiro numero para calcular divisão : ");
            int number1 = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Digite segundo numero para calcular divisão: ");
            int number2 = Convert.ToInt32(Console.ReadLine()); 
            
            int result = number1 / number2;

            return $"{number1} / {number2} = {result}";
        }
    }
}
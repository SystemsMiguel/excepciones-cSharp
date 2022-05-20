using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Ingrese un numero: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Ingrese otro numero: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
                Console.ReadKey();
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e) 
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}

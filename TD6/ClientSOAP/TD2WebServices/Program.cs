using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TD2WebServices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Tests du seveur SOAP
            //Appuyer sur la toucher ENTER pour passer à l'opéaration suivante
            ServiceReference2.MathsOperationsClient calculator = new ServiceReference2.MathsOperationsClient();

            int res = calculator.Add(3, 2);
            Console.WriteLine("Calcul de 3 + 2 :");
            Console.WriteLine(res);
            Console.ReadKey();

            res = calculator.Substract(3, 2);
            Console.WriteLine("Calcul de 3 - 2 :");
            Console.WriteLine(res);
            Console.ReadKey();

            res = calculator.Multiply(3, 2);
            Console.WriteLine("Calcul de 3 * 2 :");
            Console.WriteLine(res);
            Console.ReadKey();

            float res2 = calculator.Divide(3.0f, 2.0f);
            Console.WriteLine("Calcul de 3 / 2 :");
            Console.WriteLine(res2);
            Console.ReadKey();
        }
    }
}

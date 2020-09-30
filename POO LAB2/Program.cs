using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_LAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion,n1,n2;
           

                Console.WriteLine("Digite operacion a realizar");
                Console.WriteLine("1: Suma");
                Console.WriteLine("2: Resta");
              
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite primer numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Digite segundo numero: ");
                n2 = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        int resultado = Operacion.Sumar(n1, n2);
                        Console.WriteLine("El resultado de la suma es: " + resultado);
                        break;
                    case 2:
                        int resultado2 = Operacion.Restar(n1, n2);
                        Console.WriteLine("El resultado de la resta es: " + resultado2);
                        break;
                    case 3:
                        Console.WriteLine("Gracias!..");
                        break;
                }
                
            
            Console.ReadKey();
        }
    }
}

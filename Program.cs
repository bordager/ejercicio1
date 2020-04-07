using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI
{
    class Ejercicio_1
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su numero de registro");
            String registro;
            registro = Console.ReadLine();
            registro = registro.Substring(registro.Length - 3, 3);
            int numeroreg = int.Parse(registro);
            
            for (int i = 1; i < numeroreg + 1; i++)
            {

                if (i % 3 == 0 && i % 5 == 0)
                   {
                    Console.WriteLine(i + "- FooBar");
                    }
                
                else if (i % 3 == 0)
                    {
                    Console.WriteLine(i + "- Foo");
                    }

                else if (i % 5 == 0)
                {
                    Console.WriteLine(i + "- Bar");
                }

                else
                    {
                    Console.WriteLine(i);
                    }
            }
            Console.Read();

        }
    
    
    }


}

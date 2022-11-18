using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJERCICIO78
{
    class Program
    {
        static void Main(string[] args)
        {

            Hashtable diccio = new Hashtable();

            diccio.Add("uno", "one");
            diccio.Add("dos", "two");
            diccio.Add("tres", "three");
            diccio.Add("cuatro", "four");
            diccio["cinco"] = "five";
            diccio["seis"] = "six";
            diccio["siete"] = "seven";
            diccio["ocho"] = "eight";
            diccio["nueve"] = "nine";
            diccio["diez"] = "ten";

            string numero;
            Console.WriteLine("Traductor de numeros de inlgés del 1 al 10");
            Console.WriteLine("Ingrese un numero:");
            numero = Console.ReadLine();

            while (numero != "salir")
            {
                Console.WriteLine("La traduccion del numero es:");
                Console.WriteLine(diccio[numero]);
                Console.WriteLine("Ingrese otro numero o ingrese ¨salir¨ para salir:");
                numero = Console.ReadLine();
            }
        }
    }
}
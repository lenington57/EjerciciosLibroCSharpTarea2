using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjerciciosLibroCSharpTarea2.Capítulo_8
{
    public class Ejercicios3_5
    {
        public void OchoTres()
        {
            DateTime miTiempo = DateTime.Now;
            String format;
            format = String.Format("La hora es: {0:h:mm:ss tt}", miTiempo);
            String formato;
            formato = String.Format("La fecha es: {0:dddd yyyy M}",DateTime.Now);
            Console.WriteLine(format);
            Console.WriteLine(formato);
        }

        public void OchoCinco()
        {
            string cad1, cad2;
            Console.WriteLine("Escriba la primera cadena: ");
            cad1 = Console.ReadLine();
            Console.WriteLine("Escriba la segunda cadena: ");
            cad2 = Console.ReadLine();
            int comparacion = 0;
            comparacion = String.Compare(cad1,cad2);
            if (comparacion == 0)
                Console.WriteLine("\nOrden de las cadenas: \n{0} \n{1}", cad1, cad2);
            else if (comparacion > 0)
                Console.WriteLine("\nOrden de las cadenas: \n{0} \n{1}", cad2, cad1);
            else if (comparacion < 0)
                Console.WriteLine("\nOrden de las cadenas: \n{0} \n{1}", cad1, cad2);

        }
    }
}

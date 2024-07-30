using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Clases29_07_2024
{
    internal class Program
    {
        /*Clases y objetos
        Es una plantilla o molde que se utiliza para representar propiedades y métodos
        Propiedades--> Son las caracteristicas principales de un objeto, las represento a 
        través de variables.
        
        Métodos-> Son las acciones principales que realiza el objeto para representar estas acciones
        utilizo los métodos

        Atributos-> 
        ¿Qué es declarar e inicializar una variable?
        Declarar-> Definir el tipo y el nombre
        Inicializar->cuando se le asigna un valor a la variable
         */


        static void Main(string[] args)
        {
            int n1 = 8;
            Console.WriteLine(n1);

            /*Pasos para crear un objeto
            1. Instanciar la clase : significa crear un objeto
            2. Colocar el nombre de la variable de tipo "Persona"
            3. Utilizar el operador de la asignación
            */

            Persona p = new Persona("Marce,",22,'M');

            //A través del operador '.' (punto) se puede visualizar los atributos y métodos que sean que tengan
            //el modificador public

            /*p.nombre = "Marcelo";*/
            Console.WriteLine(p.nombre);
            Console.Write("Escribe tu edad: ");

            //Desde la clase Persona
            p.edad = int.Parse(Console.ReadLine());
            p.mostrarInfo();

            p.mayorMenorEdad ();

            //desde la clase principal
            Console.WriteLine($"La edad 2° es {p.edad2}");
            if (p.edad2 >= 18)
            {
                Console.WriteLine("Es MAYOR de edad");
            }else
            {
                Console.WriteLine("Es MENOR de edad");
            }

            Persona p1 = new Persona("Marce,", 22, 'M');
            /*p1.edad = 25;
            Console.WriteLine($"La edad es {p1.edad} ");*/

            p1.mayorMenorEdad();

            Console.ReadKey();

            //Exponer tecnicas de estudio que yo utilizo. Con presentación.
        }

    }
}

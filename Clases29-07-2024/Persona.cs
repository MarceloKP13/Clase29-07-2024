using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases29_07_2024
{
    public class Persona
    { //llave de inicio de la clase
        /*Creando un atributo
         * La sintaxis para crear un atributo es:
         * 1. modificador de acceso: Define si el atributo es accesible o no fuera de la clase
         * 2. tipo de dato
         * 3. nombre del atributo
         * 4. colocar ';'
         */

        public string nombre;
        public int edad;
        public int edad2 = 15;
        public char genero = 'M';

        /* Métodos
        Son las acciones principales que realiza el objeto
        Sintaxis:
        1. Modificador de acceso
        2. colocar void: No recibe ni devuleve ningun parametro


        Método constructor
        El constructo es un método especial que se utiliza para inicializar los atributos de la clase
        Sintaxis:

        1. 
         */

        public Persona(string nombre, int edad, char genero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.genero = genero;
        }

        public void mostrarInfo()
        {
            Console.WriteLine($"Hola {nombre}, tienes {edad} y tu género es {genero}");
            if (edad >= 18)
            {
                Console.WriteLine($"Tienes {edad} y eres MAYOR de edad");
            }
            else
            {
                Console.WriteLine($"Tienes {edad} y eres MENOR de edad");
            }

        } //llave de cierre de la clase

        public void mayorMenorEdad()
        {
            if (edad >= 18)
            {
                Console.WriteLine("Es MAYOR de edad->metodo2");
            }
            else
            {
                Console.WriteLine("Es MENOR de edad->metodo2");
            }
        }
    }
}

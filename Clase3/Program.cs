using Clase3.Ejercicio_1;
using Clase3.Ejercicio_2;

namespace Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1


            // Crear clase Vehiculo con las siguientes propiedades: Marca, Modelo
            // Crear clase Moto que herede de Vehiculo  
            // Crear clase Auto que herede de Vehiculo

            //Modificar el metodo "ImprimirDatosVehiculo" para que pueda imprimir los datos del Vehiculo independientemente de que si es una moto o un auto 

            //Uso
            //ImprimirDatosVehiculo(moto);
            //ImprimirDatosVehiculo(auto);

            Auto auto = new Auto("Ford", "Focus");
            Moto moto = new Moto("Mondial", "LD110s");
            ImprimirDatosVehiculo(auto);
            ImprimirDatosVehiculo(moto);
            #endregion


            #region Ejercicio 2
            // Crear una interfaz que se llame IBiblioteca
            // Definir en la interfaz con una sola firma que indique que se va a obtener todos los libros
            // Implementar la interfaz en la clase biblioteca para que devuelva los libros
            // Instanciar y utilizar la clase biblioteca
            Console.WriteLine("--------------");

            Biblioteca biblioteca = new Biblioteca();
            Console.WriteLine("Libros de la biblioteca: ");
            foreach (string libro in biblioteca.ObtenerTodosLosLibros())
            {
                Console.WriteLine("Se ha encontrado: " + libro + ".");
            }
            #endregion
        }

        static void ImprimirDatosVehiculo(Vehiculo v) 
        {
            Console.WriteLine("Vehiculo nuevo! Marca: " + v.Marca + ", Modelo: " + v.Modelo);
        }


    }
}
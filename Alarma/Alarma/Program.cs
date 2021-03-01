using System;

namespace Alarma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea un objeto tipo alarma, objeto aplazar y apagar
            AlarmaContexto objAlarma = new AlarmaContexto();
            AplazarState objAplazar = new AplazarState();
            ApagarState objApagar = new ApagarState();

            //se crea una variable opción 
            int opcion = 0;
            /*Se crea un ciclo en el que se llama al método mostrarMenu
             se guarda la opción escogida por el usuario
             luego se implementa un switch*/
            do
            {
                mostrarMenu();
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        objAlarma.setState(objApagar); // el objeto alarma se le asigna el estado apagado
                        break; 
                    case 2:
                        objAlarma.setState(objAplazar); // el objeto alarma se le asigna el estado de aplazar
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta");
                        break;
                }
                objAlarma.EjecutarAccion(); //El objeto de Alarma contexto ejecuta la acción y el estado asignado realiza la acción

            } while (opcion != 0);

        }
       
        public static void mostrarMenu() //Método para mostrar el menú de opciones al usuario
        {
            Console.WriteLine("*************************************************************");
            Console.WriteLine("\tAlarma se encuentra Activa, Seleccione una opción");
            Console.WriteLine("\n\tSi desea apagar la alarma presione 1\n");
            Console.WriteLine("\n\tSi desea aplazarla la alarma presione 2\n");
            Console.WriteLine("*************************************************************");

        }

    }
}

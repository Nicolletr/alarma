using System;
using System.Collections.Generic;
using System.Text;

namespace Alarma
{
    // clase apagar que hereda del estado de la alarma
    public class ApagarState: AlarmaState
    {
        //se implementa una clase abstracta
        public override void EjecutarAccion()
        {
            Console.WriteLine("\nLa alarma se apagó éxitosamente"); //respende al usuario que la alarma se ha detenido.
        }
    }
}
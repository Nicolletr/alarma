using System;
using System.Collections.Generic;
using System.Text;


namespace Alarma
{
    // clase aplazar que hereda del estado de la alarma
    public class AplazarState:AlarmaState
    {
        //se implementa una clase abstracta
        public override void EjecutarAccion()
        {
            Console.WriteLine("\nSe ha aplazado la alarma 5 minutos");//Responde al usuario el tiempo que se aplazó la alarma
        }
    }
}
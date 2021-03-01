using System;
using System.Collections.Generic;
using System.Text;

namespace Alarma
{
    public class AlarmaContexto
    {
        // el contexto recibe como parámetro el estado en que se encuentra.
        private AlarmaState State; 

        public void setState(AlarmaState e) //Método setState que recibe como parámetro un objeto de tipo estado.
        {
            this.State = e; //Se lo asigna al atributo State.
        }

        //Método de ejecutar acción que llama a método de ejecutar acción del estado que ha recibido antes

        public void EjecutarAccion()
        {
            State.EjecutarAccion();
        }
    }
}
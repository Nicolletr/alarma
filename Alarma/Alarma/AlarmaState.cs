using System;
using System.Collections.Generic;
using System.Text;

namespace Alarma
{
    public abstract class AlarmaState //clase abstracta del estado
    {
        //Método abstracto Ejecutar Acción el cuál será sobreescrito por las clases concretas 
        public abstract void EjecutarAccion();
    }
}
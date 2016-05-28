using System;

namespace Logica.Negocio
{
    public class Multiplicacion
    {
        public double Operar(double operandoUno, double operandoDos)
        {
            double elResultado;
            elResultado = operandoUno * operandoDos;
            return (elResultado);
        }
    }
}
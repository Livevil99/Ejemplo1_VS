using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOU2D_Ejemplo1_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciar un objeto
            //tipoDeClase nombreObjeto = new   tipoDeClase();
            Calculadora operacion = new Calculadora();

            operacion.SumaNumeroUno = 90;
            int resultadoDevuelo = operacion.SumaNumeroUno;
            //Acceder a un segundo mimebro
            operacion.NumeroDosEscritura = 50;
            Console.WriteLine("Segunda propiead {0}", operacion.NumeroDosLectura);

            Console.WriteLine(resultadoDevuelo);

            Console.ReadKey();
        }
    } 
}

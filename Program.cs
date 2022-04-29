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
            #region OLDCODE;
            // //Instanciar un objeto
            // //tipoDeClase nombreObjeto = new   tipoDeClase();                    

            // // Crear un objeto de clase Alumno
            // Alumno objetoUno = new Alumno("Adrián Pedro","Ortiz", Convert.ToDateTime( "04-04-2022"));//llmar el constructor
            //// objetoUno.NombreAlumno = "Ezequiel";
            // Console.WriteLine("El alumno es: {0}", objetoUno.NombreAlumno);
            // objetoUno.FechaNacimiento = Convert.ToDateTime("07-12-2003");
            // Console.WriteLine(objetoUno.CalcularEdadAlumno1());           
            // Console.WriteLine("\n");
            // //
            // Alumno objetoDos = new Alumno("Yolanda Elizabth","Zapata", DateTime.Now);
            //// objetoDos.NombreAlumno = "Yolanda";
            // Console.WriteLine("El alumno es: {0}", objetoDos.NombreAlumno);
            // Console.WriteLine(objetoDos.CalcularEdadAlumno1());
            // //if (objetoDos.CalcularEdadAlumno()==0)
            // //{
            // //    Console.WriteLine("Edad no asignada");
            // //}
            // //objetoDos.FechaNacimiento = Convert.ToDateTime( "26-09-2003 07:30:21");


            // Console.WriteLine("\n");
            // //Nuevo objeto
            // Alumno objetoTres = new Alumno("Evelin Michel","Chávez", Convert.ToDateTime("03-04-2022"));
            // //objetoTres.NombreAlumno = "Evelin";
            // Console.WriteLine("El alumno es: {0}", objetoTres.NombreAlumno);
            //// objetoTres.FechaNacimiento = Convert.ToDateTime("13-02-1956 07:30:21");
            // Console.WriteLine(objetoTres.CalcularEdadAlumno2(Convert.ToDateTime( "13-02-2002")));
            // Console.WriteLine(objetoTres.FechaNacimiento);
            #endregion;

            // Crear un objeto (instanciar)
            Alumno alumno1 = new Alumno("Daniela Ailyn", "Rodriguez", "Diaz", Convert.ToDateTime("25 - 06 - 2021"), Convert.ToDateTime("25 - 06 - 2003"));
            Alumno alumno2 = new Alumno("Amador", "Rivera", "Martinez", Convert.ToDateTime("25 - 06 - 2021"), Convert.ToDateTime("25 - 06 - 2004"));
            Alumno alumno3 = new Alumno("Ezequiel", "Sandoval", "Martinez",Convert.ToDateTime("25 - 06 - 2021"), Convert.ToDateTime("25 - 06 - 2003"));
            Alumno alumno4 = new Alumno("Yolanda Elizabeth", "Zapata", "Gonzales", Convert.ToDateTime("25 - 06 - 2021"), Convert.ToDateTime("25 - 06 - 2003"));
            Alumno alumno5 = new Alumno("Sonia", "Huerta", "Carrillo",Convert.ToDateTime("25 - 06 - 2021"), Convert.ToDateTime("25 - 06 - 2003"));
            Alumno alumno6 = new Alumno("Alfonso", "Vargas", "Hernandez",Convert.ToDateTime("25 - 06 - 2021"), Convert.ToDateTime("25 - 06 - 2003"));

            // Mandar llamar algun miembro no importa el orden en llamarlos 
            Console.WriteLine(alumno1.CalcularEdadAlumno1());
            Console.WriteLine(alumno2.CalcularEdadAlumno1());
            Console.WriteLine(alumno3.CalcularEdadAlumno1());
            Console.WriteLine(alumno4.CalcularEdadAlumno1());
            Console.WriteLine(alumno5.CalcularEdadAlumno1());
            Console.WriteLine(alumno6.CalcularEdadAlumno1());
            
            Console.ReadKey();
        }
    } 
}

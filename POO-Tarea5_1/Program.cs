using POO_Tarea5_1.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Poo_tarea5_1

internal class Program
{
    static void Main(string[] args)
    {

        Persona persona= new Persona ();

        persona.setNombre("Marcos");

        Console.WriteLine(persona.getNombre());

        Console.ReadLine ();
    }
}

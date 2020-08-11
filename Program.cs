using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionDatosEntrada
{
    class Program
    {
        static void Main(string[] args)
        {
            //Descargar de nuget "fluentvalidation" version 8.6.2
            Persona p = new Persona() { 
             Name=null,
             LastName="Gonzalez",
             Edad=14             
            };
            PersonaValidator validator = new PersonaValidator();
            var results = validator.Validate(p);
            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    Console.WriteLine(item);
                }                
            }
            Console.WriteLine("Terminado");
            Console.ReadLine();

        }
    }
}

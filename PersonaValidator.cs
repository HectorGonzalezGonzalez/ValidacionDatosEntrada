using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidacionDatosEntrada
{
   public class PersonaValidator:AbstractValidator<Persona>
    {
        public PersonaValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ingrese el nombre");
            RuleFor(x => x.LastName).Length(3,20).WithMessage("La longitud del apallido debe de estar de 3 a 20 caracteres");
            RuleFor(x => x.Edad).ExclusiveBetween(1, 100).WithMessage("La edad no es valida");
            //===validacion personalizado====
            RuleFor(x => x.Edad).Must(edad=>edad>18).WithMessage("El alumno no es mayor de dedad");//validacion perzonalizada con un predicado
            RuleFor(x => x.Edad).Must(validarPersonalizado).WithMessage("El alumno no es mayor de dedad v2");//validacion perzonalizada con un metodo
        }
        public Boolean validarPersonalizado(int edad)
        {            
            return edad>18;
        }
    }
}
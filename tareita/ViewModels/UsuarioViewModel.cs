using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Practices.Binding.Models;
namespace WPF.Practices.Binding.ViewModels
{
    public class UsuarioViewModel
    {
        public UsuarioViewModel()
        {
            Escuela = new Escuela();
            Escuela.Nombre = "san nicolas";
            Escuela.Personas = ObtenerAlumnos();
        }
        public Escuela Escuela { get; set; }

        public List<Persona> ObtenerAlumnos()
        {
            List<Persona> personas = new List<Persona>();

            for (int i = 0; i < 20; i++)
            {
                Persona persona = new Persona();
                persona.Nombre = "jorge" + i;
                persona.Apellido = "maza" + i;
                persona.Identificador = Guid.NewGuid().ToString();
                personas.Add(persona);
            }
            return personas;
        }

    }
}


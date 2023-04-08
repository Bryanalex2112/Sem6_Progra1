using Arreglos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos.Negocio
{
    public class ClsEstudiante
    {
        List<Estudiante>Estudiantes = new List<Estudiante>();

        public void AgregarEstudante(Estudiante est)
        {
            Estudiantes.Add(est);
        }
        public List<Estudiante> ListadoEstudiante()
        {
            return Estudiantes;
        } 
    }
}

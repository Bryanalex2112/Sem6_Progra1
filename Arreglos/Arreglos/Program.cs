// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using Arreglos.Entidades;
using Arreglos.Negocio;

Estudiante estudiante = new Estudiante();   
ClsEstudiante clsEstudiante = new ClsEstudiante();

estudiante.Nombre = "Brayan";
estudiante.Apellido = "Alvarado";
estudiante.Edad = 20;
estudiante.Dui = "06385841-2";

clsEstudiante.AgregarEstudante(estudiante);

foreach (var mostrar in clsEstudiante.ListadoEstudiante())
{
    Console.WriteLine($"nombre->{ mostrar.Nombre}, apellido->{ mostrar.Apellido}, edad->{mostrar. Edad}, Dui->{mostrar.Dui}");

    Console.WriteLine("nombre->"+mostrar.Nombre +", apellido->"+ mostrar.Apellido + ", edad->"+mostrar.Edad+", Dui->"+mostrar.Dui);
}
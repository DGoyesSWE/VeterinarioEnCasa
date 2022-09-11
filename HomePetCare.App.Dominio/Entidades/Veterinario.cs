using System;
namespace HomePetCare.App.Dominio
{
    public class Veterinario : Persona
    {
        public string TargetaProfesional {get;set;}
        //Relacion de agregacion
        public Visita[] Visitas {get;set;}
        //Relacion de asociación
        public Gato atiende {get;set;}
    }
}
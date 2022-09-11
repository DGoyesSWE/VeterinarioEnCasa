using System;
namespace HomePetCare.App.Dominio
{
    public class Propietario : Persona
    {
        public string Direccion {get;set;}
        //Relacion de asociacion
        public Gato Duenio {get;set;}
    }
}
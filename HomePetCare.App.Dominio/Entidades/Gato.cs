using System;
namespace HomePetCare.App.Dominio
{
    public class Gato
    {
        public string Id {get;set;}
        public string Nombres {get;set;}
        public string Raza {get;set;}
        public int Edad {get;set;}
        public string Color {get;set;}
        //Relacion de composicion
        public Visita[] Visitas {get;set;}
        ///List<Visita> visitas
    }
}
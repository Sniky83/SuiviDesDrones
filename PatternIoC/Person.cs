using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIoC
{
    internal class Person
    {
        private IMoyenDeDeplacement moyenDeDeplacement;
        public Person(string prenom, IMoyenDeDeplacement moyenDeDeplacement/*Velo velo, Bus bus*/)
        {
            Prenom = prenom;
            this.moyenDeDeplacement = moyenDeDeplacement;
            //this.velo = velo;
            //this.bus = bus;
        }

        public void AllerAuTravail(Destination destination)
        {
            Console.WriteLine($"{Prenom}, je vais ici : {destination.Address}");
            //this.velo.Emmener(this, destination);
            //this.bus.Emmener(this, destination);
            this.moyenDeDeplacement.Emmener(this, destination);
        }

        public string Prenom { get; set; }
    }
}

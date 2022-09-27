using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIoC
{
    internal class Velo : IMoyenDeDeplacement
    {
        public void Emmener(Person person, Destination destination)
        {
            Console.WriteLine($"Moi vélo, j'emmène la personne {person.Prenom} ici : {destination.Address}");
        }
    }
}

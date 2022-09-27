using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIoC
{
    internal interface IMoyenDeDeplacement
    {
        void Emmener(Person person, Destination destination);
    }
}

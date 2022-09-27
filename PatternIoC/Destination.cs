using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternIoC
{
    internal class Destination
    {
        public Destination(string address)
        {
            Address = address;
        }

        public string Address { get; set; }
    }
}

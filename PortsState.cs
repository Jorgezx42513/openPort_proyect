using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenPort
{
    internal class PortsState : consoleExeCommand
    {
        public bool MySQL { get; set; }
        public bool php { get; set; }
        public bool apache { get; set; }
    }
}

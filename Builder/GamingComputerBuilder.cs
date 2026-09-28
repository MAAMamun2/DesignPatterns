using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class GamingComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();
        public void BuildCPU()
        {
            _computer.CPU = "High-End CPU";
        }

        public void BuildRAM()
        {
            _computer.RAM = "32GB";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class OfficeComputerBuilder : IComputerBuilder
    {
        private Computer _computer = new Computer();
        public void BuildCPU()
        {

            _computer.CPU = "Mid-Range CPU";
        }

        public void BuildRAM()
        {
            _computer.RAM = "16GB";
        }

        public Computer GetComputer()
        {
            return _computer;
        }
    }
}

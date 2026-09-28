using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IComputerBuilder
    {
        void BuildCPU();
        void BuildRAM();
        Computer GetComputer();
    }
}

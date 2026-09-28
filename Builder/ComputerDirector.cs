using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ComputerDirector
    {
        private readonly IComputerBuilder _builder;

        public ComputerDirector(IComputerBuilder builder)
        {
            _builder = builder;
        }
        public void ConstructComputer()
        {
            _builder.BuildCPU();
            _builder.BuildRAM();
        }
        public Computer GetComputer()
        {
            return _builder.GetComputer();
        }
    }
}

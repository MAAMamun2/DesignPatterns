using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Computer
    {
        public string CPU { get; set; }
        public string RAM { get; set; }

        public override string ToString()
        {
            return $"CPU: {CPU}, RAM: {RAM}";
        }
    }
}

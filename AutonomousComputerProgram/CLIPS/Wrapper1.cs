using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CLIPSNet;

namespace AutonomousComputerProgram.Clips
{
    public abstract class Wrapper
    {
        public override bool Equals(object obj) { return (true); }
        public override int GetHashCode() { return (1); }
        protected Wrapper() { }
        private System.IntPtr rawPtr;
    }
}

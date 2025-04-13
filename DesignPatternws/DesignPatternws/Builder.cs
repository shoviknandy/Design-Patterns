using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternws
{
    public class VirtualMachine
    {
        public string VMName;
        public string CPU;
        public string GPU;

        public string RAM;

        public void GetConfigDetails()
        {
            Console.WriteLine($"VM Created : Name {VMName}, CPU : {CPU}, GPU : {GPU}, RAM : {RAM} GB");
        }
    }
    class Builder
    {
        private VirtualMachine _VM=new VirtualMachine();
         public Builder setName(string Name)
         {
            _VM.VMName = Name;
            return this;
         }
        public Builder setCPU(string CPU)
        {
            _VM.CPU = CPU;
            return this;
        }
        public Builder setGPU(string GPU)
        {
            _VM.GPU = GPU;
            return this;
        }
        public Builder setRam(string RAM)
        {
            _VM.RAM = RAM;
            return this;
        }
         public VirtualMachine Build()
        {
            return _VM;
        }
    }
}

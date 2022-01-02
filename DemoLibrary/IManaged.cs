using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    //Any class implementing IManaged will get IEmployee properties which obviously means the class can be "managed"
    //IManaged can be used to new up new employee and manager objects
    public interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; }
        void AssignManager(IEmployee manager);
    }
}

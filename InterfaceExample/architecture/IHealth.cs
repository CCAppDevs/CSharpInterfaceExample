using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.architecture
{
    public interface IHealth
    {
        int MaxHealth { get; set; }
        int Health { get; set; }

        bool IsAlive();
    }
}

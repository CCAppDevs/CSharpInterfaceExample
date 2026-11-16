using InterfaceExample.actors;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.architecture
{
    public interface IHurt
    {
        bool TakeDamage(Actor source, int amount);
    }
}

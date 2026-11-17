using InterfaceExample.actors;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.architecture
{
    public interface IHurtBox
    {
        // does the damage
        bool DealDamage(IHitBox target, int amount);
    }
}

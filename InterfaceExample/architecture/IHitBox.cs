using InterfaceExample.actors;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.architecture
{
    public interface IHitBox
    {
        bool ApplyDamage(IHurtBox source, int amount);
    }
}

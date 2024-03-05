using System;
using System.Collections.Generic;
using System.Text;

namespace Console_RPG
{
    abstract class LocationEvent
    {
        public bool isResolved;

        public LocationEvent(bool isResolved)
        {
            this.isResolved = isResolved;
        }
        public abstract void Resolve(List<Player> player, List<Ally> allies);
    }
}

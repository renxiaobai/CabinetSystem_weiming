using System.Collections.Generic;
using System.Linq;
using CabinetSystem;

namespace CabinetSystemTest
{
    public class Manager:ICabinetOperation
    {
        private readonly List<ICabinetOperation> _managedStuffs;

        public Manager()
        {
            _managedStuffs = new List<ICabinetOperation>();
        }

        public Ticket Store(Bag aBag)
        {
            throw new System.NotImplementedException();
        }

        public Bag Pick(Ticket ticket)
        {
            throw new System.NotImplementedException();
        }

        public bool HasEmptyBox()
        {
            if (_managedStuffs.Count == 0)
                return false;

            return _managedStuffs.Any(holder => holder.HasEmptyBox());
        }

        public void Add(ICabinetOperation bagHolder)
        {
            _managedStuffs.Add(bagHolder);
        }
    }
}
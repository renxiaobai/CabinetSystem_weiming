using System;
using System.Collections.Generic;
using CabinetSystem;

namespace CabinetSystemTest
{
    public class Robot
    {
        public bool HasEmptybox()
        {
            foreach (var cabinet in cabinetList)
            {
                if (cabinet.HasEmptyBox())
                    return true;
            }

            return false;
        }

        public void Add(Cabinet cabinet)
        {
            cabinetList.Add(cabinet);
        }

        private List<Cabinet> cabinetList = new List<Cabinet>();

        public Ticket Store(Bag bag)
        {
            foreach (var cabinet in cabinetList)
            {
                if (cabinet.HasEmptyBox())
                {
                    var ticket = cabinet.Store(bag,"Robot");
                    return ticket;
                }
                
            }
            return null;
        }

        public Bag pick(Ticket ticket)
        {
            Bag bag = null;
            foreach (var cabinet in cabinetList)
            {
                try
                {
                    bag = cabinet.Pick(ticket,"Robot");
                }
                catch (Exception)
                {
                    
                   continue;
                }
  
                if (bag!=null)
                {
                    return bag;
                }

            }
            return bag;
        }
    }
}
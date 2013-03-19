using System;
using System.Collections.Generic;

namespace CabinetSystem
{
    public class Robot
    {
        private const string TicketCreater = "Robot";
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

        private readonly List<Cabinet> cabinetList = new List<Cabinet>();

        public Ticket Store(Bag bag)
        {
            foreach (var cabinet in cabinetList)
            {
                if (cabinet.HasEmptyBox())
                {
                    var ticket = cabinet.Store(bag, TicketCreater);
                    return ticket;
                }
            }
            return null;
        }

        public Bag Pick(Ticket ticket)
        {
            foreach (var cabinet in cabinetList)
            {
                var bag = cabinet.Pick(ticket, TicketCreater);
                if (bag!=null)
                    return bag;

            }
            return null;
        }
    }
}
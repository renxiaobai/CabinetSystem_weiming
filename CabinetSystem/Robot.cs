using System;
using System.Collections.Generic;
using System.Linq;

namespace CabinetSystem
{
    public class Robot : ICabinetOperation
    {
        private const string TicketCreater = "Robot";
        public bool HasEmptyBox()
        {
            return cabinetList.Any(cabinet => cabinet.HasEmptyBox());
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
                    var ticket1 = Ticket.CreateTicket(TicketCreater);
                    return cabinet.Store(bag, ticket1);;
                }
            }
            return null;
        }

        public Bag Pick(Ticket ticket)
        {
            foreach (var cabinet in cabinetList)
            {
                if (Ticket.IsValidateTicket(ticket, TicketCreater))
                    continue;

                var bag = cabinet.Pick(ticket);

                if (bag!=null)
                    return bag;

            }
            return null;
        }


    }
}
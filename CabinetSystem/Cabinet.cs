using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabinetSystem
{
    public class Cabinet
    {
        private const string TicketCreater = "Cabinet";
        private readonly Dictionary<Ticket, Bag> _dicTicketBag = new Dictionary<Ticket, Bag>();
        private readonly int _capacity; 

        public Cabinet(int capacity)
        {
            _capacity = capacity;
        }

        public int EmptyuBoxCount
        {
            get { return _capacity - _dicTicketBag.Count; }

        }

        public bool HasEmptyBox()
        {
            return _dicTicketBag.Count < _capacity;
        }

        public Ticket Store(Bag aBag)
        {
            return Store(aBag, TicketCreater);
        }
        public Ticket Store(Bag aBag,string ticketCreater)
        {
            if (!HasEmptyBox()) return null;

            Ticket ticket = new Ticket();
            ticket.Creater = ticketCreater;
            _dicTicketBag.Add(ticket, aBag);
            return ticket;
        }
        public Bag Pick(Ticket ticket)
        {
            return Pick(ticket, TicketCreater);
        }
        public Bag Pick(Ticket ticket,string ticketCreater)
        {
            if (ticket.Creater != ticketCreater)
                return null;
            if (false == _dicTicketBag.ContainsKey(ticket))
                return null;

            var bag = _dicTicketBag[ticket];
            _dicTicketBag.Remove(ticket);
            return bag;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CabinetSystemTest;

namespace CabinetSystem
{
    public class Cabinet
    {
        private Dictionary<Ticket, Bag> _dicTicketBag = new Dictionary<Ticket, Bag>();
        private int _capacity; 

        public Cabinet(int capacity)
        {
            _capacity = capacity;
        }

        public bool HasEmptyBox()
        {
            return _dicTicketBag.Count < _capacity;
        }

        public Ticket Store(Bag aBag)
        {
            if (!HasEmptyBox()) return null;

            Ticket ticket = new Ticket();
            ticket.Creater = "Cabinet";
            _dicTicketBag.Add(ticket,aBag);
            return ticket;
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
            if(false == _dicTicketBag.ContainsKey(ticket))  
                throw  new InvalidOperationException();
            if (ticket.Creater != "Cabinet")
                return null;
            var bag = _dicTicketBag[ticket];
            _dicTicketBag.Remove(ticket);
            return bag;
        }
        public Bag Pick(Ticket ticket,string ticketCreater)
        {
            if (ticket.Creater != ticketCreater)
                return null;
            if (false == _dicTicketBag.ContainsKey(ticket))
                throw new InvalidOperationException();

            var bag = _dicTicketBag[ticket];
            _dicTicketBag.Remove(ticket);
            return bag;
        }
    }
}

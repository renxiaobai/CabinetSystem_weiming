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
            _dicTicketBag.Add(ticket,aBag);
            return ticket;
        }

        public Bag Pick(Ticket ticket)
        {
            if(false == _dicTicketBag.ContainsKey(ticket))  
                throw  new InvalidOperationException();

            var bag = _dicTicketBag[ticket];
            _dicTicketBag.Remove(ticket);
            return bag;
        }
    }
}

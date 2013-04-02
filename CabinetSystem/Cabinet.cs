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
        private readonly Direct direct;

        public Cabinet(int capacity)
        {
            _capacity = capacity;
            direct = new Direct(this);
        }

        public int EmptyuBoxCount
        {
            get { return _capacity - _dicTicketBag.Count; }

        }

        public Direct Direct
        {
            get { return direct; }
        }

        public bool HasEmptyBox()
        {
            return _dicTicketBag.Count < _capacity;
        }

        public Ticket Store(Bag aBag,string ticketCreater)
        {
            if (!HasEmptyBox()) return null;

            var ticket = CreateTicket(ticketCreater);
            _dicTicketBag.Add(ticket, aBag);
            return ticket;
        }

        private Ticket CreateTicket(string ticketCreater)
        {
            Ticket ticket = new Ticket();
            ticket.Creater = ticketCreater;
            return ticket;
        }

        public Bag Pick(Ticket ticket,string ticketCreater)
        {
            if (IsValidateTicket(ticket, ticketCreater)) return null;
            if (false == _dicTicketBag.ContainsKey(ticket))
                return null;

            var bag = _dicTicketBag[ticket];
            _dicTicketBag.Remove(ticket);
            return bag;
        }

        private bool IsValidateTicket(Ticket ticket, string ticketCreater)
        {
            if (ticket.Creater != ticketCreater)
                return true;
            return false;
        }
    }
}

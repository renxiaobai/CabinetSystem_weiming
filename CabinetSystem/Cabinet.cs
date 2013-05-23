using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CabinetSystem
{
    public class Cabinet:ICabinetOperation
    {
        private const string TicketCreater = "Cabinet";
        private readonly Dictionary<Ticket, Bag> _dicTicketBag = new Dictionary<Ticket, Bag>();
        public  readonly int _capacity;
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

        public Ticket Store(Bag aBag, Ticket ticket)
        {
            if (!HasEmptyBox()) return null;

            _dicTicketBag.Add(ticket, aBag);
            return ticket;
        }

        public Bag Pick(Ticket ticket,string ticketCreater)
        {
            if (Ticket.IsValidateTicket(ticket, ticketCreater)) return null;
            return Pick(ticket);
        }

        public Ticket Store(Bag aBag)
        {
            var ticket = new Ticket();
            return Store(aBag,ticket);
        }

        public Bag Pick(Ticket ticket)
        {
            if (false == _dicTicketBag.ContainsKey(ticket))
                return null;

            var bag = _dicTicketBag[ticket];
            _dicTicketBag.Remove(ticket);
            return bag;
        }
    }
}

using System.Collections.Generic;

namespace CabinetSystem
{
    public class BoxResource
    {
        private readonly Dictionary<Ticket, Bag> _dicTicketBag = new Dictionary<Ticket, Bag>();
        private readonly int _capacity;

        public BoxResource(int capacity)
        {
            _capacity = capacity;
        }

        public bool HasEmptyBox()
        {
            return _dicTicketBag.Count < _capacity;
        }
    }
}
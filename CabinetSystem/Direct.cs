namespace CabinetSystem
{
    public class Direct
    {
        private const string TicketCreater = "Cabinet";

        private Cabinet cabinet;

        public Direct(Cabinet cabinet)
        {
            this.cabinet = cabinet;
        }

        public Ticket Store(Bag aBag)
        {
            var ticket = Ticket.CreateTicket(TicketCreater);
            return cabinet.Store(aBag, ticket);
        }

        public Bag Pick(Ticket ticket)
        {
            return cabinet.Pick(ticket, TicketCreater);
        }

        public bool HasEmptyBox()
        {
            return cabinet.HasEmptyBox();
        }
    }
}
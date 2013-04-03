namespace CabinetSystem
{
    public class Direct : ICabinetOperation
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
            if (Ticket.IsValidateTicket(ticket, TicketCreater)) return null;
            return cabinet.Pick(ticket);
        }

        public bool HasEmptyBox()
        {
            return cabinet.HasEmptyBox();
        }
    }
}
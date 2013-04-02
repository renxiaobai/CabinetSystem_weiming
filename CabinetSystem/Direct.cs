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
            return cabinet.Store(aBag, TicketCreater);
        }

        public Bag Pick(Ticket ticket)
        {
            return cabinet.Pick(ticket, TicketCreater);
        }
    }
}
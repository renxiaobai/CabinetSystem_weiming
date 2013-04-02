namespace CabinetSystem
{
    public class Direct
    {
        private Cabinet cabinet;

        public Direct(Cabinet cabinet)
        {
            this.cabinet = cabinet;
        }

        public Ticket Store(Bag aBag)
        {
            return cabinet.Store(aBag, "Cabinet");
        }

        public Bag Pick(Ticket ticket)
        {
            return cabinet.Pick(ticket, "Cabinet");
        }
    }
}
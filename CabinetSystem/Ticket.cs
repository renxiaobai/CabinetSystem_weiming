namespace CabinetSystem
{
    public class Ticket
    {
        public bool IsUsed { get; set; }
        public string Creater { get; set; }
        public Ticket()
        {
            IsUsed = false;
        }

        public static Ticket CreateTicket(string ticketCreater)
        {
            Ticket ticket = new Ticket();
            ticket.Creater = ticketCreater;
            return ticket;
        }

        public static bool IsValidateTicket(Ticket ticket, string ticketCreater)
        {
            if (ticket.Creater != ticketCreater)
                return true;
            return false;
        }
    }
}
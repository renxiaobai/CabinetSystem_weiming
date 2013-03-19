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
    }
}
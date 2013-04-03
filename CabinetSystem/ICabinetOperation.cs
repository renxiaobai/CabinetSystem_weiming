namespace CabinetSystem
{
    public interface ICabinetOperation
    {
        Ticket Store(Bag aBag);
        Bag Pick(Ticket ticket);
        bool HasEmptyBox();
    }
}
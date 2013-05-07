using System.Collections.Generic;
using System.Linq;
using CabinetSystem;

namespace CabinetSystemTest
{
    public class SuperRobot:ICabinetOperation
    {
        private const string TicketCreater = "SuperRobot";
        private List<Cabinet> cabinetList;

        public SuperRobot()
        {
            cabinetList = new List<Cabinet>();
        }

        public void Add(Cabinet cabinet)
        {
            cabinetList.Add(cabinet);
        }

        public Ticket Store(Bag aBag)
        {
            double emptyBoxCountRate = 0;
            Cabinet cabinetWithMostEmptyBoxRate = null;
            foreach (var cabinet in cabinetList)
            {
                double emptyBoxRate = (double)cabinet.EmptyuBoxCount / (double)cabinet._capacity;
                if (emptyBoxRate > emptyBoxCountRate)
                {
                    emptyBoxCountRate = emptyBoxRate;
                    cabinetWithMostEmptyBoxRate = cabinet;
                }
            }
            if (cabinetWithMostEmptyBoxRate != null)
            {
                var ticket = Ticket.CreateTicket(TicketCreater);
                return cabinetWithMostEmptyBoxRate.Store(aBag, ticket);
            }
            return null;
        }

        public Bag Pick(Ticket ticket)
        {
            throw new System.NotImplementedException();
        }

        public bool HasEmptyBox()
        {
            return cabinetList.Any(cabinet => cabinet.HasEmptyBox());
        }
    }
}
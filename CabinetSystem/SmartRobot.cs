using System.Collections.Generic;
using System.Linq;
using CabinetSystem;

namespace CabinetSystem
{
    public class SmartRobot
    {
        private List<Cabinet> cabinetList;

        public SmartRobot()
        {
            cabinetList = new List<Cabinet>();
        }

        public void Add(Cabinet cabinet)
        {
            cabinetList.Add(cabinet);
        }

        public bool HasEmptybox()
        {
            return cabinetList.Any(cabinet => cabinet.HasEmptyBox());
        }
    }
}
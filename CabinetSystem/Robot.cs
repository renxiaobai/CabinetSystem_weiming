using System.Collections.Generic;
using CabinetSystem;

namespace CabinetSystemTest
{
    public class Robot
    {
        public bool HasEmptybox()
        {
            foreach (var cabinet in cabinetList)
            {
                if (cabinet.HasEmptyBox())
                    return true;
            }

            return false;
        }

        public void Add(Cabinet cabinet)
        {
            cabinetList.Add(cabinet);
        }

        private List<Cabinet> cabinetList = new List<Cabinet>();
    }
}
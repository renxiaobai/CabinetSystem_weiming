using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CabinetSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabinetSystemTest
{

    [TestClass]
    public class CabinetTest
    {
        [TestMethod]
        public void should_has_empty_box_given_cabinet()
        {
            Cabinet cabinet = new Cabinet(50);

            Assert.IsTrue(cabinet.HasEmptyBox());
        }











//         [TestMethod]
//         public void should_return_null_given_robot_ticket_when_pick()
//         {
//             var robot = new Robot();
//             var cabinet = new Cabinet(3);
//             robot.Add(cabinet);
//             var ticket = robot.Store(new Bag());
// 
//             Assert.IsNull(GetDirectInstance(cabinet).Pick(ticket));
//         }
    }
}


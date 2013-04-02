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



        [TestMethod]
        public void should_return_bag_given_valid_ticket_when_pick()
        {
            Bag aBag = new Bag();
            Bag anotherBag = new Bag();
            Cabinet cabinet = new Cabinet(50);

            var directInstance = new Direct(cabinet);
            Ticket ticket = directInstance.Store(aBag);
            var resultTicket = directInstance.Pick(ticket);

            Assert.AreEqual(aBag, resultTicket);
            Assert.AreNotEqual(anotherBag, resultTicket);
        }

        [TestMethod]
        public void should_not_return_bag_given_used_ticket_when_pick()
        {
            Bag aBag = new Bag();
            Cabinet cabinet = new Cabinet(50);
            var directInstance = new Direct(cabinet);
            Ticket ticket = directInstance.Store(aBag);
            directInstance.Pick(ticket);

            Assert.IsNull(directInstance.Pick(ticket));
        }

        [TestMethod]
        public void should_not_return_bag_given_invalid_ticket_when_pick()
        {
            Ticket ticket = new Ticket();
            Cabinet cabinet = new Cabinet(50);

            Assert.IsNull(new Direct(cabinet).Pick(ticket));
        }

        [TestMethod]
        public void should_not_return_ticket_given_full_cabinet_when_pick()
        {
            Bag bag = new Bag();
            var cabinet = new Cabinet(0);

            Assert.IsNull(new Direct(cabinet).Store(bag));
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


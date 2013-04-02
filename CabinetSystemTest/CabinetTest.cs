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
        public void should_return_ticket_given_empty_cabinet_when_store()
        {
            Bag aBag = new Bag();
            Cabinet cabinet = new Cabinet(50);

            Ticket ticket = cabinet.Direct.Store(aBag);

            Assert.IsNotNull(ticket);
        }

        [TestMethod]
        public void should_return_bag_given_valid_ticket_when_pick()
        {
            Bag aBag = new Bag();
            Bag anotherBag = new Bag();
            Cabinet cabinet = new Cabinet(50);

            Ticket ticket = cabinet.Direct.Store(aBag);
            var resultTicket = cabinet.Direct.Pick(ticket);

            Assert.AreEqual(aBag, resultTicket);
            Assert.AreNotEqual(anotherBag, resultTicket);
        }

        [TestMethod]
        public void should_not_return_bag_given_used_ticket_when_pick()
        {
            Bag aBag = new Bag();
            Cabinet cabinet = new Cabinet(50);
            Ticket ticket = cabinet.Direct.Store(aBag);
            cabinet.Direct.Pick(ticket);

            Assert.IsNull(cabinet.Direct.Pick(ticket));
        }

        [TestMethod]
        public void should_not_return_bag_given_invalid_ticket_when_pick()
        {
            Ticket ticket = new Ticket();
            Cabinet cabinet = new Cabinet(50);

            Assert.IsNull(cabinet.Direct.Pick(ticket));
        }

        [TestMethod]
        public void should_not_return_ticket_given_full_cabinet_when_pick()
        {
            Bag bag = new Bag();
            var cabinet = new Cabinet(0);

            Assert.IsNull(cabinet.Direct.Store(bag));
        }

        [TestMethod]
        public void should_return_null_given_robot_ticket_when_pick()
        {
            var robot = new Robot();
            var cabinet = new Cabinet(3);
            robot.Add(cabinet);
            var ticket = robot.Store(new Bag());

            Assert.IsNull(cabinet.Direct.Pick(ticket));
        }
    }
}


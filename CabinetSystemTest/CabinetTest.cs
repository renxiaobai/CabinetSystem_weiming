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
            Cabinet cabinet = new Cabinet();

            Assert.IsTrue(cabinet.HasEmptyBox());
        }

        [TestMethod]
        public void should_return_ticket_given_empty_cabinet_when_store()
        {
            Bag aBag = new Bag();
            Cabinet cabinet = new Cabinet();

            Ticket ticket = cabinet.Store(aBag);

            Assert.IsNotNull(ticket);
        }

        [TestMethod]
        public void should_return_bag_given_valid_ticket_when_pick()
        {
            Bag aBag = new Bag();
            Bag anotherBag = new Bag();
            Cabinet cabinet = new Cabinet();

            Ticket ticket = cabinet.Store(aBag);
            var resultTicket = cabinet.Pick(ticket);

            Assert.AreEqual(aBag, resultTicket);
            Assert.AreNotEqual(anotherBag, resultTicket);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void should_not_return_bag_given_used_ticket_when_pick()
        {
            Bag aBag = new Bag();
            Cabinet cabinet = new Cabinet();
            Ticket ticket = cabinet.Store(aBag);
            cabinet.Pick(ticket);

            cabinet.Pick(ticket);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void should_not_return_bag_given_invalid_ticket_when_pick()
        {
            Ticket ticket = new Ticket();
            Cabinet cabinet = new Cabinet();

            cabinet.Pick(ticket);
        }

        [TestMethod]
        public void should_not_return_ticket_given_full_cabinet_when_pick()
        {
            Bag bag = new Bag();
            var cabinet = new Cabinet(0);

            Assert.IsNull(cabinet.Store(bag));
        }
    }
}


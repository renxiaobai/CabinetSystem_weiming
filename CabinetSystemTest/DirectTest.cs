using CabinetSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace CabinetSystemTest
{


    /// <summary>
    ///This is a test class for DirectTest and is intended
    ///to contain all DirectTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DirectTest
    {
        [TestMethod]
        public void should_return_ticket_given_empty_cabinet_when_store()
        {
            Bag aBag = new Bag();
            Cabinet cabinet = new Cabinet(50);

            Ticket ticket = new Direct(cabinet).Store(aBag);

            Assert.IsNotNull(ticket);
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

        [TestMethod]
        public void should_return_true_given_has_empty_box()
        {
            Cabinet cabinet = new Cabinet(50);
            var directInstance = new Direct(cabinet);

            Assert.IsTrue(directInstance.HasEmptyBox());
        }

        [TestMethod]
        public void should_return_false_given_hasnot_empty_box()
        {
            Cabinet cabinet = new Cabinet(0);
            var directInstance = new Direct(cabinet);

            Assert.IsFalse(directInstance.HasEmptyBox());
        }
    }
}

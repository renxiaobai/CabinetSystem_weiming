using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CabinetSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabinetSystemTest
{
    /// <summary>
    /// Summary description for SuperRobotTest
    /// </summary>
    [TestClass]
    public class SuperRobotTest
    {
        public SuperRobotTest()
        {

        }

        [TestMethod]
        public void should_return_true_given_has_empty_box()
        {
            var superRobot = new SuperRobot();
            superRobot.Add(new Cabinet(50));
            Assert.IsTrue(superRobot.HasEmptyBox());
        }

        [TestMethod]
        public void should_return_false_given_hasnot_empty_box()
        {
            var superRobot = new SuperRobot();
            superRobot.Add(new Cabinet(0));
            Assert.IsFalse(superRobot.HasEmptyBox());
        }

        [TestMethod]
        public void should_return_validate_ticket_and_Save_to_MoreEmptyBoxRateCabinet_when_store_given_has_empty_box()
        {
            var superRobot = new SuperRobot();
            var cabinet1 = new Cabinet(2);
            var cabinet2 = new Cabinet(1);
            superRobot.Add(cabinet1);
            superRobot.Add(cabinet2);


            var ticket1 = Ticket.CreateTicket("SuperRobot");
            ticket1 = cabinet1.Store(new Bag(), ticket1);
            var ticket = superRobot.Store(new Bag());

            Assert.IsNotNull(ticket);
            Assert.IsFalse(cabinet2.HasEmptyBox());
        }

    }
}

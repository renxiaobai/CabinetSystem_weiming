using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CabinetSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabinetSystemTest
{
    /// <summary>
    /// Summary description for SmartRobotTest
    /// </summary>
    [TestClass]
    public class SmartRobotTest
    {
        [TestMethod]
        public void should_return_true_given_has_empty_box()
        {
            var smartRobot = new SmartRobot();
            smartRobot.Add(new Cabinet(50));
            Assert.IsTrue(smartRobot.HasEmptybox());
        }

        [TestMethod]
        public void should_return_false_given_hasnot_empty_box()
        {
            var smartRobot = new SmartRobot();
            smartRobot.Add(new Cabinet(0));
            Assert.IsFalse(smartRobot.HasEmptybox());
        }

        [TestMethod]
        public void should_return_validate_ticket_and_Save_to_MoreEmptyBoxCabinet_when_store_given_has_empty_box()
        {
            var smartRobot = new SmartRobot();
            var cabinet1 = new Cabinet(1);
            var cabinet2 = new Cabinet(2);
            smartRobot.Add(cabinet1);
            smartRobot.Add(cabinet2);

            var ticket = smartRobot.Store(new Bag());

            Assert.IsNotNull(ticket);
            Assert.IsTrue(cabinet1.HasEmptyBox());
        }
    }
} 

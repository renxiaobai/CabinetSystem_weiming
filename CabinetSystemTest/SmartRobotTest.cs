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
    }
} 

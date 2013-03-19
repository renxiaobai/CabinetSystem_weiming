using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CabinetSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabinetSystemTest
{
    /// <summary>
    /// Summary description for RobotTest
    /// </summary>
    [TestClass]
    public class RobotTest
    {
        public RobotTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void should_return_true_given_has_empty_box()
        {
            var robot = new Robot();
            var cabinet = new Cabinet(50);
            robot.Add(cabinet);
            Assert.IsTrue(robot.HasEmptybox());
        }

        [TestMethod]
        public void should_return_false_given_hasnot_empty_box()
        {
            var robot = new Robot();
            var cabinet = new Cabinet(0);
            robot.Add(cabinet);
            Assert.IsFalse(robot.HasEmptybox());
        }

        [TestMethod]
        public void should_return_validate_ticket_when_store_given_has_empty_box()
        {
            var robot = new Robot();
            var cabinet = new Cabinet(50);
            robot.Add(cabinet);

            var ticket = robot.Store(new Bag());

            Assert.IsNotNull(ticket);
        }
        [TestMethod]
        public void should_return_null_when_store_given_has_not_empty_box()
        {
            var robotWithNoEmptyBox = new Robot();

            var ticket = robotWithNoEmptyBox.Store(new Bag());

            Assert.IsNull(ticket);
        }

        [TestMethod]
        public void should_return_matched_bag_when_pick_given_valid_ticket()
        {
            var robot = new Robot();
            var cabinet1 = new Cabinet(2);
            var cabinet2 = new Cabinet(2);
            robot.Add(cabinet1);
            robot.Add(cabinet2);

            var bag1 = new Bag();
            var bag2 = new Bag();
            var bag3 = new Bag();

            var ticket1 = robot.Store(bag1);
            var ticket2 = robot.Store(bag2);
            var ticket3 = robot.Store(bag3);

            Assert.AreEqual(bag3, robot.pick(ticket3));
        }

        [TestMethod]
        public void should_return_null_when_pick_given_used_ticket()
        {
            var robot = new Robot();
            var cabinet1 = new Cabinet(2);
            var cabinet2 = new Cabinet(2);
            robot.Add(cabinet1);
            robot.Add(cabinet2);

            var bag1 = new Bag();
            var bag2 = new Bag();
            var bag3 = new Bag();

            var ticket1 = robot.Store(bag1);
            var ticket2 = robot.Store(bag2);
            var ticket3 = robot.Store(bag3);
            robot.pick(ticket3);
            Assert.IsNull(robot.pick(ticket3));
        }
        [TestMethod]
        public void should_return_null_when_pick_given_fake_ticket()
        {
            var robot = new Robot();
            var cabinet1 = new Cabinet(2);
            var cabinet2 = new Cabinet(2);
            robot.Add(cabinet1);
            robot.Add(cabinet2);

            var bag1 = new Bag();
            var bag2 = new Bag();
            var bag3 = new Bag();

            var ticket1 = robot.Store(bag1);
            var ticket2 = robot.Store(bag2);
            var ticket3 = new Ticket();

            Assert.IsNull(robot.pick(ticket3));
        }

        
    }
}

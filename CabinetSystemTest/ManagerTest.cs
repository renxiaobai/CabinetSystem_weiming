using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using CabinetSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CabinetSystemTest
{
    /// <summary>
    /// Summary description for ManagerTest
    /// </summary>
    [TestClass]
    public class ManagerTest
    {
        public ManagerTest()
        {
            //
            // TODO: Add constructor logic here
            //
        }


        [TestMethod]
        public void Should_hold_Robet()
        {
            var mgr = new Manager();
            var robot=new Robot();
            var cabinet = new Cabinet(1);
            robot.Add(cabinet);
            mgr.Add(robot);
            Assert.IsTrue(mgr.HasEmptyBox());
        }

        [TestMethod]
        public void Should_hold_cabinet()
        {
            var mgr = new Manager();
            var cabinet = new Cabinet(1);
            mgr.Add(cabinet);
            Assert.IsTrue(mgr.HasEmptyBox());
        }
    }
}

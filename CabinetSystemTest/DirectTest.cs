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
    }
}

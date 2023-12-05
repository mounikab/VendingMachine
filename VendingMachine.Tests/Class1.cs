using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace VendingMachine.Tests
{
    [TestClass]
    public class VendingMachineTests
    {
        [TestMethod]
        public void TestInsertAmouni()
        {
            //arrange
            Program.OrderingProcess("2");

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            Program.OrderingProcess("2");

            //assert
            var output = stringWriter.ToString();
            Assert.AreEqual("Current Credit:" + currentCredit", output);
        }
    }
}
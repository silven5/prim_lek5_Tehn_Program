using prim_lek5.Class;
using System.Security.Claims;

namespace UNIT_TEST_ISERIES
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Fib_1_1_2()
        {
            // Arrange
            int rez = 2;
            var f = new Fib();
            // Act
            f.SetStart(1, 1);
            // Assert
            Assert.AreEqual(rez, f.GetNext());

        }
    }
}
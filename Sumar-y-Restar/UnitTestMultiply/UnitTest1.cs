using Microsoft.VisualStudio.TestTools.UnitTesting;

using Sumar.Controllers;

namespace UnitTestMultiply
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMult()
        {
            //Arrange
            MultiplyController multiplyController = new MultiplyController();

            int a = 5;
            int b = 8;
            int esperado = 13;

            //Act
            int resultado = multiplyController(a, b);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}

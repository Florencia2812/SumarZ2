using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sumar.Controllers;

namespace UnitTestMultiply1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMult()
        {
            //Arrange
            MultiplyController multiplyController = new MultiplyController();

            int a = 3;
            int b = 2;
            int esperado = 6;

            //Act
            int resultado = multiplyController.Mult(a, b);

            //Assert
            Assert.AreEqual(esperado, resultado);
        }
    }
}

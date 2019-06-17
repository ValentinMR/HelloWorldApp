using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramLogic;

namespace HelloWorld.UnitTests
{
    [TestClass]
    public class MessageTests
    {
        [TestMethod]
        public void GetMessage_ReturnsHelloWorld()
        {
            //Arange
            var message = new Message();

            //Act
            var result = message.GetMessage();

            //Assert
            Assert.AreEqual("Hello World", result);
        }
    }
}

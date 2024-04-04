using Exercises.Domain;
using System;

namespace Exercises.Tests
{
    public class HelloWorldTest
    {
        [Fact]
        public void SayHello_Test()
        {
            //(A)Arrange
            
            //(A)Act
            string mensagem = HelloWorld.SayHello();

            //(A)Assert
            Assert.Equal("Hello World!", mensagem);
        }
    }
}
using System;
using Xunit;
using SimpleAPI2.Controllers;

namespace SimpleAPI2.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();


        [Fact]
        public void GetReturnsMyName()
        {
            var returnValue = controller.Get(1);
            Assert.Equal("Vivek Guddeti", returnValue.Value);
        }
       
        [Fact]
        public void Test1()
        {

        }
    }
}

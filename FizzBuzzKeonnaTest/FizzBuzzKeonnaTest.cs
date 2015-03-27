using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzKeonnaTest
{
    public class FizzBuzzKeonnaTest
    {
        [Fact]
        public void NumbersReturnNumberAsString()
        {
            //arrange:
            var underTest = new FizzBuzzKeonna.FizzBuzzKeonnaEngine();

            //act:
            string answer = underTest.DoTheThing(1);

            //assert:
            Assert.Equal("1", answer);

        }
        
        
        
        }
}

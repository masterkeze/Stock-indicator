using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using TestHelper;

namespace TestHelper.Tests
{
    public class ListHelperTests
    {
        public class GetDoubleListWithLength
        {
            [Fact]
            public void Should_ThrowArgumentException_When_NegativeLength()
            {
                //Arrange
                int length = -1;
                //Act

                //Assert
                Assert.Throws<ArgumentException>("length", () => ListHelper.GetDoubleListWithLength(length));
            }
            [Theory]
            [InlineData(0)]
            [InlineData(10)]
            public void Should_EqualToInputLength(int length)
            {
                //Arrange

                //Act
                List<Double> output = ListHelper.GetDoubleListWithLength(length);
                int expected = output.Count;
                //Assert
                Assert.Equal(length, expected);
            }
        }
    }
}

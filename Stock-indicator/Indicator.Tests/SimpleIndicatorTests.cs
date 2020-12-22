using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indicator;
using TestHelper;
using Xunit;

namespace Indicator.Tests
{
    public class SimpleIndicatorTests
    {
        public class MovingAverage
        {
            [Theory]
            [InlineData(0)]
            [InlineData(-1)]
            public void Should_ThrowArgumentException_When_NegativePeriod(int period)
            {
                // Arrange
                List<double> expected = new List<double>();

                // Act

                // Assert
                Assert.Throws<ArgumentException>("period", ()=> SimpleIndicator.MovingAverage(new List<double>(), period));
            }
            [Theory]
            [InlineData(1, 1)]
            [InlineData(10, 10)]
            public void Should_EqualToDataSize(int length, int period)
            {
                // Arrange
                List<double> data = ListHelper.GetDoubleListWithLength(length);
                int expected = length;

                // Act
                List<double?> output = SimpleIndicator.MovingAverage(data, period);

                // Assert
                Assert.Equal(expected, output.Count);
            }
        }
    }
}

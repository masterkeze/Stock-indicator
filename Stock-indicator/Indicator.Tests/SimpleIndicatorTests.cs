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
            public void Should_ThrowArgumentException_When_NonPositivePeriod(int period)
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
                List<double> output = SimpleIndicator.MovingAverage(data, period);

                // Assert
                Assert.Equal(expected, output.Count);
            }
            [Theory]
            [InlineData(0)]
            [InlineData(10)]
            public void Should_ReturnSame_When_PeriodIsOne(int length)
            {
                // Arrange
                int period = 1;
                List<double> data = ListHelper.GetDoubleListWithLength(length);
                List<double> expected = ListHelper.GetDoubleListWithLength(length);

                // Act
                List<double> output = SimpleIndicator.MovingAverage(data, period);

                // Assert
                Assert.Equal(expected, output);
            }
            [Fact]
            public void Should_Pass_When_NormalCase()
            {
                // Arrange
                int period = 3;
                List<double> data = new List<double>() { 3, 5, 7, 9 };
                List<double> expected = new List<double>() { SimpleIndicator.EMPTY_NUMBER, SimpleIndicator.EMPTY_NUMBER, 5, 7 };

                // Act
                List<double> output = SimpleIndicator.MovingAverage(data, period);

                // Assert
                Assert.Equal(expected, output);
            }
            [Fact]
            public void Should_AllEmpty_When_LargePeriod()
            {
                // Arrange
                int period = 5;
                List<double> data = new List<double>() { 3, 5, 7, 9 };
                List<double> expected = new List<double>() { SimpleIndicator.EMPTY_NUMBER, SimpleIndicator.EMPTY_NUMBER, SimpleIndicator.EMPTY_NUMBER, SimpleIndicator.EMPTY_NUMBER };

                // Act
                List<double> output = SimpleIndicator.MovingAverage(data, period);

                // Assert
                Assert.Equal(expected, output);
            }
        }
    }
}

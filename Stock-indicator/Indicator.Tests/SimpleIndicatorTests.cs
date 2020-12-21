using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Indicator;
using Xunit;

namespace Indicator.Tests
{
    public class SimpleIndicatorTests
    {
        public class MovingAverageTests
        {
            [Fact]
            public void Should_ReturnEmptyList_When_EmptyInput()
            {
                // Arrange
                List<double> expected = new List<double>();

                // Act
                List<double> actual = SimpleIndicator.MovingAverage(new List<double>(), 0);

                // Assert
                Assert.Equal(expected, actual);
            }
            [Fact]
            public void Should_ReturnSameInputList_When_PeriodIsOne()
            {
                // Arrange
                List<double> expected = new List<double>() { 0 };

                // Act
                List<double> actual = SimpleIndicator.MovingAverage(new List<double>() { 0 }, 1);

                // Assert
                Assert.Equal(expected, actual);
            }
        }
    }
}

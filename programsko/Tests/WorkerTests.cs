using programsko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace programsko.Tests
{
    internal class WorkerTests
    {
        [Fact]
        public void PaymentCalculation_ShouldCalculatePaymentCorrectly()
        {
            // Arrange
            var worker = new Worker("John", "Doe", 0.1);
            var numberOfCards = 10;
            var price = 100;

            // Act
            var payment = worker.PaymentCalculation(numberOfCards, price);

            // Assert
            Assert.Equal(1000, payment);
        }

        [Theory]
        [InlineData(10, 100, 1000)]
        [InlineData(20, 50, 1000)]
        public void PaymentCalculation_ShouldCalculatePaymentCorrectlyForDifferentInputs(int numberOfCards, int price, double expectedPayment)
        {
            // Arrange
            var worker = new Worker("John", "Doe", 0.1);

            // Act
            var payment = worker.PaymentCalculation(numberOfCards, price);

            // Assert
            Assert.Equal(expectedPayment, payment);
        }

        [Fact]
        public void Worker_ShouldHaveCorrectProperties()
        {
            // Arrange
            var worker = new Worker("John", "Doe", 0.1);

            // Act and Assert
            Assert.Equal("John", worker.Name);
            Assert.Equal("Doe", worker.LName);
            Assert.Equal(0.1, worker.PerCardPercentage);
        }
    }
}

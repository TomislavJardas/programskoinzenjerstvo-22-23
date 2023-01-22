using programsko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace programsko.Tests
{
    internal class TrainTests
    {
        [Fact]
        public void ParkVehicle_ShouldParkVehicle()
        {
            // Arrange
            var smallTrain = new SmallTrain();
            var car = new Car();

            // Act
            smallTrain.ParkVehicle(car);

            // Assert

        }

        [Fact]
        public void SmallTrain_ShouldHaveCorrectCapacity()
        {
            // Arrange
            var smallTrain = new SmallTrain();

            // Act and Assert
            Assert.Equal(8, smallTrain.SmallVehicleCapacity);
            Assert.Equal(0, smallTrain.LargeVehicleCapacity);
        }

        [Fact]
        public void LargeTrain_ShouldHaveCorrectCapacity()
        {
            // Arrange
            var largeTrain = new LargeTrain();

            // Act and Assert
            Assert.Equal(0, largeTrain.SmallVehicleCapacity);
            Assert.Equal(6, largeTrain.LargeVehicleCapacity);
        }
        [Fact]
        public void Car_ShouldRefillGas()
        {
            // Arrange
            var car = new Car();

            // Act
            car.RefillGas();

            // Assert
            // Assert that the car's gas level is updated
        }

        [Fact]
        public void Car_ShouldHaveCorrectGasPrice()
        {
            // Arrange
            var car = new Car();

            // Act and Assert
            Assert.Equal(50, car.GasPrice);
        }
    }
}

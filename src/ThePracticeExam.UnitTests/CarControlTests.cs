using Shouldly;
using System.IO;
using ThePracticeExam.Program.Classes;
using Xunit;

namespace ThePracticeExam.UnitTests
{
    public class CarControlTests
    {
        [Fact]
        public void CreateCarControlTest()
        {
            // Arrange
            var cars = new Car[]
            {
                new Car
                {
                    Model = "BNW",
                    Power = 228,
                    Price = 600000
                },
                new Car
                {
                    Model = "Lexus",
                    Power = 200,
                    Price = 500000
                },
                new Car
                {
                    Model = "Lada",
                    Power = 200,
                    Price = 400000
                },
                new Car
                {
                    Model = "Toyota",
                    Power = 228,
                    Price = 550000
                }
            };

            // Act
            var carControl = new CarControl(cars);

            // Assert
            Assert.NotNull(carControl);
            carControl.Legnth.ShouldBe(4);
        }

        [Fact]
        public void SortCarControlTest()
        {
            // Arrange
            var unsortedArray = new Car[]
            {
                new Car
                {
                    Model = "BNW",
                    Power = 228,
                    Price = 600000
                },
                new Car
                {
                    Model = "Lexus",
                    Power = 200,
                    Price = 500000
                },
                new Car
                {
                    Model = "Lada",
                    Power = 200,
                    Price = 400000
                },
                new Car
                {
                    Model = "Toyota",
                    Power = 228,
                    Price = 550000
                }
            };
            var sortedArray = new Car[]
            {
                new Car
                {
                    Model = "Lada",
                    Power = 200,
                    Price = 400000
                },
                new Car
                {
                    Model = "Lexus",
                    Power = 200,
                    Price = 500000
                },
                new Car
                {
                    Model = "Toyota",
                    Power = 228,
                    Price = 550000
                },
                new Car
                {
                    Model = "BNW",
                    Power = 228,
                    Price = 600000
                }
            };

            // Act
            var carControl = new CarControl(unsortedArray);
            carControl.Sort();

            // Assert
            carControl[0].Model.ShouldBe(sortedArray[0].Model);
            carControl[1].Model.ShouldBe(sortedArray[1].Model);
            carControl[2].Model.ShouldBe(sortedArray[2].Model);
            carControl[3].Model.ShouldBe(sortedArray[3].Model);
        }

        [Fact]
        public void SaveCarControlTest()
        {
            // Arrange 
            var cars = new Car[]
            {
                new Car
                {
                    Model = "BNW",
                    Power = 228,
                    Price = 600000
                },
                new Car
                {
                    Model = "Lexus",
                    Power = 200,
                    Price = 500000
                },
                new Car
                {
                    Model = "Lada",
                    Power = 200,
                    Price = 400000
                },
                new Car
                {
                    Model = "Toyota",
                    Power = 228,
                    Price = 550000
                }
            };
            string path = $"{Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent}/cars.txt";

            // Act
            var carControl = new CarControl(cars);
            carControl.Sort();
            carControl.Save();

            //Assert
            File.Exists(path).ShouldBeTrue();
        }
    }
}

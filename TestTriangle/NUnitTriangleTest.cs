using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnitDemonstration;

namespace TestTriangle
{
    public class NUnitTriangleTest
    {
        private Triangle _triangle { get; set; } = null!;
        [SetUp]
        public void Setup()
        {
            _triangle = new Triangle();
        }

        [Test]
        //[TestCase(60, 80, 20)]
        //[TestCase(60, 80, 40)]
        //[TestCase(90, 40, 50)]
        //[TestCase(70, 85, 15)]
        //[TestCase(-70, -80, 220)]
        public void ValidTriangle_Test()
        {
            //Assert.Pass();
            //Arrange
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;

            string expected = "The triangle is valid.";

            //Act
            //var triangle = _triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            string actual = _triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            //Assert
            //Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}
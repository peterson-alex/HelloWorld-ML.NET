using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HelloWorld.MLModel;

namespace UnitTests
{
    public class ModelOutputTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ModelOutput_Default_Not_Null()
        {
            // Act
            var item = new ModelOutput();

            // Assert
            Assert.NotNull(item);
        }

        [Test]
        public void ModelOutput_Properties_Default_Values_Null()
        {
            // Act
            var item = new ModelOutput();

            // Assert
            Assert.AreEqual(item.Prediction, null);
            Assert.AreEqual(item.Score, null);
        }

        [Test]
        public void ModelOutput_Set_Properties_Valid()
        {
            // Arrange
            var item = new ModelOutput()
            {
                Prediction = "Bogus prediction",
                Score = new float[] { 1.0f }
            };

            // Assert
            Assert.AreEqual(item.Prediction, "Bogus prediction");
            Assert.AreEqual(item.Score, new float[] { 1.0f });
        }
    }
}

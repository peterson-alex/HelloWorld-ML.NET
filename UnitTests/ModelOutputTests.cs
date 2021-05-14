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
    }
}

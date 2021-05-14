using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.MLModel;
using NUnit.Framework;

namespace UnitTests
{
    public class ModelInputTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ModelInput_Default_Not_Null()
        {
            // Act
            var item = new ModelInput();

            // Assert
            Assert.NotNull(item);
        }

        [Test]
        public void ModelInput_Properties_Default_Values_Null()
        {
            // Act
            var item = new ModelInput();

            // Assert
            Assert.AreEqual(item.Text, null);
            Assert.AreEqual(item.Label, null);
        }

        [Test]
        public void ModelInput_Set_Properties_Valid()
        {
            // Arrange
            var item = new ModelInput()
            {
                Text = "Bogus text",
                Label = "Bogus label"
            };

            // Assert
            Assert.AreEqual(item.Text, "Bogus text");
            Assert.AreEqual(item.Label, "Bogus label");
        }
    }
}

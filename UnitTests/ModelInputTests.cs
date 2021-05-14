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
    }
}

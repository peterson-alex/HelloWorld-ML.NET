using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using HelloWorld.MLModel;

namespace UnitTests
{
    public class ConsumeModelTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void ConsumeModel_CreatePredictionEngine_Not_Null()
        {
            // Act
            var predEngine = ConsumeModel.CreatePredictionEngine();

            // Assert
            Assert.IsNotNull(predEngine);
        }
    }
}

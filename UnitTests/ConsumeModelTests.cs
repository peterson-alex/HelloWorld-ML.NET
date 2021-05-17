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

        [Test]
        public void ConsumeModel_Predict_Not_Null()
        {
            // Arrange
            var input = new ModelInput()
            {
                Text = "Bogus text"
            };

            // Act 
            var result = ConsumeModel.Predict(input);

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void ConsumeModel_Predict_Properties_Not_Null()
        {
            // Arrange
            var input = new ModelInput()
            {
                Text = "Bogus text"
            };

            // Act 
            var result = ConsumeModel.Predict(input);

            // Assert
            Assert.IsNotNull(result.Prediction);
            Assert.IsNotNull(result.Score);
        }

        [Test]
        public void ConsumeModel_Predict_F_Score_Between_Zero_And_One()
        {
            // Arrange
            var input = new ModelInput()
            {
                Text = "Bogus text"
            };

            // Act 
            var result = ConsumeModel.Predict(input);

            Assert.GreaterOrEqual(result.Score[0], 0); // greater than or equal to zero
            Assert.LessOrEqual(result.Score[0], 1); // less than or equal to 1
        }

        [Test]
        public void ConsumeModel_Positive_Review_Prediction_Is_1()
        {
            // Arrange
            var input = new ModelInput()
            {
                Text = "This place was awesome!" // if model is updated, this may need to be updated
            };

            // Act 
            var result = ConsumeModel.Predict(input);

            // Assert
            Assert.AreEqual(result.Prediction, "1"); // '1' means review was positive
        }

        [Test]
        public void ConsumeModel_Negative_Review_Prediction_Is_0()
        {
            // Arrange
            var input = new ModelInput()
            {
                Text = "This place was awful!" // if model is updated, this may need to be updated
            };

            // Act 
            var result = ConsumeModel.Predict(input);

            // Assert
            Assert.AreEqual(result.Prediction, "0"); // '0' means review was negative
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

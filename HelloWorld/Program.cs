using System;
using HelloWorldML.Model;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add input data
            var input = new ModelInput()
            {
                Text = "Bad."
            };

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            // If Prediction is 1, sentiment is "Positive"; otherwise, sentiment is "Negative."
            string sentiment = result.Prediction == "1" ? "Positive" : "Negative";

            // Show results of prediction. 
            Console.WriteLine($"Text: {input.Text}\nSentiment: {sentiment}\nScore: {result.Score[0]}");
        }
    }
}

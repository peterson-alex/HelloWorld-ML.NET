using Microsoft.ML.Data;

namespace HelloWorldML.Model
{
    public class ModelInput
    {
        [ColumnName("col0"), LoadColumn(0)]
        public string Text { get; set; }

        [ColumnName("col1"), LoadColumn(1)]
        public string Label { get; set; }
    }
}

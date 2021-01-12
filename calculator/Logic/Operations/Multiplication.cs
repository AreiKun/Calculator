using calculator.Interfaces;
using calculator.Models.DataValue;

namespace Calculator.Operation
{
    public class Multiplication : IOperation

    {
        DataValue Data { get; set; }

        public Multiplication(DataValue data)
        {
            Data = data;
        }

        private double Composition()
        {
            double result = Data.firstValue * Data.secondValue;
            return result;
        }

        public double Execute()
        {
            return Composition();
        }

    }
}
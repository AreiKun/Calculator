using calculator.Interfaces;
using calculator.Models.DataValue;

namespace Calculator.Operation
{
    public class Subtraction : IOperation
    {
        DataValue Data { get; set; }

        public Subtraction(DataValue data)
        {
            Data = data;
        }

        private double Difference()
        {
            double result = Data.firstValue - Data.secondValue;
            return result;
        }

        public double Execute()
        {
            return Difference();
        }
    }
}
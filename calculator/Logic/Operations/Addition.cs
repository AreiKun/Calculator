using calculator.Interfaces;
using calculator.Models.DataValue;
namespace Calculator.Operation
{
    public class Addition : IOperation
    {
        DataValue Data { get; set; }

        public Addition(DataValue data)
        {
            Data = data;
        }       

        private double Amount()
        {
            double result = Data.firstValue + Data.secondValue;
            return result;
        }

        public double Execute()
        {
            return Amount();
        }
       
    }

 }
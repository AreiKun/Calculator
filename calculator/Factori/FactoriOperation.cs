using calculator.Interfaces;
using calculator.Models.DataValue;
using Calculator.Operation;

namespace calculator.Factori
{
    class FactoriOperation : IOperationsFactory
    {
        

        public IOperation CreateAddition(DataValue data)
        {
            return new Addition(data);
        }
        public IOperation CreateDivision(DataValue data)
        {
            return new Division(data);
        }
        public IOperation CreateMultiplication(DataValue data)
        {
            return new Multiplication(data);
        }
        public IOperation CreateSubstraction(DataValue data)
        {
            return new Subtraction(data);
        }
    }
}
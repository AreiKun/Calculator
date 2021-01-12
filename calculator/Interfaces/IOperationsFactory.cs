
using calculator.Models.DataValue;

namespace calculator.Interfaces
{
    interface IOperationsFactory
    {        
        IOperation CreateAddition(DataValue data);
        IOperation CreateDivision(DataValue data);
        IOperation CreateMultiplication(DataValue data);
        IOperation CreateSubstraction(DataValue data);
    }
}

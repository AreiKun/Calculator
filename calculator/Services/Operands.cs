using calculator.Factori;
using calculator.Interfaces;
using calculator.Models.DataValue;

namespace calculator.Services
{
    class Operands : ICalc
    {
        DataValue Data { get; set; }
        
        public Operands(DataValue data)
        {
            Data = data;
        }

        private double Expression()
        {
            switch (Data.action)
            {
                case "+":
                    var additionData = new DataValue() { firstValue = Data.firstValue, secondValue = Data.secondValue };
                    IOperationsFactory factori = new FactoriOperation();
                    var addition = factori.CreateAddition(additionData);                    
                    return ( addition.Execute());                    

                case "-":
                    var subtractionData = new DataValue() { firstValue = Data.firstValue, secondValue = Data.secondValue };
                    IOperationsFactory factory = new FactoriOperation();
                    var subtraction = factory.CreateSubstraction(subtractionData);
                    return (subtraction.Execute());                    

                case "/":
                    var divisionData = new DataValue() { firstValue = Data.firstValue, secondValue = Data.secondValue };
                    IOperationsFactory factorii = new FactoriOperation();
                    var division = factorii.CreateDivision(divisionData);
                    return (division.Execute());                    

                case "*":
                    var multiplicationData = new DataValue() { firstValue = Data.firstValue, secondValue = Data.secondValue };
                    IOperationsFactory factoryy = new FactoriOperation();
                    var multiplication = factoryy.CreateMultiplication(multiplicationData);
                    return ( multiplication.Execute());                                    

                default:
                    return (0);                    
            }
        }

        public double Accept()
        {
            return Expression();
        }
    }    
}
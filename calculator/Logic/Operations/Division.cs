using calculator.Interfaces;
using calculator.Models.DataValue;
using System;

namespace Calculator.Operation
{
    public class Division : IOperation
    {
        DataValue Data { get; set; }

        public Division(DataValue data)
        {
            Data = data;
        }
        private double Divided()
        {
            try
            {
                {
                    double result = Data.firstValue / Data.secondValue;
                    if (Data.secondValue == 0)
                        throw new DivideByZeroException();

                    return result;
                }
            }

            catch (DivideByZeroException)
            {                
                throw;
            }
        }        

        public double Execute()
        {
            return Divided();
        }
    }       
    
}
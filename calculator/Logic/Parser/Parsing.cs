using System;
using System.Linq;

namespace calculator.Logic
{
    public class Parsing
    {
        public static double Value(string incomingData)
        {
            try
            {                
                double a = double.Parse(incomingData);
                
                if (a.ToString().Length > 6)
                {
                    throw new ArgumentOutOfRangeException("Длина строки больше 6 символов");
                }

                return a;
            }

            catch(ArgumentOutOfRangeException)
            {
                throw;
            }            
        }

        public static string Operation(string incomingDataOperands)
        {
            try
            {
                string a = incomingDataOperands;
                string[] operands = new string[] { "+", "-", "*", "/" };
                
                if (operands.Contains(a))
                {
                    return a;
                }
                else
                    throw new InvalidOperandException("Неверный операнд, проверьте правильность ввода");

                
            }

            catch (InvalidOperandException)
            {
                throw;
            }
        }
    }
}
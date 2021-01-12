using System;
using calculator.Interfaces;
using calculator.Logic;
using calculator.Models.DataValue;
using calculator.Services;

namespace Calculator
{
   public class Calculator
    {
        static void Main(string[] args)
        {
            double firstValue, secondValue;
            string action, incomingData, incomingDataOperands;            
            
            Calculeit();
            
            void Calculeit()
            {
                try 
                {                    
                    Console.WriteLine("Введите число 1:");
                    incomingData = Console.ReadLine();
                    firstValue = Parsing.Value(incomingData);  // ридлайн в програмс                  
                    Console.WriteLine("Выберите операцию: '+' или '-' или '/' или '*' , для сброса введите '?'");
                    incomingDataOperands = Console.ReadLine();
                    action = Parsing.Operation(incomingDataOperands);                   
                    Console.WriteLine("Введите число 2:");
                    incomingData = Console.ReadLine();
                    secondValue = Parsing.Value(incomingData);                     

                    var operandsData = new DataValue() { firstValue = firstValue, secondValue = secondValue, action = action };
                    ICalc operands = new Operands(operandsData);
                    Console.WriteLine("=");
                    Console.WriteLine(operands.Accept());
                }

                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message + " Деление на ноль запрещено!!");                   
                }

                catch (FormatException x )
                {
                    Console.WriteLine(x.Message + " Это НЕ число!!!\n");                   
                }

                catch (ArgumentOutOfRangeException e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");                   
                }

                catch (InvalidOperandException e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                }

                catch (Exception c)
                {
                    Console.WriteLine($"Исключение: {c.Message}");                   
                }

                Console.ReadKey();
                Calculeit();
            }
        }
    }
}
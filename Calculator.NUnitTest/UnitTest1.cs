using NUnit.Framework;
using Calculator.Operation;
using calculator.Models.DataValue;
using System;
using calculator.Logic;
using System.Collections.Generic;
using System.Linq;

namespace Calculator.NUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Sum_10and20_30returned()
        {
            var a = new DataValue();
            //arrange
            var addition = new Addition(a);
            a.firstValue = 10;
            a.secondValue = 20;
            double expected = 30;

            //act
            double result = addition.Execute();

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Del_20Div10_2returned()
        {
            var a = new DataValue();
            //arrange
            var division = new Division (a);
            a.firstValue = 20;
            a.secondValue = 10;
            double expected = 2;

            //act
            double result = division.Execute();

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Del_4Div0_ZeroDivException()
        {
            var a = new DataValue();
            //arrange
            var division = new Division(a);
            a.firstValue = 4;
            a.secondValue = 0;

            //act            

            //assert            
            Assert.Throws<DivideByZeroException>(() => division.Execute());
        }

        [Test]
        public void Multi_20and10_200returned()
        {
            var a = new DataValue();
            //arrange
            var multiplication = new Multiplication (a);
            a.firstValue = 20;
            a.secondValue = 10;
            double expected = 200;

            //act
            double result = multiplication.Execute();

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Sub_200and150_50returned()
        {
            var a = new DataValue();
            //arrange
            var subtraction = new Subtraction (a);
            a.firstValue = 200;
            a.secondValue = 150;
            double expected = 50;

            //act
            double result = subtraction.Execute();

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Add_1234567and10_ArgumentOutOfRangeException()
        {            
            //arrange     
            Parsing parsing = new Parsing();
            string incomingData = "123456789";           

            //act 
            //assert            
            Assert.Throws< ArgumentOutOfRangeException>(() => Parsing.Value(incomingData));
        }

        [Test]
        public void Add_qwerty_FormatException()
        {
            //arrange     
            Parsing parsing = new Parsing();
            string incomingData = "qwerty";

            //act 
            //assert            
            Assert.Throws<FormatException>(() => Parsing.Value(incomingData));
        }

        [Test]
        public void Add_qwerty_InvalidOperandException()
        {
            //arrange     
            Parsing parsing = new Parsing();
            string incomingDataOperands = "qwerty";

            //act 
            //assert            
            Assert.Throws<InvalidOperandException>(() => Parsing.Operation(incomingDataOperands));
        }        

        [Test]
        public void Type25addDouble()
        {
            var a = new DataValue();
            //arrange             
            string incomingData = "25";

            //act 
            //assert
            Assert.That(a.firstValue = Parsing.Value(incomingData), Is.TypeOf(typeof(double)));
        }

        [Test]
        public void TypeRandomDataaddDouble()
        {
            Random rnd = new Random();
            var a = new DataValue();            
            double b = 15;
            for (int i = 0; i < b; i++)
            {
                double c = rnd.Next(20, 100);                
                string incomingData = c.ToString();
                Assert.That(a.firstValue = Parsing.Value(incomingData), Is.TypeOf(typeof(double)));
            }                    
        }       

        [Test]
        public void Sub_Range1and150Subtraction([Range(1, 100)] int x)
        {
            var a = new DataValue();
            var subtraction = new Subtraction(a);
                                    
            for (int i = 0; i < x; i++)
            {
                //arrange            
                a.firstValue = x;
                a.secondValue = 150;
                double expected = a.firstValue - 150;

                //act
                double result = subtraction.Execute();

                //assert
                Assert.AreEqual(expected, result);
            }
        }

        [Test]
        public void Sub_Range1and150Addition([Range(1,100)]int x)
        {
            var a = new DataValue();
            var addition = new Addition(a);
            for (int i = 0; i < x; i++)
            {
                //arrange            
                a.firstValue = x;
                a.secondValue = 150;
                double expected = a.firstValue + 150;

                //act
                double result = addition.Execute();

                //assert
                Assert.AreEqual(expected, result);
            }
        }

        [Test]
        public void Sub_Range1and150Multiplication([Range(1, 100)] int x)
        {
            var a = new DataValue();
            var multiplication = new Multiplication(a);
            for (int i = 0; i < x; i++)
            {
                //arrange            
                a.firstValue = x;
                a.secondValue = 150;
                double expected = a.firstValue * 150;

                //act
                double result = multiplication.Execute();

                //assert
                Assert.AreEqual(expected, result);
            }
        }

        [Test]
        public void Sub_Range0and150Division([Range(0, 100)] int x)
        {
            var a = new DataValue();
            var division = new Division(a);
            for (int i = 0; i < x; i++)
            {
                //arrange            
                a.firstValue = 150;
                a.secondValue = x;
                double expected = 150 / a.secondValue;

                //act
                double result = division.Execute();

                //assert
                Assert.AreEqual(expected, result);
            }
        }

        [Test]
        public void Sub_Range0and150DivisionDivided([Range(0, 100)] int x)
        {
            var a = new DataValue();
            var division = new Division(a);
            for (int i = 0; i < x; i++)
            {
                //arrange            
                a.firstValue = 150;
                a.secondValue = x;

                //assert
                Assert.Throws<DivideByZeroException>(() => division.Execute());
            }
        }

    }
}
using System;


namespace FirstCalculator
{   public interface ICalculator
    {
        double add(double x, double y);
        double subtract(double x, double y);
        double multiply(double x, double y);
        double divide(double x, double y);
        double Memory { get; }
    }
    class Calculator : ICalculator
    {
        private double memory;
        public double add(double x, double y)
        {
            double result = x + y;
            memory = result;
            return result;
        }

        public double subtract(double x, double y)
        {
            double result = x - y;
            memory = result;
            return result;
        }

        public double multiply(double x, double y)
        {
            double result = x * y;
            memory = result;
            return result;
        }

        public double divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentException("Enter the number except 0");
            }
            double result = x / y;
            memory = result;
            return result;
        }
        public double Memory
        {
            get { return memory; }
        }
    }
    class Program
    {    
        static void Main(string[] args)
        {   
            Calculator calculator = new Calculator();
            double result = 0;
            
            
            Console.WriteLine("Enter the first number: ");
            double x = double.Parse(Console.ReadLine());


            Console.WriteLine("Enter the second number: ");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation (+, -, *, /, m): ");
            string operation = Console.ReadLine();
            switch (operation)
            {
                case "+":
                    result = calculator.add(x, y); break;
                case "-":
                    result= calculator.subtract(x, y); break;
                case "*":
                    result= calculator.multiply(x, y); break;
                case "/":
                    result= calculator.divide(x, y); break;
                default: Console.WriteLine("Invalid operation.");
                    break;
            }
            Console.WriteLine("The result is: " + result);
        }
    }
}

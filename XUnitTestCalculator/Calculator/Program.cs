using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorApp
    {
        static void Main(string[] args)
        {
            
        }

        public double Add(double num1, double num2)
        {

            double ans = num1 + num2;

            return ans;
        }

        public double Subtract(double num1, double num2)
        {

            double ans = num1 - num2;

            return ans;
        }

        public double Divide(double num1, double num2)
        {
            
            double ans = num1 / num2;

            return ans;
        }

        public double Multiply(double num1, double num2)
        {
            
            double ans = num1 * num2;

            return ans;
        }

        public double Mod(double num1, double num2)
        {
            
            double ans = num1 % num2;

            return ans;
        }

        public double Circle(double num1)
        {
            
            double ans = (num1 * num1) * Math.PI;

            return ans;
        }

        public double Rectangle(double num1, double num2)
        {
            
            double ans = num1 * num2;

            return ans;
        }

        public double Triangle(double num1, double num2)
        {
            
            double ans = (num1 * num2) / 2;

            return ans;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Lab10
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
            Radius = _radius;
        }

        private string FormatNumber(double x)
        {
            var formattedNumber = Math.Round(x, 2);

            return formattedNumber.ToString();
        }

        public double CalculateCircumference()
        {
            //C = 2πr
            double circumference = (2 * Math.PI * _radius);
            return circumference;
        }

        public override double CalculateArea()
        {
            //A = πr2
            double area = Math.PI * Math.Pow(_radius, 2);
            return area;
        }

        public string CalculateFormattedCircumference()
        {
            double circumference = CalculateCircumference();
            string formattedCircumference = FormatNumber(circumference);

            return formattedCircumference;
        }

        public override string CalculateFormattedArea()
        {
            double area = CalculateArea();
            string formattedArea = FormatNumber(area);

            return formattedArea;
        }
    }
}

using System;
using System.Threading.Channels;


namespace Assignment_OOP04
{
    internal class Program
    {

        #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:
        ////●	Accept two integers and return their sum.
        ////●	Accept three integers and return their sum.
        ////●	Accept two doubles and return their sum.
        public static int SumNumbers(int X, int Y)
        { return X + Y; }
        public static int SumNumbers(int X, int Y, int Z) { return X + Y + Z; }
        public static double SumNumbers(double X, double Y) { return X + Y; }

        #endregion

        static void Main(string[] args)
        {
            #region Part 01
            #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:
            ////●	Accept two integers and return their sum.
            ////●	Accept three integers and return their sum.
            ////●	Accept two doubles and return their sum.
            int Result = SumNumbers(20, 30);
  Result = SumNumbers(10, 20, 30);
            double Result02 = SumNumbers(1.2, 1.2);
            Console.WriteLine("Answer  Q1");
            Console.WriteLine(Result);
            Console.WriteLine(Result02);
            Console.WriteLine("==============");
            //Console.WriteLine();
            #endregion


            #region Q2) Create a class named Rectangle with the following constructors:
            //●	A parameterless constructor that sets the width and height to 0.
            //●	A constructor that accepts width and height as integers.
            //●	A constructor that accepts a single integer and sets both width and height to that value.
            Console.WriteLine("Answer Q2");
            Rectangle rectang1 = new Rectangle();
            Console.WriteLine(rectang1);
            Rectangle rectangle2 = new Rectangle(10, 30);
            Console.WriteLine(rectangle2);
            Rectangle rectangle3 = new Rectangle(20);
            Console.WriteLine(rectangle3);
            Console.WriteLine("=====================");
            #endregion

            #region Q3) Define a class Complex Number that represents a complex number with real and imaginary parts.
       //////Note: Overload the +, - operator to add and subtract two complex numbers.


            #endregion
            #endregion

            #region Part 02


            #endregion



        }
    }
}

using System;
using System.Threading.Channels;

namespace Assignment_OOP04
{
    internal class Program
    {
        #region
        #region Q1) Write a class named Calculator that contains a method named Add. Overload the Add method to:
        ////●	Accept two integers and return their sum.
        ////●	Accept three integers and return their sum.
        ////●	Accept two doubles and return their sum.
        static int SumNumbers(int X ,int Y)
        { return X + Y; }
        static int SumNumbers(int X,int Y,int Z) { return X + Y + Z; }
        static double SumNumbers(double X,double Y) {return X + Y; }
        #endregion



        #endregion
        static void Main(string[] args)
        {
            #region Q2) Create a class named Rectangle with the following constructors:
            //●	A parameterless constructor that sets the width and height to 0.
            //●	A constructor that accepts width and height as integers.
            //●	A constructor that accepts a single integer and sets both width and height to that value.

            Rectangle rectang1 = new Rectangle();
            Console.WriteLine(rectang1);
            Rectangle rectangle2 = new Rectangle(10, 30);
            Console.WriteLine(rectangle2);
            Rectangle rectangle3 = new Rectangle(20);
            Console.WriteLine(rectangle3);

        #endregion

        }
    }
}

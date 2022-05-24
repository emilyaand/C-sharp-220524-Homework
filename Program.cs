using System;

namespace _220524_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person_class X = new Person_class();
            
                X.Name = "Miri";
                X.Surname = "Miriyev";
                X.Age = 20;

            if (X.Age > 18)
            {
                Console.WriteLine("true");
            }

            else
            {
                Console.WriteLine("false");
            }

        }
    }
}

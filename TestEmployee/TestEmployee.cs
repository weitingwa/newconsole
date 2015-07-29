using ClassEmployee;
using System;

namespace TestEmployee
{
    class TestEmployee
    {
        static void Main()
        {
            Employee Cindy = new Taiwaneese("Cindy", 20);
            Cindy.age = 20;
            
            System.Console.WriteLine("Can we hire? {0}", Cindy.hire());
            Console.WriteLine("");


            Employee Kevin = new Taiwaneese("Kevin", 15);
            Kevin.age = 15;

            System.Console.WriteLine("Can we hire? {0}", Kevin.hire());
            Console.ReadKey();


        }
    }
}

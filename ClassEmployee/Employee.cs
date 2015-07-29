using System;

namespace ClassEmployee
{
    public class Employee
    {

        public int age { get; set; }

        public bool hire () 
        {
            int age = this.age;

            bool b = true;
            b = (age >= 20);

            if (b)
            {
                return b;
            }
            else
            {
                return b;
            }
        }

    }


    public class Taiwaneese : Employee
    {
        public Taiwaneese(string name, int age)
        {

            Console.WriteLine("{0} comes from Chinese Taipei.", name);
            Console.WriteLine("{0} is {1} years old.", name, age);
        }
    }

}

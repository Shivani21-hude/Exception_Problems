using System;
namespace PersonAgeTesting
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the person's age :");
            int age = Convert.ToInt32(Console.ReadLine());
            CategoryOfPerson categoryofperson = new CategoryOfPerson(age);
            string person=categoryofperson.Category();
            Console.WriteLine(person);
           

        }
    }
}
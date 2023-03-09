using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Security.AccessControl;

namespace Class
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}",to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

class Program
{
    public static void Main(string[] args)
    {
            //Person person = new Person();
            var person = Person.Parse("John");
            //person.Name = "John";
            person.Introduce("Lok");

        Console.ReadKey();

        System.Environment.Exit(0);
    }
}
}
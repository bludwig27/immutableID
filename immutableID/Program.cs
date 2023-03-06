using System;

namespace immutableID
{
    class Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }
        //new parameterized constructor
        public Student(int i)
        {
            Id = i;
            FirstName = "";
            LastName = "";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student lisa = new Student(1);
            lisa.FirstName = "Lisa";
            lisa.LastName = "Simpson";

            Student todd = new Student(2,"Todd","Flanders");

            Console.WriteLine($"ID = {lisa.Id} Name = {lisa.FirstName} {lisa.LastName}");
            Console.WriteLine($"ID = {todd.Id} Name = {todd.FirstName} {todd.LastName}");
        }
    }
}
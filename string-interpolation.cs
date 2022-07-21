using System;

namespace StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int age = 31;
            string name = "Alfonso";
            string job = "Developer";

            //3. String Interpolation (uses $ at the beginning and {variableName}
            //instead of {variableNumber}
      
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old and I am a {job}.");
            Console.Read();
        }
    }
}

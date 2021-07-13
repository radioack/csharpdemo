using System;

namespace csharpDemo
{
    class Program
    {
        private class ExampleClass { }
        static void Main(string[] args)
        {
            // Declare a list of type int.
            GenericCatify<int> genericThing1 = new GenericCatify<int>();
            var returnedString = genericThing1.AddCats(1);
            //Console.WriteLine(returnedString);

            // Declare a list of type string.
            GenericCatify<string> genericThing2 = new GenericCatify<string>();
            var returnedString2 = genericThing2.AddCats("THIS IS FANTASIC!");
            //Console.WriteLine(returnedString2);

            // Declare a list of type ExampleClass.
            GenericCatify<ExampleClass> genericThing3 = new GenericCatify<ExampleClass>();
            var returnedString3 = genericThing3.AddCats(new ExampleClass());
            //Console.WriteLine(returnedString3);
        }
    }
}

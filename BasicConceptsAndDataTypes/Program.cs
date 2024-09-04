using static System.Net.Mime.MediaTypeNames;

namespace BasicConceptsAndDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const string myName = "Feona";
            //Console.WriteLine(myName);
            //Console.WriteLine("\tПривет,Мир");
            //Console.WriteLine("\tМне 22 лет");
            //Console.WriteLine("\tMy name is \n Feona");
            //Console.WriteLine("\u0040");
            //Console.WriteLine("\u0023");
            //Console.ReadKey();

            //Console.WriteLine(true);
            //Console.WriteLine(false);
            //Console.WriteLine(5);
            //Console.WriteLine(0x0A);
            //Console.WriteLine(0b11);
            //Console.WriteLine(5.5);

            //задание 3.3.2

            string MyName = "Jane";
            int Age = 27;
            bool HaveAPet = true;
            double MyShoeSize = 37.5;
            
            Console.WriteLine("My name is " + MyName);
            Console.WriteLine("My age is" + Age);
            Console.WriteLine("Do i have a pet? " + HaveAPet);
            Console.WriteLine("My shoe size is " + MyShoeSize);


        }
    }
}
using System;

namespace HalykBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Здравствуйте! Как вас зовут?");
            string name = Console.ReadLine();
            Console.WriteLine("Ваш возраст?");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 6)
                Console.WriteLine("Здравствуйте " + name + "! Вам пора в садик");
            else if ((age >= 6) && (age < 18))
                Console.WriteLine("Здравствуйте " + name + "! Вам пора в в школу");
            else
                Console.WriteLine("Здравствуйте " + name + "! Вам пора в университет");
        }
    }
}

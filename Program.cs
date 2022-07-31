using System;

namespace my_first_project
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Lütfen adınızı giriniz!");
            string  name;
            name=Console.ReadLine();
            Console.WriteLine("Lütfen yaşınızı giriniz!");
            string age;
            age=Console.ReadLine();
            Console.WriteLine("Hoşgeldiniz " + name + " | " + age);
            
        }
    }
}
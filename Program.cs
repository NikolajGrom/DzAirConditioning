using System;

namespace DzAirConditioning
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            RemoteControl remoteControl = new RemoteControl();
            Console.WriteLine(" Задайте температуру \n");

            human.Temp = double.Parse(Console.ReadLine());

            human.RemContr(human.Temp, remoteControl);



            Console.ReadKey();
            
        }
    }
}

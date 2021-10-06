using System;
namespace DzAirConditioning
{
    
public class Human
    {
        public string Name { get; set; }
        RemoteControl remoteControl { get; set; }
        public double Temp  { get; set; }

        public Human() { }

        public Human(string Name, double Temp, RemoteControl remoteControl)
        {
            this.Temp = Temp;
            this.Name = Name;
            this.remoteControl = remoteControl;
        }

        public void RemContr(double Temp, RemoteControl remoteControl)
        {
            if (Temp < 15 || Temp < 24)
            {
                Console.WriteLine(" Включяю кондиционер : " + remoteControl.On + "\n");
                Console.Write(" Установить режим нагрева : ");
                remoteControl.WarmMode();

            }
            else if(Temp >= 24)
            {
                Console.WriteLine(" Выключяю кондиционер : " + remoteControl.Off + "\n");
            }
            else
            {
                Console.WriteLine(" Мне норм ");
            }
        }


    }
}